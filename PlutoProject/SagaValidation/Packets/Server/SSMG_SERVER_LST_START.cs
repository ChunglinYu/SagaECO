using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using SagaLib;

using SagaDB.Actor;

namespace SagaValidation.Packets.Server
{
    public class SSMG_SERVER_LST_START : SagaLib.Packets.SSMG_PACKET
    {
        public SSMG_SERVER_LST_START()
        {
            ID = 0x0032;
            DataLength = sizeof(ushort);
        }

        //public SSMG_SERVER_LST_START()
        //{
        //    this.data = new byte[2];
        //    this.offset = 2;
        //    this.ID = 0x32;
        //}
    }
}
