﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SagaDB.Actor;
using SagaMap.Skill.Additions.Global;
namespace SagaMap.Skill.SkillDefinations.Gladiator
{
    /// <summary>
    /// 神速斬り
    /// </summary>
    public class SpeedHit : ISkill
    {
        #region ISkill 成員

        public int TryCast(SagaDB.Actor.ActorPC sActor, SagaDB.Actor.Actor dActor, SkillArg args)
        {
            if (sActor.Status.Additions.ContainsKey("SpeedHit"))
                return -30;
            else
                return 0;
        }
        public void Proc(SagaDB.Actor.Actor sActor, SagaDB.Actor.Actor dActor, SkillArg args, byte level)
        {
            int[] lifetime = { 0, 1000, 1250, 1500, 1750, 2000 };
            DefaultBuff skill2 = new DefaultBuff(args.skill, sActor, "SpeedHit", lifetime[level]);
            SkillHandler.ApplyAddition(sActor, skill2);
            args.type = ATTACK_TYPE.SLASH;
            float factor = 5f + 3f * level;
            if (sActor is ActorPC)
            {
                int lv = 0;
                ActorPC pc = sActor as ActorPC;
                if (pc.Skills3.ContainsKey(1117))
                {
                    lv = pc.Skills3[1117].Level;
                    factor += 0.5f * lv;

                    //ジリオンブレイド
                    SkillHandler.Instance.SetNextComboSkill(sActor, 2534);
                    //一閃
                    SkillHandler.Instance.SetNextComboSkill(sActor, 2400);
                    //居合
                    SkillHandler.Instance.SetNextComboSkill(sActor, 2115);
                    //居合2
                    SkillHandler.Instance.SetNextComboSkill(sActor, 2201);
                    //居合3
                    SkillHandler.Instance.SetNextComboSkill(sActor, 2202);
                }
            }
            SkillHandler.Instance.PhysicalAttack(sActor, dActor, args, SagaLib.Elements.Neutral, factor);

            short[] pos = new short[2];
            Map map = Manager.MapManager.Instance.GetMap(sActor.MapID);
            pos[0] = dActor.X;
            pos[1] = dActor.Y;
            //map.MoveActor(Map.MOVE_TYPE.START, sActor, pos, 20000, 1000, true);

            if (SkillHandler.Instance.CanAdditionApply(sActor, dActor, SkillHandler.DefaultAdditions.Confuse, 10 * level))
            {
                Additions.Global.Stiff skill = new SagaMap.Skill.Additions.Global.Stiff(args.skill, dActor, (int)(0.75 + 0.25 * level));
                SkillHandler.ApplyAddition(dActor, skill);
            }

            map.MoveActor(Map.MOVE_TYPE.START, sActor, pos, sActor.Dir, 20000, true, SagaLib.MoveType.BATTLE_MOTION);


        }
        #endregion
    }
}
