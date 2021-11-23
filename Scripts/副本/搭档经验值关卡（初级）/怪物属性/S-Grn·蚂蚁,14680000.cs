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
namespace 每日地牢
{
    public partial class 每日地牢
    {
        ActorMob.MobInfo 蚂蚁Info()
        {
            ActorMob.MobInfo info = new ActorMob.MobInfo();
            info.name = "S-Grn·蚂蚁";
            info.level = 80;
            info.maxhp = 6000;
            info.speed = 550;
            info.atk_min = 400;
            info.atk_max = 500;
            info.matk_min = 200;
            info.matk_max = 300;
            info.def = 0;
            info.def_add = 0;
            info.mdef = 0;
            info.mdef_add = 0;
            info.hit_critical = 23;
            info.hit_magic = 118;
            info.hit_melee = 118;
            info.hit_ranged = 120;
            info.avoid_critical = 0;
            info.avoid_magic = 0;
            info.avoid_melee = 0;
            info.avoid_ranged = 0;
            info.Aspd = 540;
            info.Cspd = 540;
            info.elements[SagaLib.Elements.Neutral] = 0;
            info.elements[SagaLib.Elements.Fire] = 0;
            info.elements[SagaLib.Elements.Water] = 70;
            info.elements[SagaLib.Elements.Wind] = 0;
            info.elements[SagaLib.Elements.Earth] = 0;
            info.elements[SagaLib.Elements.Holy] = 0;
            info.elements[SagaLib.Elements.Dark] = 0;
            info.abnormalstatus[SagaLib.AbnormalStatus.Confused] = 30;
            info.abnormalstatus[SagaLib.AbnormalStatus.Frosen] = 30;
            info.abnormalstatus[SagaLib.AbnormalStatus.Paralyse] = 30;
            info.abnormalstatus[SagaLib.AbnormalStatus.Poisen] = 30;
            info.abnormalstatus[SagaLib.AbnormalStatus.Silence] = 30;
            info.abnormalstatus[SagaLib.AbnormalStatus.Sleep] = 30;
            info.abnormalstatus[SagaLib.AbnormalStatus.Stone] = 30;
            info.abnormalstatus[SagaLib.AbnormalStatus.Stun] = 30;
            info.abnormalstatus[SagaLib.AbnormalStatus.鈍足] = 30;
            info.baseExp = info.maxhp * 4;
            info.jobExp = info.maxhp * 4;

            MobData.DropData newDrop = new MobData.DropData();
            newDrop.ItemID = 910000092;//掉落物品ID
            newDrop.Rate = 3000;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);

            newDrop = new MobData.DropData();
            newDrop.ItemID = 910000093;//掉落物品ID
            newDrop.Rate = 2000;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);

            newDrop = new MobData.DropData();
            newDrop.ItemID = 910000094;//掉落物品ID
            newDrop.Rate = 1000;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);

            newDrop = new MobData.DropData();
            newDrop.ItemID = 910000095;//掉落物品ID
            newDrop.Rate = 800;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);

            newDrop = new MobData.DropData();
            newDrop.ItemID = 910000096;//掉落物品ID
            newDrop.Rate = 500;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);


            newDrop = new MobData.DropData();
            newDrop.ItemID = 910000116;//掉落物品ID
            newDrop.Rate = 10;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);

            newDrop = new MobData.DropData();
            newDrop.ItemID = 950000000;//掉落物品ID
            newDrop.Rate = 3;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);

            newDrop = new MobData.DropData();
            newDrop.ItemID = 950000001;//掉落物品ID
            newDrop.Rate = 3;//掉落幾率,10000是100%，5000是50%
            info.dropItems.Add(newDrop);



            return info;
        }
        AIMode 蚂蚁AI()
        {
            AIMode ai = new AIMode(0); ai.MobID = 10000000; ai.isNewAI = true;//1為主動，0為被動
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

