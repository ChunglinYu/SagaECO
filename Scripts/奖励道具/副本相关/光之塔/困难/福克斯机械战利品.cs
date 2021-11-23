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
    public class S910000055 : Event
    {
        public S910000055()
        {
            this.EventID = 910000055;
        }

        public override void OnEvent(ActorPC pc)
        {
            if (CountItem(pc, 910000055) >= 1)
            {
                TakeItem(pc, 910000055, 1);
                //奖励(pc);
            }
        }
        void 奖励(ActorPC pc)
        {
            GiveItem(pc, 910000007, 1);
            GiveItem(pc, 910000008, 1);
            GiveItem(pc, 950000025, 1);
            int g = Global.Random.Next(20000, 50000);
            pc.Gold += g;
            if (Global.Random.Next(0, 100) < 101)
            {
                uint id = 953000000;
                PlaySound(pc, 2040, false, 100, 50);
                GiveItem(pc, id, 1);//东牢装备箱
                if (pc.Party != null)
                {
                    SagaDB.Item.Item item = ItemFactory.Instance.GetItem(id);
                    foreach (var m in pc.Party.Members)
                        if (m.Value.Online)
                            SagaMap.Network.Client.MapClient.FromActorPC(m.Value).SendSystemMessage(pc.Name + " 从【福克斯机械战利品】中获得了 " + item.BaseData.name);
                }
            }

            if (Global.Random.Next(0, 100) < 101)
            {
                uint id = 953000000;
                PlaySound(pc, 2040, false, 100, 50);
                GiveItem(pc, id, 1);//东牢装备箱
                if (pc.Party != null)
                {
                    SagaDB.Item.Item item = ItemFactory.Instance.GetItem(id);
                    foreach (var m in pc.Party.Members)
                        if (m.Value.Online)
                            SagaMap.Network.Client.MapClient.FromActorPC(m.Value).SendSystemMessage(pc.Name + " 从【福克斯机械战利品】中获得了 " + item.BaseData.name);
                }
            }
            if (Global.Random.Next(0, 100) < 101)
            {
                uint id = 953000021;
                PlaySound(pc, 2040, false, 100, 50);
                GiveItem(pc, id, 1);//海底装备箱
                if (pc.Party != null)
                {
                    SagaDB.Item.Item item = ItemFactory.Instance.GetItem(id);
                    foreach (var m in pc.Party.Members)
                        if (m.Value.Online)
                            SagaMap.Network.Client.MapClient.FromActorPC(m.Value).SendSystemMessage(pc.Name + " 从【福克斯机械战利品】中获得了 " + item.BaseData.name);
                }
            }
            if (Global.Random.Next(0, 100) < 30)
            {
                uint id = 953000021;
                PlaySound(pc, 2040, false, 100, 50);
                GiveItem(pc, id, 1);//海底装备箱
                if (pc.Party != null)
                {
                    SagaDB.Item.Item item = ItemFactory.Instance.GetItem(id);
                    foreach (var m in pc.Party.Members)
                        if (m.Value.Online)
                            SagaMap.Network.Client.MapClient.FromActorPC(m.Value).SendSystemMessage(pc.Name + " 从【福克斯机械战利品】中获得了 " + item.BaseData.name);
                }
            }
            if (Global.Random.Next(0, 100) < 60)
            {
                uint id = 960000000;
                PlaySound(pc, 2040, false, 100, 50);
                GiveItem(pc, id, 1);//项链石
                if (pc.Party != null)
                {
                    SagaDB.Item.Item item = ItemFactory.Instance.GetItem(id);
                    foreach (var m in pc.Party.Members)
                        if (m.Value.Online)
                            SagaMap.Network.Client.MapClient.FromActorPC(m.Value).SendSystemMessage(pc.Name + " 从【福克斯机械战利品】中获得了 " + item.BaseData.name);
                }
            }
            if (Global.Random.Next(0, 100) < 60)
            {
                uint id = 960000001;
                PlaySound(pc, 2040, false, 100, 50);
                GiveItem(pc, id, 1);//武器石
                if (pc.Party != null)
                {
                    SagaDB.Item.Item item = ItemFactory.Instance.GetItem(id);
                    foreach (var m in pc.Party.Members)
                        if (m.Value.Online)
                            SagaMap.Network.Client.MapClient.FromActorPC(m.Value).SendSystemMessage(pc.Name + " 从【福克斯机械战利品】中获得了 " + item.BaseData.name);
                }
            }
            if (Global.Random.Next(0, 100) < 60)
            {
                uint id = 960000002;
                PlaySound(pc, 2040, false, 100, 50);
                GiveItem(pc, id, 1);//衣服石
                if (pc.Party != null)
                {
                    SagaDB.Item.Item item = ItemFactory.Instance.GetItem(id);
                    foreach (var m in pc.Party.Members)
                        if (m.Value.Online)
                            SagaMap.Network.Client.MapClient.FromActorPC(m.Value).SendSystemMessage(pc.Name + " 从【福克斯机械战利品】中获得了 " + item.BaseData.name);
                }
            }

        }
    }
}

