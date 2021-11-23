﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net;
using System.Net.Sockets;

using SagaDB;
using SagaDB.Item;
using SagaDB.Actor;
using SagaLib;
using SagaValidation;
using SagaValidation.Manager;

namespace SagaValidation.Network.Client
{
    public partial class ValidationClient : SagaLib.Client
    {
        private string client_Version;

        private uint frontWord, backWord;

        public bool IsMapServer = false;

        public Account account;

        public enum SESSION_STATE
        {
            LOGIN, MAP, REDIRECTING, DISCONNECTED
        }
        public SESSION_STATE state;

        public ValidationClient(Socket mSock, Dictionary<ushort, Packet> mCommandTable)
        {
            this.netIO = new NetIO(mSock, mCommandTable, this);
                this.netIO.FirstLevelLength = 2;
            this.netIO.SetMode(NetIO.Mode.Server);
            if (this.netIO.sock.Connected) this.OnConnect();
        }
        public override void OnConnect()
        {

        }
        public void OnLogin(Packets.Client.CSMG_LOGIN p)
        {
            p.GetContent();
            if (ValidationServer.accountDB.CheckPassword(p.UserName, p.Password, this.frontWord, this.backWord))
            {
                Packets.Server.SSMG_LOGIN_ACK p1 = new SagaValidation.Packets.Server.SSMG_LOGIN_ACK();
                p1.LoginResult = SagaValidation.Packets.Server.SSMG_LOGIN_ACK.Result.OK;
                this.netIO.SendPacket(p1);
            }
            else
            {
                Packets.Server.SSMG_LOGIN_ACK p1 = new SagaValidation.Packets.Server.SSMG_LOGIN_ACK();
                p1.LoginResult = SagaValidation.Packets.Server.SSMG_LOGIN_ACK.Result.GAME_SMSG_LOGIN_ERR_BADPASS;
                this.netIO.SendPacket(p1);
            }
        }

        public void OnConfirmLogin(Packets.Client.CSMG_LOGIN_REQUEST_CONFIRM p)
        {
            Packets.Server.SSMG_LOGIN_CONFIRMED p1 = new Packets.Server.SSMG_LOGIN_CONFIRMED();
            this.netIO.SendPacket(p1);
        }

        public void OnSendVersion(Packets.Client.CSMG_SEND_VERSION p)
        {
            Logger.ShowInfo("Client(Version:" + p.GetVersion() + ") is trying to connect...");
            this.client_Version = p.GetVersion();

            string args = "FF FF E8 6A 6A CA DC E8 06 05 2B 29 F8 96 2F 86 7C AB 2A 57 AD 30";
            byte[] buf = Conversions.HexStr2Bytes(args.Replace(" ", ""));
            Packet p3 = new Packet();
            p3.data = buf;
            this.netIO.SendPacket(p3);

            Packets.Server.SSMG_VERSION_ACK p1 = new SagaValidation.Packets.Server.SSMG_VERSION_ACK();

            //Game Client Check
            if (Configuration.Instance.ClientGameVersion != "All")
            {
                if(this.client_Version != Configuration.Instance.ClientGameVersion)
                {
                    Logger.ShowInfo(p.GetVersion() + " - Client Version Mismatch. Droping..");
                    p1.SetResult(SagaValidation.Packets.Server.SSMG_VERSION_ACK.Result.GAME_SMSG_LOGIN_ERR_PROTO_VERSION);
                    p1.SetVersion(this.client_Version);
                    this.netIO.SendPacket(p1);
                    return;
                }
            }

            p1.SetResult(SagaValidation.Packets.Server.SSMG_VERSION_ACK.Result.OK);
            p1.SetVersion(this.client_Version);
            this.netIO.SendPacket(p1);

            Packets.Server.SSMG_LOGIN_ALLOWED p2 = new SagaValidation.Packets.Server.SSMG_LOGIN_ALLOWED();
            this.frontWord = (uint)Global.Random.Next();
            this.backWord = (uint)Global.Random.Next();
            p2.FrontWord = this.frontWord;
            p2.BackWord = this.backWord;
            this.netIO.SendPacket(p2);
        }
        public void OnServerLstSend(Packets.Client.CSMG_SERVERLET_ASK p)
        {
            Packets.Server.SSMG_SERVER_LST_START p1 = new Packets.Server.SSMG_SERVER_LST_START();
            this.netIO.SendPacket(p1);

            Packets.Server.SSMG_SERVER_LST_SEND p2 = new Packets.Server.SSMG_SERVER_LST_SEND();
            p2.SevName = Configuration.Instance.ServerName;
            p2.SevIP = "T" + Configuration.Instance.ServerIP + "," + Configuration.Instance.ServerIP + "," +
                Configuration.Instance.ServerIP + "," + Configuration.Instance.ServerIP;
            this.netIO.SendPacket(p2);

            Packets.Server.SSMG_SERVER_LST_END p3 = new Packets.Server.SSMG_SERVER_LST_END();
            this.netIO.SendPacket(p3);
        }
        public void OnPing(Packets.Client.CSMG_PING p)
        {
            Packets.Server.SSMG_PONG p1 = new SagaValidation.Packets.Server.SSMG_PONG();
            this.netIO.SendPacket(p1);
        }
    }
}
