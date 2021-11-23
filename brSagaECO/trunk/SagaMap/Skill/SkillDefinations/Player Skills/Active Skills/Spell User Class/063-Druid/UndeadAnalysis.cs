﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SagaDB.Actor;
using SagaMap.Skill.Additions.Global;
using SagaDB.Mob;
namespace SagaMap.Skill.SkillDefinations.Druid
{
    /// <summary>
    /// 死靈分析（死霊分析）
    /// </summary>
    public class UndeadAnalysis : ISkill
    {
        #region ISkill Members
        public int TryCast(ActorPC sActor, Actor dActor, SkillArg args)
        {
            if (dActor.type == ActorType.MOB)
            {
                List<MobType> types = new List<MobType>();
                types.Add(SagaDB.Mob.MobType.UNDEAD);
                types.Add(SagaDB.Mob.MobType.UNDEAD_BOSS);
                types.Add(SagaDB.Mob.MobType.UNDEAD_BOSS_BOMB_SKILL);
                types.Add(SagaDB.Mob.MobType.UNDEAD_BOSS_CHAMP_BOMB_SKILL_NOTPTDROPRANGE);
                types.Add(SagaDB.Mob.MobType.UNDEAD_BOSS_SKILL);
                types.Add(SagaDB.Mob.MobType.UNDEAD_BOSS_SKILL_CHAMP);
                types.Add(SagaDB.Mob.MobType.UNDEAD_BOSS_SKILL_NOTPTDROPRANGE);
                types.Add(SagaDB.Mob.MobType.UNDEAD_NOTOUCH);
                types.Add(SagaDB.Mob.MobType.UNDEAD_SKILL);

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
