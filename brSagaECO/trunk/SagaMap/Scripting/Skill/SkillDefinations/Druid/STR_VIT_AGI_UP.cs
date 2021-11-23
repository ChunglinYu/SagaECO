﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SagaDB.Actor;
using SagaMap.Skill.Additions.Global;
namespace SagaMap.Skill.SkillDefinations.Druid
{
    /// <summary>
    /// 強身健體（ラウズボディ）
    /// </summary>
    public class STR_VIT_AGI_UP : ISkill 
    {
        #region ISkill Members
        public int TryCast(ActorPC pc, Actor dActor, SkillArg args)
        {
            return 0;
        }
        public void Proc(Actor sActor, Actor dActor, SkillArg args, byte level)
        {
            int[] lifetime ={15, 20, 25, 27, 30};
            DefaultBuff skill = new DefaultBuff(args.skill, dActor, "STR_VIT_AGI_UP", lifetime[level - 1] * 1000);
            skill.OnAdditionStart += this.StartEventHandler;
            skill.OnAdditionEnd += this.EndEventHandler;
            SkillHandler.ApplyAddition(dActor, skill);
        }
        void StartEventHandler(Actor actor, DefaultBuff skill)
        {
            int level = skill.skill.Level;
            short[] STR={3, 4, 5, 6, 8 }; 
            short[] VIT={4, 5, 7, 9, 10 };
            short[] AGI={7, 9, 11, 13, 15 }; 

            //STR
            if (skill.Variable.ContainsKey("STR_VIT_AGI_UP_STR"))
                skill.Variable.Remove("STR_VIT_AGI_UP_STR");
            skill.Variable.Add("STR_VIT_AGI_UP_STR", STR[level - 1]);
            actor.Status.str_skill  += STR[level - 1];
            //VIT
            if (skill.Variable.ContainsKey("STR_VIT_AGI_UP_VIT"))
                skill.Variable.Remove("STR_VIT_AGI_UP_VIT");
            skill.Variable.Add("STR_VIT_AGI_UP_VIT", VIT[level - 1]);
            actor.Status.vit_skill  += VIT[level - 1];
            //AGI
            if (skill.Variable.ContainsKey("STR_VIT_AGI_UP_AGI"))
                skill.Variable.Remove("STR_VIT_AGI_UP_AGI");
            skill.Variable.Add("STR_VIT_AGI_UP_AGI", AGI[level - 1]);
            actor.Status.agi_skill  += AGI[level - 1];
            actor.Buff.STR上昇 = true;
            actor.Buff.AGI上昇 = true;
            actor.Buff.VIT上昇 = true;
            Manager.MapManager.Instance.GetMap(actor.MapID).SendEventToAllActorsWhoCanSeeActor(Map.EVENT_TYPE.BUFF_CHANGE, null, actor, true);
        }
        void EndEventHandler(Actor actor, DefaultBuff skill)
        {

            actor.Status.str_skill -= (short)skill.Variable["STR_VIT_AGI_UP_STR"];
            actor.Status.vit_skill -= (short)skill.Variable["STR_VIT_AGI_UP_VIT"];
            actor.Status.agi_skill -= (short)skill.Variable["STR_VIT_AGI_UP_AGI"];
            actor.Buff.STR上昇 = false;
            actor.Buff.AGI上昇 = false;
            actor.Buff.VIT上昇 = false;
            Manager.MapManager.Instance.GetMap(actor.MapID).SendEventToAllActorsWhoCanSeeActor(Map.EVENT_TYPE.BUFF_CHANGE, null, actor, true);
        }
        #endregion
    }
}

