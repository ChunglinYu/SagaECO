using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaValidation.Packets.Server
{
    public class SSMG_PONG : SagaLib.Packets.SSMG_PACKET
    {
        [Packet(OrderIndex =1)]
        public uint Unknown { get; set; }

        public SSMG_PONG()
        {
            ID = 0x000B;
            Unknown = 0;
            DataLength = sizeof(ushort) +sizeof(uint);
        }

        //public SSMG_PONG()
        //{
        //    this.data = new byte[6];
        //    this.offset = 2;
        //    this.ID = 0x0B;   
        //}

    }
}

