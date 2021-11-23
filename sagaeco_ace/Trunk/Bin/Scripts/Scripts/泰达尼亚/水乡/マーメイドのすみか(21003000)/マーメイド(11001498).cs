﻿using System;
using System.Collections.Generic;
using System.Text;

using SagaDB.Actor;
using SagaMap.Scripting;

using SagaLib;
namespace SagaScript.M21003000
{
    public class S11001498 : Event
    {
        public S11001498()
        {
            this.EventID = 11001498;
        }

        public override void OnEvent(ActorPC pc)
        {
            Say(pc, 131, "似乎最近、有很多人类过來呢。$R;", "美人鱼");
        }


    }
}


