using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;
using SagaDB.Actor;
using SagaDB.Item;

namespace SagaMap.Packets.Server
{
    public class SSMG_PLAYER_TITLE : Packet
    {
        public SSMG_PLAYER_TITLE()
        {
            this.data = new byte[20];//8bytes unknowns
            this.offset = 2;
            this.ID = 0x2419;
            PutByte(4, 3);
        }

        public byte Result
        {
            set
            {
                this.PutByte(value, 2);
            }
        }

        public void PutTitles(List<uint> titles)
        {
            offset = 3;
            this.PutByte((byte)titles.Count, 3);
            foreach (uint title in titles)
            {
                this.PutUInt(title, offset);
            }
        }
    }
}
        
