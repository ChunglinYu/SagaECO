using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Threading;
using System.Data;
using System.Data.SQLite;

using SagaLib;

namespace SagaDB
{
    public abstract class SQLiteConnectivity
    {
        class SqlCommand
        {
            public enum CommandType
            {
                NonQuery,
                Query,
                Scalar
            }
            SQLiteCommand cmd;
            DataRowCollection reader;
            CommandType type;
            uint scalar = uint.MaxValue;
            int errorCount = 0;

            public SQLiteCommand Command { get { return this.cmd; } }

            public DataRowCollection DataRows { get { return this.reader; } set { this.reader = value; } }

            public CommandType Type { get { return this.type; } }

            public uint Scalar { get { return this.scalar; } set { this.scalar = value; } }

            public SqlCommand(SQLiteCommand cmd)
            {
                this.cmd = cmd;
                type = CommandType.NonQuery;
            }

            public SqlCommand(SQLiteCommand cmd, CommandType type)
            {
                this.cmd = cmd;
                this.type = type;
            }

            public int ErrorCount { get { return this.errorCount; } set { this.errorCount = value; } }
        }
        protected SQLiteConnection db;
        protected SQLiteConnection dbinactive;
        Thread sqlitePool;

        List<SqlCommand> waitQueue = new List<SqlCommand>();
        internal int cuurentCount = 0;

        public SQLiteConnectivity()
        {
            sqlitePool = new Thread(new ThreadStart(ProcessMysql));
            sqlitePool.Start();
        }

        public bool CanClose
        {
            get
            {
                lock (waitQueue)
                    return (waitQueue.Count == 0 && cuurentCount == 0);
            }
        }

        void ProcessMysql()
        {
            while (true)
            {
                try
                {
                    SqlCommand[] cmds;
                    lock (waitQueue)
                    {
                        if (waitQueue.Count > 0)
                        {
                            cmds = waitQueue.ToArray();
                            waitQueue.Clear();
                            cuurentCount = cmds.Length;
                        }
                        else
                            cmds = new SqlCommand[0];
                    }
                    if (cmds.Length > 0)
                    {
                        List<SqlCommand> pending = new List<SqlCommand>();
                        DatabaseWaitress.EnterCriticalArea();

                        foreach (SqlCommand i in cmds)
                        {
                            try
                            {
                                i.Command.Connection = db;
                                switch (i.Type)
                                {
                                    case SqlCommand.CommandType.NonQuery:
                                        i.Command.ExecuteNonQuery();
                                        break;
                                    case SqlCommand.CommandType.Query:
                                        // DataSet 填入 SQLite datetime 欄位，會有不相容的錯誤：字串未被辨認為有效的 DateTime。String was not recognized as a valid DateTime.
                                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(i.Command);
                                        DataSet set = new DataSet();
                                        adapter.Fill(set);
                                        i.DataRows = set.Tables[0].Rows;

                                        #region 日期型態除錯用
                                        /*
                                        using (SQLiteDataReader reader=i.Command.ExecuteReader())
                                        {
                                            DataTable dt = new DataTable();
                                            
                                            for(int f=0; f < reader.FieldCount;f++)
                                            {
                                                dt.Columns.Add(reader.GetName(f), reader.GetFieldType(f));
                                            }

                                            while(reader.Read())
                                            {
                                                DataRow dr = dt.NewRow();
                                                for (int f = 0; f < reader.FieldCount; f++)
                                                {
                                                    if(reader.GetFieldType(f) == typeof(System.DateTime))
                                                    {
                                                        int a;
                                                        a = 1;
                                                        System.Diagnostics.Debug.WriteLine(reader.GetValue(f));
                                                    }
                                                    try
                                                    {
                                                        dr[f] = reader.GetValue(f);
                                                    }
                                                    catch(Exception ex)
                                                    {
                                                        System.Diagnostics.Debug.WriteLine(reader.GetValue(f));

                                                    }
                                                }
                                                dt.Rows.Add(dr);
                                            }
                                            i.DataRows = dt.Rows;

                                        } */
                                        #endregion

                                        break;
                                    case SqlCommand.CommandType.Scalar:
                                        i.Scalar = Convert.ToUInt32(i.Command.ExecuteScalar());
                                        break;
                                }


                            }
                            catch (Exception ex)
                            {
                                Logger.ShowSQL("Error on query:" + command2String(i.Command), Logger.defaultlogger);
                                Logger.ShowSQL(ex, Logger.defaultlogger);
                                i.ErrorCount++;
                                if (i.ErrorCount > 10)
                                {
                                    Logger.ShowSQL("Error to many times, dropping command", Logger.defaultlogger);
                                }
                                else
                                    pending.Add(i);
                            }
                        }

                        DatabaseWaitress.LeaveCriticalArea();
                        if (pending.Count > 0)
                        {
                            lock (waitQueue)
                            {
                                foreach (SqlCommand i in pending)
                                {
                                    waitQueue.Add(i);
                                }
                            }
                        }
                        pending = null;
                    }
                    cmds = null;
                    cuurentCount = 0;
                    Thread.Sleep(10);
                }
                catch (System.Threading.ThreadAbortException)
                {
                    DatabaseWaitress.LeaveCriticalArea();
                }
            }
        }

        public bool SQLExecuteNonQuery(string sqlstr)
        {
            lock (waitQueue)
            {
                SqlCommand cmd = new SqlCommand(new SQLiteCommand(sqlstr));
                waitQueue.Add(cmd);
            }
            return true;
        }

        string command2String(SQLiteCommand cmd)
        {
            string output;
            output = cmd.CommandText;
            if (cmd.Parameters.Count > 0)
            {
                string para = "";
                foreach (SQLiteParameter i in cmd.Parameters)
                {
                    para += string.Format("{0}={1},", i.ParameterName, value2String(i.Value));
                }
                para = para.Substring(0, para.Length - 1);
                output = string.Format("{0} VALUES({1})", output, para);
            }
            return output;
        }

        string value2String(object val)
        {
            if (val.GetType() == typeof(byte[]))
            {
                byte[] tmp = (byte[])val;
                return "0x" + Conversions.bytes2HexString(tmp);
            }
            return val.ToString();
        }

        public bool SQLExecuteNonQuery(SQLiteCommand cmd)
        {
            lock (waitQueue)
            {
                waitQueue.Add(new SqlCommand(cmd));
            }
            return true;
        }

        public bool SQLExecuteScalar(string sqlstr, out uint index)
        {
            bool criticalarea = ClientManager.Blocked;
            bool result = true;
            if (criticalarea)
                ClientManager.LeaveCriticalArea();
            try
            {
                if (sqlstr.Substring(sqlstr.Length - 1) != ";") sqlstr += ";";
                sqlstr += "select last_insert_rowid();";
                SqlCommand cmd = new SqlCommand(new SQLiteCommand(sqlstr), SqlCommand.CommandType.Scalar);
                lock (waitQueue)
                {
                    waitQueue.Add(cmd);
                }
                while (cmd.Scalar == uint.MaxValue)
                {
                    Thread.Sleep(10);
                }
                index = cmd.Scalar;
            }
            catch (Exception ex)
            {
                Logger.ShowSQL(ex, Logger.defaultlogger);
                result = false;
                index = 0;
            }
            if (criticalarea)
                ClientManager.EnterCriticalArea();
            return result;
        }

        public DataRowCollection SQLExecuteQuery(string sqlstr)
        {
            DataRowCollection result;
            DataSet tmp;
            bool criticalarea = ClientManager.Blocked;
            if (criticalarea)
                ClientManager.LeaveCriticalArea();
            try
            {
                SqlCommand cmd = new SqlCommand(new SQLiteCommand(sqlstr), SqlCommand.CommandType.Query);
                lock (waitQueue)
                    waitQueue.Add(cmd);

                while (cmd.DataRows == null)
                {
                    Thread.Sleep(10);
                }
                result = cmd.DataRows;
                if (criticalarea)
                    ClientManager.EnterCriticalArea();
                return result;
            }
            catch (Exception ex)
            {
                Logger.ShowSQL("Error on query:" + sqlstr, Logger.defaultlogger);
                Logger.ShowSQL(ex, Logger.defaultlogger);
                if (criticalarea)
                    ClientManager.EnterCriticalArea();
                return null;
            }

        }


        public string ToSQLDateTime(DateTime date)
        {
            //return string.Format("{0}-{1}-{2} {3}:{4}:{5}", date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
            return string.Format("{0:yyyy-MM-dd HH:mm:ss}", date);
        }

        public void CheckSQLString(ref string str)
        {
            str = str.Replace("\\", "").Replace("'", "\\'");
        }

        public string CheckSQLString(string str)
        {
            return str.Replace("\\", "").Replace("'", "\\'");
        }

    }
}
