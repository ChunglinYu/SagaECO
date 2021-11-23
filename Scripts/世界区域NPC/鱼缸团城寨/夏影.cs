﻿
using System;
using System.Collections.Generic;
using System.Text;
using SagaLib;
using SagaDB.Actor;
using SagaDB.Item;
using SagaMap.Scripting;
using SagaDB;
using SagaScript.Chinese.Enums;
using WeeklyExploration;
using System.Globalization;
namespace SagaScript.M30210000
{
    public class S60000005 : Event
    {
        public S60000005()
        {
            this.EventID = 60000005;
        }
        void 初次对话(ActorPC pc)
        {
            Say(pc, 0, "嗯……？", "夏影");
            Say(pc, 0, "（对方在上下打量着你）", "");
            Wait(pc, 500);
            Say(pc, 0, "是错觉吗，总觉得在哪里见过你。", "夏影");
            Wait(pc, 500);
            Say(pc, 0, "是那座飞空艇上的冒险者啊…难怪了", "夏影");
            Say(pc, 0, "我是$CR夏影$CD，是这座鱼缸岛上的居民，$R兴趣是研究魔法。", "夏影");
            Say(pc, 0, "不不不，$R不是你想象的那种呼风唤雨撒豆成兵，或是召唤出一个球球帮你打人的魔法…$R$R那不是我擅长的领域", "夏影");
            Say(pc, 0, "除了用于破坏外，$R魔法还是有很多其他的使用方法的，$R$R用好魔法的话，$R可以让我们的日常生活轻松好多", "夏影");
            Wait(pc, 1000);
            Say(pc, 0, "我为什么站在这里？$R$R啊，其实我在等人，$R但是对方一直没有来，$R也不知道是不是发生了什么事", "夏影");

            pc.CInt["魔导师的委托任务线"] = 1;
            Say(pc, 0, "…嘛闲着也是闲着，要不要来和我聊会天？", "夏影");
            移动施法任务线(pc);
        }
        void 移动施法任务线(ActorPC pc)
        {
            switch (pc.CInt["移动施法任务线"])
            {
                case 0: //尚未开始移动施法任务线
                    switch (Select(pc, "要聊些什么呢？", "", "我想了解移动施法的技巧！", "不聊，我只是来调戏调戏你的。"))
                    {
                        case 1:
                            Say(pc, 0, "魔法是一门很复杂的艺术，$R需要施法者在施法过程中保持精神集中$R才能最大程度地发挥其效果。", "夏影");
                            Say(pc, 0, "当然，$R熟练的施法者即使在施放法术的过程中$R也能够进行移动，甚至更复杂的行动，$R这是对于战斗来说至关重要的能力。", "夏影");
                            Wait(pc, 500);
                            Say(pc, 0, "你对这种技巧有兴趣吗？", "夏影");
                            switch (Select(pc, "移动施法的技巧", "", "我有兴趣！", "没有，快滚"))
                            {
                                case 1:
                                    Say(pc, 0, "嗯嗯，$R只要是研究魔法的人，$R就一定会对这种技巧感兴趣呢", "夏影");
                                    Say(pc, 0, "不过在此之前，$R先让我确认一下$R你有没有足够的资质来学习吧。", "夏影");
                                    Say(pc, 0, "我说过，$R魔法是一门复杂的艺术，$R半吊子的法师可是不行的哦。", "夏影");
                                    Say(pc, 0, "不要紧张，深呼吸放松一下再跟我对话吧。", "夏影");
                                    pc.CInt["移动施法任务线"] = 1;
                                    break;
                                case 2:
                                    Say(pc, 0, "呜…$R$R（不知道为什么$R　旁边的伊邪那美在用恐怖的眼神望着你　$R并把手放到刀柄上。", "夏影");
                                    return;
                            }
                            break;
                        case 2:
                            Say(pc, 0, "…我说，你把我当成什么人了？$R$R（不知道为什么$R　旁边的伊邪那美在用恐怖的眼神的望着你$R　你觉得不寒而栗。）", "夏影");
                            return;
                    }
                    break;
                case 1:   //接受了移动施法的考验
                    Say(pc, 0, "……", "夏影");
                    if ((pc.Job == PC_JOB.CARDINAL || pc.Job == PC_JOB.ASTRALIST)
                        && pc.JobLevel3 > 15)//当职业为祭司或法师且职业等级大于15
                    {
                        Say(pc, 0, "嗯，看来你有足够的资质来学习这种技巧了", "夏影");
                        Say(pc, 0, "怎么样，$R爆肝了这么久，你有没有什么感想？", "夏影");
                        Say(pc, 0, "看来你已经意识到了呢，$R$R没错，最重要的技巧其实就是熟练。", "夏影");
                        Say(pc, 0, "通过重复的练习，$R让你的身体记住你的施法流程，$R达到融汇贯通的程度后，$R接下来的就都很简单了。", "夏影");
                        Say(pc, 0, "虽然移动施法很方便，$R但是对于还不熟悉这门技艺的你来说，$R这种技巧不可避免地会让你的法术效果打折扣。", "夏影");
                        Say(pc, 0, "所以要如何运用这种能力$R就要看你自己的判断了。", "夏影");
                        pc.CInt["移动施法任务线"] = 2;
                        pc.CInt["学习了1级移动施法"] = 1;
                        SagaDB.Skill.Skill skill = SagaDB.Skill.SkillFactory.Instance.GetSkill(14000, 1);
                        if (!pc.Skills3.ContainsKey(14000))
                            pc.Skills3.Add(14000, skill);
                        SagaMap.Network.Client.MapClient.FromActorPC(pc).SendSystemMessage("学习到了『1级移动施法』。");
                        PlaySound(pc, 3087, false, 100, 50);
                        ShowEffect(pc, 4131);
                    }
                    else
                    {
                        Say(pc, 0, "你的资质还是不够呀，$R更多地磨炼自己的技巧再回来找我吧$R$R(需要职业等级达到15)", "夏影");
                        return;
                    }
                    return;
                case 2:    //已经习得移动施法
                    Say(pc, 0, "你的魔法运用得还熟练吗？$R$R等时机成熟了，$R我会教你更进阶的技巧。", "夏影");
                    break;
            }
        }
        private void 魔导师转职任务(ActorPC pc)
        {
            Say(pc, 0, "啊，又是你", "夏影");
            switch (Select(pc, " ", "", "你还在等人吗？", "不是，你认错人了。"))
            {
                case 1:
                    Say(pc, 0, "嗯…$R虽然一开始觉得会不会是被放了鸽子，$R但是这么久了都没有等到，$R还是有些担心啊…", "夏影");
                    Say(pc, 0, "嘛，闲着也是闲着，$R要不要来聊聊天？", "夏影");
                    if (Select(pc, " ", "", "好啊好啊。", "一边凉快去") == 1)
                    {
                        Say(pc, 0, "……虽然说是要聊天，$R但是意外的找不到可以聊的话题啊……", "夏影");
                        Wait(pc, 300);
                        Say(pc, 0, "对了，$R作为一名外来的冒险者，$R你对魔法的了解有多少呢。", "夏影");
                        Select(pc, " ", "", "是指的祭司那样的魔法吗？");
                        Say(pc, 0, "不…$R我指的不是那种借助神$R或恶魔的力量来施法的方法。$R$R我说的是更本质的，$R利用施法者自己的力量$R完成魔法的艺术。", "夏影");
                        Select(pc, " ", "", "完全没听过！");
                        Say(pc, 0, "魔法的本质就是以自己的意志$R操控周围的事物的力量。$R$R你所看到的那些看似奇迹的结果，$R其实都是这样引发出来的。", "夏影");
                        Say(pc, 0, "魔法所能达到的极限$R依托于你的知识，$R你对其他事物，$R乃至于对这个世界的了解。$R$R你懂得越多，$R对魔法的驾驭能力就会越强大。$R$R某种意义上来讲，$R它可以说是“万能”的力量", "夏影");
                        Say(pc, 0, "明白了吗，$R你能用魔法做到什么，$R$R这完全取决于你自己，$R而不是将力量授予你的人。", "夏影");
                        Say(pc, 0, "正因如此，$R魔法所能达到的顶点$R不会受制于其他任何人，$R$R只取决于你自己的极限。", "夏影");
                        Wait(pc, 300);
                        Say(pc, 0, "嗯…$R要成为一名魔法师，$R需要的知识是非常多的。$R$R这可不是讲2个小时就能结束的事情啊…", "夏影");
                        Say(pc, 0, "我想我们大概需要一本$R笔记来记下这些东西…$R$R它们在你以后的$R探索之路上会是必不可少的", "夏影");
                        Say(pc, 0, "不…$R我觉得你大概是$R太过低估了我们要讲的东西了，$R$R我怀疑你坐在这里抄写的话$R可能一个月都不一定能抄得完。$R$R我们得想一些别的办法。", "夏影");
                        Wait(pc, 300);
                        Say(pc, 0, "这种时候，$R如果有一本禁断之书就好了…$R$R对哦，我想我们需要的就是这个。", "夏影");
                        Say(pc, 0, "冒险者，$R我想拜托你一件事。$R$R在法伊斯特广场最大的房子里，$R有一本黑色封面的书，$R我希望你能帮我将它取来。", "夏影");
                        Say(pc, 0, "那是一本叫做禁断之书的魔法道具。$R$R之前我们离开法伊斯特时，$R因为走得匆忙所以落在那边忘记带回来，$R$R有了它的话，我们接下来就能轻松很多了。", "夏影");
                        Say(pc, 0, "关于它的作用吗…$R$R我想大概还是等你$R把它拿来以后再讲解比较容易理解一些。", "夏影");
                        Say(pc, 0, "现在法伊斯特已经被全面封锁了，$R$R我会将你传送过去，但只有一次。", "夏影");
                        Say(pc, 0, "现在的法伊斯特非常危险，$R$R请你做好准备后再跟我对话吧。", "夏影");
                        Say(pc, 0, "小心些，$R现在的法伊斯特是一个非常危险的地方。$R$R请一定要做好万全的准备再动身。", "夏影");
                        pc.CInt["魔导师转职任务"] = 1;
                        return;
                    }
                    else
                        Say(pc, 0, "……哼", "夏影");
                    return;
                case 2:
                    Say(pc, 0, "……是吗？", "夏影");
                    return;
            }
        }
        private void 魔导师转职任务1(ActorPC pc)
        {
            Say(pc, 0, "你已经做好出发的准备了吗？", "夏影");
            Say(pc, 0, "传送魔法很耗精神，所以只有一次。", "夏影");
            Say(pc, 0, "如果失败了的话，$R只能你自己想办法进入法伊斯特了。", "夏影");
            if (Select(pc, "你的回答是……？", "", "我这就去", "我再考虑考虑。") == 1)
            {
                Say(pc, 0, "禁断之书是在$R$CR法伊斯特中央广场的大房子$CD里面。", "夏影");
                ShowEffect(pc, 5198);
                ShowEffect(pc, 5451);
                Wait(pc, 4000);
                ShowEffect(pc, 5135);
                Wait(pc, 2000);
                Warp(pc, 10057002, 5, 139);
                pc.CInt["魔导师转职任务"] = 2;
                return;
            }
            else
                Say(pc, 0, "毕竟那边已是死亡之地，认真考虑清楚是对的。", "夏影");
            return;
        }
        private void 魔导师转职任务3(ActorPC pc)
        {
            if (pc.CInt["魔导师转职任务"] == 3)
            {
                Say(pc, 0, "看样子你拿到禁断之书了，$R干得好，那么我们开始吧", "夏影");
                Say(pc, 0, "禁断之书是一种很方便的魔法道具…$R$R你可以将大量的东西通过魔法记录在上面，$R并且可以很自由地进行修改。$R$R有了它的话，$R我们后面就能轻松不少了。", "夏影");
                Say(pc, 0, "这都被你发现了，$R没错，其实这就是本电子书而已……$R$R干嘛用那种眼神看着我，$R$R发展到极致的科学$R本来就和魔法没有两样不是吗。", "夏影");
                Say(pc, 0, "咳……$R$R那么，开始正题吧…$R$R在这之前，我希望你能对魔法这种力量的本质有所了解。", "夏影");
                Say(pc, 0, "魔法并不能无中生有，$R$R它的本质只是通过魔力$R去影响、引导、改变其他事物的状态而已，$R$R而要做到这点，$R就要求你必须$R对你要改变的事物有足够的了解才行。", "夏影");
                Say(pc, 0, "想必你也注意到法伊斯特现在的样子了吧。$R$R很久以前，$R法伊斯特曾经是个有很多人的繁华城镇。$R$R但是由于某种魔法的失控，$R它在一夜之间变为了一座死城。", "夏影");
                Say(pc, 0, "我们至今不知道究竟是谁$R导致了那次可怕的事件…$R$R我甚至不知道在这片区域$R还有力量强大到能够引发$R如此可怕的事故的魔导师存在，$R$R我只是想让你知道，$R魔法一旦失控，$R其后果将是可怕并且不可挽回的。", "夏影");
                Say(pc, 0, "关于法伊斯特的故事，$R我们以后有机会再谈吧。$R$R言归正传，如我前面所说，$R魔法的本质就是你通过引导魔力改变周围的事物的艺术。$R$R比如说，你看到那边的那个鱼缸没有。", "夏影");
                Select(pc, " ", "", "看到了，然后呢？");
                Say(pc, 0, "想象它的结构，", "夏影");
                Say(pc, 0, "当你试图用魔力去活化它时，$R它就会变得不稳定，$R甚至爆炸，$R$R将其内部蕴藏的能量一口气释放出来，造成巨大的破坏。这门艺术被称为火焰魔法。", "夏影");
                Say(pc, 0, "而与此相对，$R当你试图用魔力去稳定它时，$R你实际上是在制御它的每一个分子，$R让它们按照你的意愿彼此结合，$R这是一门非常精细的艺术。$R$R这就是寒冰魔法的本质。", "夏影");
                Say(pc, 0, "其实我并不是很擅长这类魔法，$R但是我知道在鱼缸岛上有人非常精于此道，$R$R带着这本书去找她吧，$R她应该可以给你更多非常有用的指引。", "夏影");
                pc.CInt["魔导师转职任务"] = 4;
                return;
            }
            else
                Say(pc, 0, "你怎么还在这？你说你不知道应该找谁？$R$R啊啊，就是那个$CC浑身都是蓝色的元素使$CD。", "夏影");
            return;
        }
        private void 魔导师转职任务8(ActorPC pc)
        {
            Say(pc, 0, "你回来啦，怎么样，感觉如何。", "夏影");
            Say(pc, 0, "看你的表情似乎很辛苦的样子…$R不过你应该还是有所收获的吧。", "夏影");
            Say(pc, 0, "想必你现在也稍微有些了解魔法的原理了，$R那接下来我要讲的东西就容易多了。", "夏影");
            Say(pc, 0, "就像我之前所说的，$R$R魔法的极限只取决于你对周围事物的理解，$R你对它理解的越是深入，$R你就越能得心应手地操控它。", "夏影");
            Say(pc, 0, "这不仅仅是指有实际形体的物体……$R$R时间，空间，甚至你自己，$R都是可以被改变的——$R只要你有足够强大的力量。", "夏影");
            Say(pc, 0, "要驾驭这种魔法很难，$R$R并且稍不注意就会造成非常危险$R并且无法挽回的后果。$R$R在你使用的时候，请千万注意。", "夏影");
            Say(pc, 0, "你要时刻记住，$R与魔法为伴就如同玩火。$R$R你需要非常的小心才能够驾驭这种力量。", "夏影");
            Say(pc, 0, "那么，$R$R等你做好成为魔法师的心理准备后，$R再跟我说话吧。", "夏影");
            pc.CInt["魔导师转职任务"] = 9;
            return;
        }
        private void 魔导师转职任务9(ActorPC pc)
        {
            if (Select(pc, "确定转职为魔导师吗？", "", "是的", "暂时不转职") == 1)
            {
                Say(pc, 0, "看来你已经做好觉悟了。", "夏影");
                Say(pc, 0, "那么作为礼物，这个就送给你吧。", "夏影");
                Say(pc, 0, "对魔导师来说，$R这是最重要的一个词，节制，$R$R意味着你要控制自己的节奏，$R运用你的知识与理解，$R从容地面对所有的情况，$R$R对于与魔法为伴的人来说，$R这是最为重要的事。", "夏影");
                Say(pc, 0, "那么，祝你好运，新生的魔法师——$R$R让我看看你的天分吧。", "夏影");
                pc.CInt["魔导师转职任务"] = 10;
                pc.CInt["魔导师转职完成"] = 1;
                GiveItem(pc, 140000002, 1);//塔罗牌·节制
                ChangePlayerJob(pc, PC_JOB.ASTRALIST);
                PlaySound(pc, 3087, false, 100, 50);
                ShowEffect(pc, 4131);
                Wait(pc, 1000);
                pc.EP = 0;
                Say(pc, 131, "你已经成为『魔导师』了。", " ");
                PlaySound(pc, 4012, false, 100, 50);
                return;
            }
        }
        public override void OnEvent(ActorPC pc)
        {

            if (pc.Account.GMLevel > 200 && pc.CInt["魔导师转职完成"] == 1)
            {
                if (Select(pc, "想不想重新体验一次转职流程吖？", "", "吼啊吼啊", "滚尼玛的") == 1)
                {
                    pc.CInt["魔导师转职任务"] = 0;
                    pc.CInt["魔导师转职完成"] = 0;
                    NPCShow(pc, 80000611);//沙鼠现形
                    NPCHide(pc, 80000612);//沙鼠·阿鲁玛隐身
                    ShowEffect(pc, 4021);
                    Wait(pc, 3000);
                    Say(pc, 0, "咿嘻嘻~$R哥哥已经帮你洗干净任务记录了。", "番茄");
                }
            }
            
            if (pc.CInt["学习了1级移动施法"] == 1&& !pc.Skills3.ContainsKey(14000) && !pc.Skills.ContainsKey(14000))
            {
                SagaDB.Skill.Skill skill = SagaDB.Skill.SkillFactory.Instance.GetSkill(14000, 1);
                pc.Skills.Add(14000, skill);
                SagaMap.Network.Client.MapClient.FromActorPC(pc).SendSystemMessage("学习到了『1级移动施法』。");
                PlaySound(pc, 3087, false, 100, 50);
                ShowEffect(pc, 4131);
            }
            //Say(pc, 0, pc.CInt["魔导师转职任务"].ToString());
            //if (pc.Account.GMLevel > 200)
            {
                if (pc.Level >= 20 && pc.CInt["魔导师转职完成"] == 0 && pc.CInt["学习了1级移动施法"] == 1)//角色基础等级大于20级且完成过移动施法
                {
                    switch (pc.CInt["魔导师转职任务"])
                    {
                        case 0:
                            魔导师转职任务(pc);
                            return;
                        case 1:
                            魔导师转职任务1(pc);
                            return;
                        case 3:
                            魔导师转职任务3(pc);
                            return;
                        case 4:
                            Say(pc, 0, "你怎么还在这？你说你不知道应该找谁？$R$R啊啊，就是那个$CC浑身都是蓝色的元素使$CD。", "夏影");
                            return;
                        case 8:
                            魔导师转职任务8(pc);
                            return;
                        case 9:
                            魔导师转职任务9(pc);
                            return;
                    }
                }
            }


            if (pc.CInt["灾祸的见证者任务"] == 4)
            {
                Say(pc, 0, "嗯？$R不是说要去找你说的『$CR那位少女$CD』吗？$R怎么还楞在这？", "夏影");
                return;
            }
                if (pc.CInt["灾祸的见证者任务"] == 3)
            {
                Say(pc, 0, "番茄那个家伙，$R怎么这么没用的啦，$R找个裁缝都找不到……$R什么啊，是你啊。", "夏影");
                switch (Select(pc, " ", "", "没错，就是我。", "你认识东之国的那名幽灵少女吗？"))
                {
                    case 1:
                        Say(pc, 565, "我觉得你最好先去搞个熊猫头$R来再讲这句台词比较好…", "夏影");
                        return;
                    case 2:
                        Say(pc, 0, "…幽灵这种故事，只是骗小孩的而已。", "夏影");
                        Say(pc, 131, "灵魂确实是存在的，$R但是那都是生者留在这个世界上的意识…$R她们虽然存在，$R但是对生者来说却是不可见的。", "夏影");
                        Select(pc, " ", "", "可是我确实看到过灵魂…");
                        Wait(pc, 600);
                        Say(pc, 1500, "你说的没错。$R这个世界上确实存在灵魂，$R但是那和你说的幽灵恐怕不是同一种东西。", "夏影");
                        Say(pc, 1500, "记住一点，$R灵魂的存在依赖于与生者的羁绊。$R只有和这些灵魂建立了深刻的连结的人$R才有可能感知到他们的存在。$R对所有人都可见的灵魂是不存在的。", "夏影");
                        Say(pc, 1500, "这个世界上确实是存在$R和幽灵看起来很类似的存在，$R但是那都不是真正的幽灵。", "夏影");
                        Say(pc, 1508, "而且，通过稍微复杂一些的幻术魔法，$R就算是活人也可以让自己隐形，$R或者看起来透明。$R$R小的时候，$R我就曾经用这些把戏$R在万圣节挨家挨户讨要糖果。", "夏影");
                        Wait(pc, 1000);
                        Say(pc, 132, "但是不管她是不是真的幽灵，$R如果你所说属实，她确实是失忆了的话…$R那也不能放着她在那里不管。$R$R我觉得有必要亲自去看一看是怎么回事。$R现在的东之国太危险了，$R把她接来鱼缸岛可能会比较好。", "夏影");
                        pc.CInt["灾祸的见证者任务"] = 4;
                        NPCShow(pc, 80000703);
                        return;
                }
                return;
            }
            if (pc.CInt["灾祸的见证者任务"] == 5)
            {
                NPCHide(pc, 80000703);
                Say(pc, 0, "那名活幽灵少女的身份真是让人感兴趣…$R我会看看能不能找到相关线索的，$R如果你找到了有用的情报一定要告诉我。", "夏影");
                Say(pc, 0, "能见识到有意识的活幽灵$R这样强大的幻术魔法，$R$R禁断之书上$R大概会记下大量有趣的知识吧。", "夏影");
                ShowEffect(pc, 5152);
                Wait(pc, 800);
                ShowEffect(pc, 5167);
                Wait(pc, 1500);
                Say(pc, 0, "（包里的『$CR禁断之书$CD』似乎有什么反应？）", pc.Name);
                pc.CInt["灾祸的见证者任务"] =6;
                return;
            }
            if (pc.CInt["魔导师转职完成"] == 1)
            {
                Say(pc, 0, "你好啊，$R有没有觉得对魔法的理解更加透彻了呢？", "夏影");
                if (CountItem(pc, 140000000) < 1)
                {
                    Wait(pc, 500);
                    Say(pc, 0, "话说，我有个问题…$R$R你该不会把禁断之书弄丢了吧？", "夏影");
                    switch (Select(pc, " ", "", "啊…啊哈哈…", "没有，快滚。"))
                    {
                        case 1:
                            Say(pc, 0, "果然吗，我就在想怎么都感觉不到它的魔力了。", "夏影");
                            Say(pc, 0, "嘛算了…$R记住，禁断之书是很重要的东西，不要随便乱丢比较好。", "夏影");
                            Say(pc, 0, "以后你迟早还会用到它的$R怎样，要不要再买一本呢？我可以便宜点只收你100wG哦。", "夏影");
                            switch (Select(pc, " ", "", "我买！", "我靠你抢钱呢？"))
                            {
                                case 1:
                                    if(pc.Gold>=1000000)
                                    {
                                        pc.Gold -= 1000000;
                                        GiveItem(pc, 140000000, 1);//禁断之书
                                        Say(pc, 0, "拿好，可不要再弄丢了。", "夏影");
                                        Say(pc, 0, "要不了多久，你就会意识到它的重要性了。", "夏影");
                                    }
                                    else
                                    {
                                        Say(pc, 0, "切，连100w都拿不出来，你就不觉得丢人吗。", "夏影");
                                    }
                                    return;
                                case 2:
                                    Say(pc, 0, "哼$R算了，早晚有一天你会后悔的。", "夏影");
                                    return;
                            }
                            return;
                        case 2:
                            Say(pc, 0, "真的吗，我怎么感觉你在皮炎我。", "夏影");
                            Say(pc, 0, "嘛算了…$R记住，禁断之书是很重要的东西，不要随便乱丢比较好。", "夏影");
                            Select(pc, " ", "", "那为什么它会被那么丢在东之国的地板上呢？");
                            Say(pc, 0, "……", "夏影");
                            Say(pc, 0, "啰嗦！", "夏影");
                            return;
                    }
                }
                return;
            }



            if (pc.Job == PC_JOB.CARDINAL || pc.Job == PC_JOB.ASTRALIST)//当职业为祭司或法师
            {
                switch (pc.CInt["魔导师的委托任务线"])
                {
                    case 0:
                        初次对话(pc);
                        break;
                    case 1:
                        移动施法任务线(pc);
                        break;
                    default:
                        Say(pc, 0, "怎么还没来，$R该不会出了什么意外吧…", "夏影");
                        break;
                }
            }
            else
                Say(pc, 0, "怎么还没来，$R莫不是我被放了鸽子？！！", "夏影");
        }
    }
}