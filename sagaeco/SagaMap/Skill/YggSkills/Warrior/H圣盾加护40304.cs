﻿using System;
using System.Collections.Generic;
using System.Text;

using SagaDB.Actor;
using SagaLib;
using SagaMap.Skill.Additions.Global;

namespace SagaMap.Skill.SkillDefinations
{
    public class S40304 : ISkill
    {
        #region ISkill Members

        public int TryCast(ActorPC pc, Actor dActor, SkillArg args)
        {
            if (pc.Inventory.Equipments.ContainsKey(SagaDB.Item.EnumEquipSlot.LEFT_HAND))
            {
                if (pc.Inventory.Equipments[SagaDB.Item.EnumEquipSlot.LEFT_HAND].BaseData.itemType != SagaDB.Item.ItemType.SHIELD)
                    return -5;
            }
            return 0;
        }

        public void Proc(Actor sActor, Actor dActor, SkillArg args, byte level)
        {
            int shp = 2000;
            SHIELD shield = new SHIELD(args.skill, dActor, 30000, shp);
            SkillHandler.ApplyAddition(dActor, shield);
        }
        #endregion
    }
}