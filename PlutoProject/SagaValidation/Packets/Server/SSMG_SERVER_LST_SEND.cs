using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using SagaLib;

using SagaDB.Actor;

namespace SagaValidation.Packets.Server
{
    public class SSMG_SERVER_LST_SEND : SagaLib.Packets.SSMG_PACKET
    {
        [Packet(OrderIndex =1, Encoding = "UTF-8")]
        public string ServerName { get; set; }

        [Packet(OrderIndex = 2, Encoding = "UTF-8")]
        public string ServerIP { get; set; }

        public SSMG_SERVER_LST_SEND()
        {
            ID = 0x0033;
            DataLength = sizeof(ushort);
        }
    }
}