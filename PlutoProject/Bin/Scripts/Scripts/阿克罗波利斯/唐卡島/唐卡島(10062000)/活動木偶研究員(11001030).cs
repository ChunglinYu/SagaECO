﻿using System;
using System.Collections.Generic;
using System.Text;
using SagaLib;
using SagaDB.Actor;
using SagaDB.Item;
using SagaMap.Scripting;
using SagaScript.Chinese.Enums;
namespace SagaScript.M10062000
{
    public class S11001030 : Event
    {
        public S11001030()
        {
            this.EventID = 11001030;
        }

        public override void OnEvent(ActorPC pc)
        {
            Say(pc, 131, "听好了。$R;" +
                "跟人家打招呼的时候，要说『您好』$R;" +
                "$R来，跟我学。$R;");
            Say(pc, 11001063, 131, "您…好？$R;");
            Say(pc, 131, "嗯…我想把你们训练成$R优雅的女士的形象，$R;" +
                "不过比想像还难…$R;");
        }
    }
}