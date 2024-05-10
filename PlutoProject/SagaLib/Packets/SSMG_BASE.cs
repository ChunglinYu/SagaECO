using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SagaLib;

namespace SagaLib.Packets
{
    public class SSMG_BASE
    {
        /// <summary>
        /// 不含 PacketLength 本身 sizeof(ushort) 的封包大小。
        /// </summary>
        [Packet(OrderIndex = -2, IsPacketSizeVariable = true)]
        public ushort PacketLength { get; set; }
        [Packet(OrderIndex = -1)]
        public ushort PacketID { get; set; }

        public SSMG_BASE()
        {
            PacketLength = 0;
        }

        public Packet ToPacket()
        {
            Dictionary<PropertyInfo, PacketAttribute> pairs = new Dictionary<PropertyInfo, PacketAttribute>();

            PropertyInfo[] propertyInfos = this.GetType().GetProperties();

            foreach (var item in propertyInfos)
            {
                object[] obj = item.GetCustomAttributes(typeof(PacketAttribute), false);
                foreach (var objItem in obj)
                {
                    if (objItem is PacketAttribute)
                    {
                        pairs.Add(item, (PacketAttribute)objItem);
                    }
                }
            }

            // 依 OrderIndex 做屬性排序
            var sorted = pairs.OrderBy(v => v.Value.OrderIndex);

            PropertyInfo propertySizeVariable = null;
            System.IO.MemoryStream m = new System.IO.MemoryStream();
            System.Text.Encoding encoding;
            ushort dataSize = 0;
            byte[] buf;

            foreach (KeyValuePair<PropertyInfo, PacketAttribute> pair in sorted)
            {
                if (pair.Key.PropertyType == typeof(ushort))
                {
                    ushort value = 0;
                    if (!pair.Value.IsPacketSizeVariable)
                        dataSize += sizeof(ushort);
                    else
                        propertySizeVariable = pair.Key;

                    value = (ushort)pair.Key.GetValue(this, null);

                    //buf = new byte[sizeof(ushort)];
                    //buf[1] = (byte)value;
                    //buf[0] = (byte)(value >> 8);
                    //m.Write(buf, 0, sizeof(ushort));

                    m.WriteByte((byte)(value >> 8));
                    m.WriteByte((byte)value);

                }
                else if (pair.Key.PropertyType == typeof(short))
                {
                    short value = 0;

                    value = (short)pair.Key.GetValue(this, null);

                    m.WriteByte((byte)(value >> 8));
                    m.WriteByte((byte)value);

                    dataSize += sizeof(short);

                }
                else if (pair.Key.PropertyType == typeof(uint))
                {
                    uint value = 0;
                    value = (uint)pair.Key.GetValue(this, null);

                    m.WriteByte((byte)(value >> 24));
                    m.WriteByte((byte)(value >> 16));
                    m.WriteByte((byte)(value >> 8));
                    m.WriteByte((byte)value);

                    dataSize += sizeof(uint);
                }
                else if (pair.Key.PropertyType == typeof(string))
                {
                    string stringValue = pair.Key.GetValue(this, null).ToString();

                    if (pair.Value.IsHexCode)
                    {
                        buf = Conversions.HexStr2Bytes(stringValue);
                        m.Write(buf, 0, buf.Length);
                        dataSize += (ushort)(buf.Length);
                    }
                    else
                    {

                    }
                        // 寫入結構固定為 資料長度(1 byte) + 資料(? bytes) + 資料結尾 \0 (1 byte)

                        if (pair.Value.Encoding != null)
                    {
                        encoding = System.Text.Encoding.GetEncoding(pair.Value.Encoding);
                    }
                    else
                    {
                        encoding = System.Text.Encoding.GetEncoding("UTF-8");
                    }

                    string stringValue = pair.Key.GetValue(this, null).ToString();

                    buf = encoding.GetBytes(stringValue);
                    //  寫入bytes 資料長度
                    m.WriteByte(Convert.ToByte(buf.Length + 1)); // 加結尾碼(\0) 長度 
                    dataSize += 1;
                    // 寫入 bytes 資料
                    m.Write(buf, 0, buf.Length);
                    m.WriteByte(0); // 字串結尾
                    dataSize += (ushort)(buf.Length + 1);  // 加結尾碼(\0) 長度 
                }
                else if (pair.Key.PropertyType == typeof(byte))
                {
                    byte value = 0x00;
                    value = (byte)pair.Key.GetValue(this, null);
                    m.WriteByte(value);

                    dataSize += sizeof(byte);
                }
                else if (pair.Key.PropertyType == typeof(int))
                {
                    int value = 0;
                    value = (int)pair.Key.GetValue(this, null);

                    m.WriteByte((byte)(value >> 24));
                    m.WriteByte((byte)(value >> 16));
                    m.WriteByte((byte)(value >> 8));
                    m.WriteByte((byte)value);

                    dataSize += sizeof(int);
                }
            }
            m.Flush();

            if (propertySizeVariable != null)
            {
                propertySizeVariable.SetValue(this, (ushort)dataSize, null);
            }
            // 回填封包資料實際長度 (IsLittleEndian 處理)
            m.GetBuffer()[1] = (byte)dataSize;
            m.GetBuffer()[0] = (byte)(dataSize >> 8);

            System.Diagnostics.Debug.WriteLine(dataSize);
            string a = m.ToArray().ToHex();
            System.Diagnostics.Debug.WriteLine(a);

            Packet p = new Packet();

            p.offset = 0;
            p.data = m.GetBuffer();

            return p;

        }

    }



}
