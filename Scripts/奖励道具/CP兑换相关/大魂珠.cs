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
    public class S910000059 : Event
    {
        public S910000059()
        {
            this.EventID = 910000059;
        }

        public override void OnEvent(ActorPC pc)
        {
            if (CountItem(pc, 910000059) > 0)
            {
                List<SagaDB.Item.Item> Equips = new List<SagaDB.Item.Item>();
                List<string> names = new List<string>();
                foreach (var i in pc.Inventory.Items[ContainerType.BODY])
                {
                    if ((i.BaseData.itemType == ItemType.ACCESORY_NECK) && i.Refine > 0 && i.Stack > 0)
                    {
                        Equips.Add(i);
                        names.Add(i.BaseData.name);
                    }
                }
                names.Add("放弃");
                if (Equips.Count < 1)
                {
                    Say(pc, 131, "你身上没有可以进行属性扭曲的装备呢。", "");
                    return;
                }
                int set = Select(pc, "※请选择需要进行【属性扭曲】的装备", "", names.ToArray());
                if (set == names.Count) return;

                SagaDB.Item.Item es = Equips[set - 1];
                if (Select(pc, "是否要扭曲 " + es.BaseData.name + " ？", "", "扭曲了我的项链！！！", "不要") == 1)
                {
                    if (CountItem(pc, 910000059) > 0)
                    {
                        TakeItem(pc, 910000059, 1);
                        if (SagaLib.Global.Random.Next(0, 100) < 70)
                        {
                            es.HP = (short)Global.Random.Next(-200, 200);
                            es.MP = (short)Global.Random.Next(-200, 200);
                            es.SP = (short)Global.Random.Next(-200, 200);
                        }
                        else
                        {
                            es.HP = (short)Global.Random.Next(-500, 500);
                            es.MP = (short)Global.Random.Next(-500, 500);
                            es.SP = (short)Global.Random.Next(-500, 500);
                        }
                        if (SagaLib.Global.Random.Next(0, 100) < 70)
                        {
                            es.WeightUp = (short)Global.Random.Next(-120, 100);
                            es.VolumeUp = (short)Global.Random.Next(-120, 150);
                        }
                        else
                        {
                            es.WeightUp = (short)Global.Random.Next(-300, 300);
                            es.VolumeUp = (short)Global.Random.Next(-300, 300);
                        }
                        SagaMap.Network.Client.MapClient.FromActorPC(pc).SendItemInfo(es.Slot);
                        PlaySound(pc, 3306, false, 100, 50);
                        Say(pc, 0, es.BaseData.name + "的时空扭曲了！");
                    }
                }
            }
        }
    }
}

