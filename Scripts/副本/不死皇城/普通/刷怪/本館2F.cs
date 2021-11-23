﻿
using System;
using System.Collections.Generic;
using System.Text;
using SagaLib;
using SagaDB.Actor;
using SagaDB.Item;
using SagaMap.Scripting;
using SagaScript.Chinese.Enums;
using SagaMap.Mob;
using SagaMap.Skill;
using SagaDB.Mob;
using SagaMap.ActorEventHandlers;
namespace WeeklyExploration
{
    public partial class GQuest : Event
    {
        ActorMob 第十一关封印;

        void 本館2F刷怪(uint mapid)
        {
            SagaMap.Map map; map = SagaMap.Manager.MapManager.Instance.GetMap(mapid);
            第十一关封印 = map.SpawnCustomMob(10000000, map.ID, 10000000, 0, 0, 14, 33, 0, 1, 0, 封印Info(), 封印AI(), (MobCallback)第十一关封印Ondie, 1)[0];
            map.SpawnCustomMob(10000000, map.ID, 10680300, 0, 0, 10, 8, 10, 3, 0, 绿色僵尸Info(), 绿色僵尸AI(), (MobCallback)第十一关小怪死亡Ondie, 1);
            map.SpawnCustomMob(10000000, map.ID, 10190100, 0, 0, 10, 8, 10, 3, 0, 死亡守卫Info(), 死亡守卫AI(), (MobCallback)第十一关小怪死亡Ondie, 1);
            map.SpawnCustomMob(10000000, map.ID, 10190100, 0, 0, 7, 54, 30, 4, 0, 监狱守卫Info(), 监狱守卫AI(), (MobCallback)第十一关小怪死亡Ondie, 1);
        }
        void 第十一关小怪死亡Ondie(MobEventHandler e, ActorPC pc)
        {
            pc.Party.Leader.TInt["不死皇城第十一关变量"] += 1;
第十一关封印.HP = 200000;
            if (pc.Party.Leader.TInt["不死皇城第十一关变量"] >= 10)
            {
                if (pc.Party != null)
                {
                    foreach (var item in pc.Party.Members)
                    {
                        if (item.Value.Online)
                        {
                            if (item.Value.Buff.Dead)
                            {
                                SagaMap.Network.Client.MapClient.FromActorPC(item.Value).RevivePC(item.Value);
                            }
                        }
                    }
                }
                第十一关封印.HP = 1;
            }
        }
        void 第十一关封印Ondie(MobEventHandler e, ActorPC pc)
        {
            第十二关(pc);
        }
    }
}

