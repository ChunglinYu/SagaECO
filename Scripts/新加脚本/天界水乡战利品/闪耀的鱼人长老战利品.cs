﻿
using System;
using System.Collections.Generic;
using System.Text;
using SagaLib;
using SagaDB.Actor;
using SagaDB.Item;
using SagaMap.Scripting;
using SagaScript.Chinese.Enums;
namespace SagaScript.M30210000
{
    public class S953000015 : Event
    {
        public S953000015()
        {
            this.EventID = 953000015;
        }

        public override void OnEvent(ActorPC pc)
        {
            if (CountItem(pc, 953000015) >= 1)
            {
                TakeItem(pc, 953000015, 1);
                奖励(pc);
            }
        }
        void 奖励(ActorPC pc)
        {

        }
    }
}

