﻿using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;
using SagaMap.Scripting;

namespace SagaMap.Scripting
{
    public enum UIType
    {
        Status = 1,
        Item,
        Equip,
        Skill,
        FriendList,
        Mail,
        Quest,
        Minimap,
        Macro,
        BBS,
        Stamp = 20,
        FGEquipt,
        WRPRanking = 23,
        MiniGame,
        ECoin,
        Furniture = 30,
        MinimapSmall,
        MinimapLarge
    }
}

namespace SagaMap.Packets.Server
{
    public class SSMG_NPC_SHOW_UI : Packet
    {
        public SSMG_NPC_SHOW_UI()
        {
            this.data = new byte[10];
            this.offset = 2;
            this.ID = 0x0622;

            this.PutUInt(1, 2);
        }

        public UIType UIType
        {
            set
            {
                this.PutInt((int)value, 6);
            }
        }

    }
}

