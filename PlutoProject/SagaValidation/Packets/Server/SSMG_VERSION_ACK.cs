using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaValidation.Packets.Server
{
    public class SSMG_VERSION_ACK : SagaLib.Packets.SSMG_PACKET
    {
        public enum Result
        {
            OK = 0,
            VERSION_MISSMATCH = -1
        }

        [Packet(OrderIndex =1)]
        public short CheckResult { get; set; }

        [Packet(OrderIndex = 2, IsHexCode = true )]
        public string Version { get; set; }

        public SSMG_VERSION_ACK()
        {
            ID = 0x0002;
            DataLength = sizeof(ushort);
        }
    }
}

