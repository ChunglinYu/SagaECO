using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaValidation.Packets.Server
{
    public class SSMG_LOGIN_ALLOWED : SagaLib.Packets.SSMG_PACKET
    {
        [Packet(OrderIndex = 1)]
        public uint FrontWord { get; set; }
        [Packet(OrderIndex = 2)]
        public uint BackWord { get; set; }

        public SSMG_LOGIN_ALLOWED()
        {
            ID = 0x001E;
            DataLength = sizeof(ushort) + sizeof(uint) * 2;
        }


        //public SSMG_LOGIN_ALLOWED()
        //{
        //    this.data = new byte[10];
        //    this.offset = 14;
        //    this.ID = 0x001E;
        //}

        //public uint FrontWord
        //{
        //    set
        //    {
        //        this.PutUInt(value, 2);
        //    }
        //}

        //public uint BackWord
        //{
        //    set
        //    {
        //        this.PutUInt(value, 6);
        //    }
        //}

    }
}

