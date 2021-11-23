﻿using System;
using System.Collections.Generic;
using System.Text;

using SagaDB.Actor;
using SagaMap.Scripting;

using SagaLib;
using SagaScript.Chinese.Enums;
//所在地圖:飛空庭的房間(30202002) NPC基本信息:飛天鼠(18000182) X:7 Y:6
namespace SagaScript.M30202002
{
    public class S18000182 : Event
    {
        public S18000182()
        {
            this.EventID = 18000182;
        }

        public override void OnEvent(ActorPC pc)
        {
            BitMask<Beginner_01> Beginner_01_mask = new BitMask<Beginner_01>(pc.CMask["Beginner_01"]);

            if (!Beginner_01_mask.Test(Beginner_01.發現床底下的東西))
            {
                發現床底下的東西(pc);
                return;
            }

            Say(pc, 18000182, 0, "…$R;", "飛天鼠");
        }

        void 發現床底下的東西(ActorPC pc)
        {
            BitMask<Beginner_01> Beginner_01_mask = new BitMask<Beginner_01>(pc.CMask["Beginner_01"]);

            Beginner_01_mask.SetValue(Beginner_01.發現床底下的東西, true);

            Say(pc, 18000182, 0, "…$R;" +
                                 "$R（在看床底下）$R;", "飛天鼠");

            Say(pc, 0, 0, "哎?$R;" +
                          "床底下有什麼嗎?$R;", " ");

            PlaySound(pc, 2040, false, 100, 50);
            GiveItem(pc, 10001250, 1);
            Say(pc, 0, 0, "得到『合成失敗物』!$R;", " ");
        }
    }
}
