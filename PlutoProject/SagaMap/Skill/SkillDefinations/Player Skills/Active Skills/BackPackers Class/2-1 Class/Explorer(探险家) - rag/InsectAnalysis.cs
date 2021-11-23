﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SagaDB.Actor;
using SagaDB.Mob;
using SagaMap.Skill.Additions.Global;
namespace SagaMap.Skill.SkillDefinations.Explorer
{
    /// <summary>
    /// 昆蟲分析
    /// </summary>
    public class InsectAnalysis : ISkill
    {
        #region ISkill Members
        public int TryCast(ActorPC sActor, Actor dActor, SkillArg args)
        {
            if (dActor.type == ActorType.MOB)
            {
                List<MobType> types = new List<MobType>();
                types.Add(SagaDB.Mob.MobType.INSECT);
                types.Add(SagaDB.Mob.MobType.INSECT_BOSS);
                types.Add(SagaDB.Mob.MobType.INSECT_BOSS_NOTPTDROPRANGE);
                types.Add(SagaDB.Mob.MobType.INSECT_BOSS_SKILL);
                types.Add(SagaDB.Mob.MobType.INSECT_NOTOUCH);
                types.Add(SagaDB.Mob.MobType.INSECT_NOTPTDROPRANGE);
                types.Add(SagaDB.Mob.MobType.INSECT_RIDE);
                types.Add(SagaDB.Mob.MobType.INSECT_SKILL);
                types.Add(SagaDB.Mob.MobType.INSECT_UNITE);

                ActorMob mob = (ActorMob)dActor;
                if (types.Contains(mob.BaseData.mobType))
                {
                    return 0;
                }
            }
            return -4;
        }
        public void Proc(Actor sActor, Actor dActor, SkillArg args, byte level)
        {
            Analysis skill = new Analysis(args.skill, dActor);
            SkillHandler.ApplyAddition(dActor, skill);
        }
        #endregion
    }
}
