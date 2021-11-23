﻿using System;
using System.Collections.Generic;
using System.Text;

using SagaDB.Item;
using SagaDB.Actor;
using SagaMap.Scripting;

using SagaLib;
using SagaScript.Chinese.Enums;
namespace SagaScript
{
    public class P10000283 : RandomPortal
    {
        public P10000283()
        {
            Init(10000283, 10030000, 217, 252, 220, 253);
        }
    }
    //原始地圖:步伐沙漠(10042000)
    //目標地圖:果樹森林(10030000)
    //目標坐標:(217,252) ~ (220,253)

    public class P10000284 : RandomPortal
    {
        public P10000284()
        {
            Init(10000284, 10043000, 154, 2, 157, 3);
        }
    }
    //原始地圖:奧克魯尼亞南部平原(10031000)
    //目標地圖:樂天娜湖泊下游(10043000)
    //目標坐標:(154,2) ~ (157,3)

    public class P10000285 : RandomPortal
    {
        public P10000285()
        {
            Init(10000285, 10031000, 154, 252, 157, 253);
        }
    }
    //原始地圖:樂天娜湖泊下游(10043000)
    //目標地圖:奧克魯尼亞南部平原(10031000)
    //目標坐標:(154,252) ~ (157,253)

    public class P10000288 : RandomPortal
    {
        public P10000288()
        {
            Init(10000288, 10034000, 1, 223, 3, 226);
        }
    }
    //原始地圖:樂天娜湖泊(10032000)
    //目標地圖:奧克魯尼亞東海岸(10034000)
    //目標坐標:(1,223) ~ (3,226)
    public class P10000290 : RandomPortal
    {
        public P10000290()
        {
            Init(10000290, 10046000, 56, 2, 59, 4);
        }
    }
    //原始地圖:步伐沙漠(10042000)
    //目標地圖:南方海角(10046000)
    //目標坐標:(56,2) ~ (59,4)

    public class P10000291 : RandomPortal
    {
        public P10000291()
        {
            Init(10000291, 10042000, 56, 252, 59, 254);
        }
    }
    //原始地圖:南方海角(10046000)
    //目標地圖:步伐沙漠(10042000)
    //目標坐標:(56,252) ~ (59,254)

    public class P10000292 : RandomPortal
    {
        public P10000292()
        {
            Init(10000292, 10046000, 56, 1, 59, 3);
        }
    }
    //原始地圖:步伐沙漠(10042000)
    //目標地圖:南方海角(10046000)
    //目標坐標:(56,1) ~ (59,3)

    public class P10000293 : RandomPortal
    {
        public P10000293()
        {
            Init(10000293, 10042000, 56, 251, 59, 253);
        }
    }
    //原始地圖:南方海角(10046000)
    //目標地圖:步伐沙漠(10042000)
    //目標坐標:(56,251) ~ (59,253)

    public class P10000298 : RandomPortal
    {
        public P10000298()
        {
            Init(10000298, 10043000, 1, 27, 3, 30);
        }
    }
    //原始地圖:步伐沙漠(10042000)
    //目標地圖:樂天娜湖泊下游(10043000)
    //目標坐標:(1,27) ~ (3,30)

    public class P10000299 : RandomPortal
    {
        public P10000299()
        {
            Init(10000299, 10042000, 252, 27, 254, 30);
        }
    }
    //原始地圖:樂天娜湖泊下游(10043000)
    //目標地圖:步伐沙漠(10042000)
    //目標坐標:(252,27) ~ (254,30)

    public class P10000302 : RandomPortal
    {
        public P10000302()
        {
            Init(10000302, 10043000, 1, 226, 3, 229);
        }
    }
    //原始地圖:南方海角(10046000)
    //目標地圖:樂天娜湖泊下游(10043000)
    //目標坐標:(1,226) ~ (3,229)

    public class P10000303 : RandomPortal
    {
        public P10000303()
        {
            Init(10000303, 10046000, 199, 1, 202, 3);
        }
    }
    //原始地圖:樂天娜湖泊下游(10043000)
    //目標地圖:南方海角(10046000)
    //目標坐標:(199,1) ~ (202,3)

    public class P10000496 : RandomPortal
    {
        public P10000496()
        {
            Init(10000496, 20070000, 22, 83, 25, 85);
        }
    }
    //原始地圖:步伐沙漠(10042000)
    //目標地圖:無限回廊B1F(20070000)
    //目標坐標:(22,83) ~ (25,85)

    public class P10000665 : Event
    {
        public P10000665()
        {
            this.EventID = 10000665;
        }

        public override void OnEvent(ActorPC pc)
        {
            BitMask<Knights> Knights_mask = pc.CMask["Knights"];

            if (pc.Account.GMLevel >= 100)
            {
                Warp(pc, 10061000, 145, 3);
                return;
            }
            if (pc.Skills2.ContainsKey(706) || pc.SkillsReserve.ContainsKey(706))
            {
                Warp(pc, 10061000, 145, 3);
                return;
            }
            if (Knights_mask.Test(Knights.南國過境檢查完成))
            {
                Warp(pc, 10061000, 145, 3);
                return;
            }
            Say(pc, 131, "您不能入境喔$R;" +
                "$R請接受阿伊恩薩烏斯$R;" +
                "國境警備員的入境審查吧$R;");
        }
    }
    //原始地圖:南方海角(10046000)
    //目標地圖:鬼之寢岩(10061000)
    //目標坐標:(144,2) ~ (147,4)

    public class P10001264 : RandomPortal
    {
        public P10001264()
        {
            Init(10001264, 20070100, 22, 83, 25, 85);
        }
    }
    //原始地圖:步伐沙漠(10042000)、回廊養殖場2F(20070101)、回廊養殖場3F(20070102)
    //目標地圖:回廊養殖場1F(20070100)
    //目標坐標:(22,83) ~ (25,85)

    public class P10001266 : RandomPortal
    {
        public P10001266()
        {
            Init(10001266, 20070102, 22, 83, 25, 85);
        }
    }
    //原始地圖:回廊養殖場1F(20070100)、回廊養殖場2F(20070101)
    //目標地圖:回廊養殖場3F(20070102)
    //目標坐標:(22,83) ~ (25,85)

    public class P10001267 : RandomPortal
    {
        public P10001267()
        {
            Init(10001267, 20070101, 22, 83, 25, 85);
        }
    }
    //原始地圖:回廊養殖場1F(20070100)、回廊養殖場3F(20070102)
    //目標地圖:回廊養殖場2F(20070101)
    //目標坐標:(22,83) ~ (25,85)

    public class P10001268 : RandomPortal
    {
        public P10001268()
        {
            Init(10001268, 20070100, 22, 83, 25, 85);
        }
    }
    //原始地圖:步伐沙漠(10042000)
    //目標地圖:回廊養殖場1F(20070100)
    //目標坐標:(22,83) ~ (25,85)

    public class P10001269 : RandomPortal
    {
        public P10001269()
        {
            Init(10001269, 10042000, 74, 131, 76, 133);
        }
    }
    //原始地圖:回廊養殖場1F(20070100)
    //目標地圖:步伐沙漠(10042000)
    //目標坐標:(74,131) ~ (76,133)
    public class P10001321 : Event
    {
        public P10001321()
        {
            this.EventID = 10001321;
        }

        public override void OnEvent(ActorPC pc)
        {
            if (pc.Level < 15)
            {
                Warp(pc, 30091001, 6, 15);
            }
            else
            {
                Say(pc, 0, 65535, "……??$R;" +
                                  "$R不能進入?$R;" +
                                  "$P啊…忘記說了。$R;" +
                                  "$R有一定經驗的人不能進入「初心者學校」呀!$R;", " ");
            }
        }
    }
    //原始地圖:奧克魯尼亞南部平原(10031000)
    //目標地圖:南部平原初心者學校(30091003)
    //目標坐標:(6,15) ~ (6,15)

    public class P10001322 : Event
    {
        public P10001322()
        {
            this.EventID = 10001322;
        }

        public override void OnEvent(ActorPC pc)
        {
            switch (Select(pc, "想去哪裡呢?", "", "奧克魯尼亞東部平原", "奧克魯尼亞西部平原", "奧克魯尼亞南部平原", "奧克魯尼亞北部平原", "不出去"))
            {
                case 1:
                    Warp(pc, 10025000, 108, 123);
                    break;

                case 2:
                    Warp(pc, 10022000, 143, 133);
                    break;

                case 3:
                    Warp(pc, 10031000, 132, 121);
                    break;

                case 4:
                    Warp(pc, 10014000, 123, 147);
                    break;

                case 5:
                    break;
            }
        }
    }
    //原始地圖:南部平原初心者學校(30091003)
    //目標地圖:奧克魯尼亞南部平原(10031000)
    //目標坐標:(132,121) ~ (132,121)
}