﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SagaMap.Skill.Additions.Global;
using SagaDB.Actor;
using SagaLib;

namespace SagaMap.Skill.SkillDefinations
{
    public class S31070 : ISkill
    {
        #region ISkill Members

        public int TryCast(ActorPC pc, Actor dActor, SkillArg args)
        {
            return 0;
        }

        public void Proc(Actor sActor, Actor dActor, SkillArg args, byte level)
        {
            Activator timer = new Activator(sActor, dActor, args);
            timer.Activate();

        }

        #endregion

        #region Timer

        private class Activator : MultiRunTask
        {

            Actor dactor;
            Actor caster;
            Map map;
            SkillArg arg;
            int countMax = 15, count = 0;
           public Activator(Actor caster, Actor dactor, SkillArg args)
            {
                this.dactor = dactor;
                this.caster = caster;
                this.arg = args;
                map = Manager.MapManager.Instance.GetMap(caster.MapID);
                this.period = 800;
                this.dueTime = 0;

            }
            public override void CallBack()
            {
                //同步锁，表示之后的代码是线程安全的，也就是，不允许被第二个线程同时访问
                ClientManager.EnterCriticalArea();
                try
                {
                    if (count < countMax && dactor!=null)
                    {
                        List<Actor> targets = map.GetActorsArea(caster, 1500, true);
                        foreach (var item in targets)
                        {
                            if (SkillHandler.Instance.CheckValidAttackTarget(caster, item))
                            {
                                short[] pos = new short[2];
                                pos[0] = item.X;
                                pos[1] = item.Y;
                                SkillHandler.Instance.ShowEffect(map, caster, SagaLib.Global.PosX16to8(pos[0], map.Width), SagaLib.Global.PosY16to8(pos[1], map.Height), 5327);
                                Activator2 timer = new Activator2(caster, item, arg, pos);
                                timer.Activate();
                            }
                        }
                        count++;
                    }
                    else
                    {
                        this.Deactivate();
                    }
                }
                catch (Exception ex)
                {
                    Logger.ShowError(ex);
                }
                //解开同步锁
                ClientManager.LeaveCriticalArea();
            }
        }
        #endregion
        private class Activator2 : MultiRunTask
        {

            Actor dactor;
            Actor caster;
            SkillArg arg2;
            short[] pos;
            Map map;
            public Activator2(Actor caster, Actor dactor, SkillArg args,short[] pos)
            {
                this.dactor = dactor;
                this.caster = caster;
                this.arg2 = args.Clone();
                map = Manager.MapManager.Instance.GetMap(dactor.MapID);
                this.period = 0;
                this.dueTime = 2300;
                this.pos = pos;
            }
            public override void CallBack()
            {
                //同步锁，表示之后的代码是线程安全的，也就是，不允许被第二个线程同时访问
                ClientManager.EnterCriticalArea();
                try
                {
                    SkillArg s = this.arg2.Clone();
                    s.x = SagaLib.Global.PosX16to8(pos[0], map.Width);
                    s.y = SagaLib.Global.PosY16to8(pos[1], map.Height);
                    EffectArg arg = new EffectArg();
                    arg.effectID = 5376;
                    arg.actorID = 0xFFFFFFFF;
                    arg.x = s.x;
                    arg.y = s.y;
                    map.SendEventToAllActorsWhoCanSeeActor(Map.EVENT_TYPE.SHOW_EFFECT, arg, caster, true);
                    List<Actor> actors = map.GetRoundAreaActors(SagaLib.Global.PosX8to16(s.x, map.Width), SagaLib.Global.PosY8to16(s.y, map.Height), 300);
                    List<Actor> affected = new List<Actor>();
                    s.affectedActors.Clear();
                    foreach (Actor i in actors)
                    {
                        if (SkillHandler.Instance.CheckValidAttackTarget(caster, i))
                        {
                            int damage = (int)(i.MaxHP * 2f);
                            SkillHandler.Instance.CauseDamage(caster, i, damage);
                            SkillHandler.Instance.ShowVessel(i, damage);
                            SkillHandler.Instance.ShowEffect(SagaMap.Manager.MapManager.Instance.GetMap(i.MapID), i, 5376);
                        }
                    }
                    this.Deactivate();
                }
                catch (Exception ex)
                {
                    Logger.ShowError(ex);
                        this.Deactivate();
                }
                //解开同步锁
                ClientManager.LeaveCriticalArea();
            }
        }
    }
}
