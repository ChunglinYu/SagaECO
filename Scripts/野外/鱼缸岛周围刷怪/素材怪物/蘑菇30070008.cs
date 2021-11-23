﻿
using System;
using System.Collections.Generic;
using System.Text;
using SagaLib;
using SagaDB.Actor;
using SagaDB.Item;
using SagaMap.Scripting;
using SagaScript.Chinese.Enums;
using SagaDB.Actor;
using SagaMap.Mob;
using SagaDB.Mob;
namespace WeeklyExploration
{
    public partial class YugangdaoASpawn
    {
        public static ActorMob.MobInfo 蘑菇Info()
        {
            ActorMob.MobInfo info = new ActorMob.MobInfo();
            info.name = "蘑菇";
            info.maxhp = 3;
            info.speed = 0;
            info.atk_min = 0;
            info.atk_max = 0;
            info.matk_min = 0;
            info.matk_max = 0;
            info.def = 0;
            info.def_add = 0;
            info.mdef = 0;
            info.mdef_add = 0;
            info.hit_critical = 14;
            info.hit_magic = 50;
            info.hit_melee = 78;
            info.hit_ranged = 79;
            info.avoid_critical = 14;
            info.avoid_magic = 24;
            info.avoid_melee = 60;
            info.avoid_ranged = 58;
            info.Aspd = 550;
            info.Cspd = 440;
            info.elements[SagaLib.Elements.Neutral] = 0;
            info.elements[SagaLib.Elements.Fire] = 0;
            info.elements[SagaLib.Elements.Water] = 70;
            info.elements[SagaLib.Elements.Wind] = 0;
            info.elements[SagaLib.Elements.Earth] = 0;
            info.elements[SagaLib.Elements.Holy] = 0;
            info.elements[SagaLib.Elements.Dark] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.Confused] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.Frosen] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.Paralyse] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.Poisen] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.Silence] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.Sleep] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.Stone] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.Stun] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.鈍足] = 0;
            info.baseExp = info.maxhp;
            info.jobExp = info.maxhp;


            MobData.DropData newDrop = new MobData.DropData();
            newDrop.ItemID = 10006900;//掉落物品ID
            newDrop.Rate = 7000;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);

            newDrop = new MobData.DropData();
            newDrop.ItemID = 10007001;//掉落物品ID
            newDrop.Rate = 200;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);



            return info;
        }
        public static AIMode 蘑菇AI()
        {
            AIMode ai = new AIMode(6); ai.MobID = 10000000; ai.isNewAI = true;//1為主動，0為被動
            ai.MobID = 10960002;//怪物ID
            ai.isNewAI = true;//使用的是TT AI
            ai.Distance = 3;//遠程進程切換距離，與敵人3格距離切換
            ai.ShortCD = 3;//進程技能表最短釋放間隔，3秒一次
            ai.LongCD = 3;//遠程技能表最短釋放間隔，3秒一次
            AIMode.SkilInfo skillinfo = new AIMode.SkilInfo();

            return ai;
        }
    }
}

