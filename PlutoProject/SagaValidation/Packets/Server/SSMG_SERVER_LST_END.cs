using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using SagaLib;

using SagaDB.Actor;

namespace SagaValidation.Packets.Server
{
    public class SSMG_SERVER_LST_END : SagaLib.Packets.SSMG_PACKET
    {
        public SSMG_SERVER_LST_END()
        {
            ID = 0x0034;
            DataLength = sizeof(ushort);
        }
    }
}