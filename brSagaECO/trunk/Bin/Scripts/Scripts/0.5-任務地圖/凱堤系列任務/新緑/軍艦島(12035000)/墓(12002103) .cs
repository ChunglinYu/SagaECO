﻿using System;
using System.Collections.Generic;
using System.Text;

using SagaDB.Actor;
using SagaDB.Item;
using SagaMap.Scripting;

using SagaLib;
using SagaScript.Chinese.Enums;
namespace SagaScript.M50063000
{
    public class S12002103 : Event
    {
        public S12002103()
        {
            this.EventID = 12002103;
        }

        public override void OnEvent(ActorPC pc)
        {
            BitMask<Neko_09> Neko_09_mask = new BitMask<Neko_09>(pc.CMask["Neko_09"]);
            //int selection;
            if (Neko_09_mask.Test(Neko_09.完成))
            {
                return;
            }
            if (Neko_09_mask.Test(Neko_09.去军舰岛))
            {
                if (pc.Inventory.Equipments.ContainsKey(EnumEquipSlot.PET))
                {
                    if (pc.Inventory.Equipments[EnumEquipSlot.PET].ItemID == 10017900)
                    {
                        Neko_09_mask.SetValue(Neko_09.完成, true);
                        桃(pc);
                        return;
                    }
                    if (pc.Inventory.Equipments[EnumEquipSlot.PET].ItemID == 10017903)
                    {
                        Neko_09_mask.SetValue(Neko_09.完成, true);
                        藍(pc);
                        return;
                    }
                    if (pc.Inventory.Equipments[EnumEquipSlot.PET].ItemID == 10017905)
                    {
                        Neko_09_mask.SetValue(Neko_09.完成, true);
                        山吹(pc);
                        return;
                    }
                    if (pc.Inventory.Equipments[EnumEquipSlot.PET].ItemID == 10017906)
                    {
                        Neko_09_mask.SetValue(Neko_09.完成, true);
                        菫(pc);
                        return;
                    }
                    if (pc.Inventory.Equipments[EnumEquipSlot.PET].ItemID == 10017907)
                    {
                        Neko_09_mask.SetValue(Neko_09.完成, true);
                        茜(pc);
                        return;
                    }
                    if (pc.Inventory.Equipments[EnumEquipSlot.PET].ItemID == 10017908)
                    {
                        Neko_09_mask.SetValue(Neko_09.完成, true);
                        杏(pc);
                        return;
                    }
                    if (pc.Inventory.Equipments[EnumEquipSlot.PET].ItemID == 10017910)
                    {
                        Neko_09_mask.SetValue(Neko_09.完成, true);
                        空(pc);
                        return;
                    }
                    if (pc.Inventory.Equipments[EnumEquipSlot.PET].ItemID == 10017912)
                    {
                        Neko_09_mask.SetValue(Neko_09.完成, true);
                        胡桃若菜(pc);
                        return;
                    }

                }
                return;
            }
        }
        void 桃(ActorPC pc)
        {
            Say(pc, 0, 0, "お墓がある。$R;" +
            "ここ……、かな？$R;", "");
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 990);
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 1980);
            ShowEffect(pc, 5013);
            Wait(pc, 3960);

            Say(pc, 0, 0, "ここ……。$R;" +
            "連れてきてくれて……ありがとう。$R;" +
            "$P……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ネコマタが肩を震わせている。$R;" +
            "……泣いているようだ。$R;", "");
            Wait(pc, 1980);
            Say(pc, 0, 0, "緑ちゃん、もういいの？$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "……うん、ありがとう。$R;" +
            "これ、前に憑いていた人のお墓。$R;" +
            "$P優しい、おじさんだった……。$R;" +
            "$Rレジスタンスの戦士なんだけど$R;" +
            "明るくて、楽しくて$R;" +
            "いっつも豪快に笑ってた……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑ちゃん……。$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "黒姉さんと一緒に$R;" +
            "お墓を、ここに作ったの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "！？$R;" +
            "$Pちょっと待って、緑ちゃん！$R;" +
            "今、黒姉さんって……！？$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "……言ったわ。$R;" +
            "$P黒姉さんと２人で$R;" +
            "この人に憑いていたの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えっ、えーーー！？$R;" +
            "黒姉さんも！？$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "そう。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃっ、じゃあ！$R;" +
            "今、黒姉さんは！？$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "……今は、いない。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "きえちゃっ……たの？$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "……違う。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃっ、じゃあ！？$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "ご主人を殺した……ＤＥＭと一緒に$R;" +
            "行ってしまったの。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えーーーーー！？$R;" +
            "なんで、なんで、なんで？$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "わからない。$R;" +
            "$Rでも、黒姉さんのことだから$R;" +
            "きっと、何か、理由がある。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "……ん、でもぉ！$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "……うん。$R;" +
            "私も、納得できない。$R;" +
            "$Rだから、もう一度話を聞きにいく。$R;" +
            "黒姉さんに会って$R;" +
            "理由を聞くわ。$R;" +
            "$P……このまま、黒姉さんと$R;" +
            "お別れなんて、イヤ……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑ちゃん……。$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "この人、……借りるわ。$R;" +
            "$Rこの人と一緒に$R;" +
            "黒姉さんに会いに行く……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ちょっ、ちょっと待ってよ！$R;" +
            "この人って、ご主人のこと！？$R;" +
            "$Pダメだよ！$Rご主人は私のだもん！$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "譲って。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ダメだよ！$R;" +
            "ご主人は私のだもん！$R;", "ネコマタ（桃）");

            Say(pc, 0, 0, "……。$R;" +
            "$Pいいわ。勝手に憑いちゃうから。$R;", "ネコマタ（緑）");
            Wait(pc, 990);
            PlaySound(pc, 4012, false, 100, 50);
            ShowEffect(pc, 4131);
            Wait(pc, 5940);
            GiveItem(pc, 10017918, 1);
            Say(pc, 0, 0, "『背負い魔・ネコマタ（新緑）』$Rを手に入れた！$R;" +
            "$P……。$R;" +
            "$P黒の聖堂の司祭が$R;" +
            "何かを、失っている可能性が高いって$R;" +
            "言っていたけれど……。$R;", "");
        }
        void 藍(ActorPC pc)
        {
            Say(pc, 0, 0, "お墓がある。$R;" +
            "ここ……、かな？$R;", "");
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 990);
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 1980);
            ShowEffect(pc, 5013);
            Wait(pc, 3960);

            Say(pc, 0, 0, "ここ……。$R;" +
            "連れてきてくれて……ありがとう。$R;" +
            "$P……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ネコマタが肩を震わせている。$R;" +
            "……泣いているようだ。$R;", "");
            Wait(pc, 1980);
            Say(pc, 0, 0, "緑ちゃん、もういいの？$R;", "ネコマタ（蓝）");

            Say(pc, 0, 0, "……うん、ありがとう。$R;" +
            "これ、前に憑いていた人のお墓。$R;" +
            "$P優しい、おじさんだった……。$R;" +
            "$Rレジスタンスの戦士なんだけど$R;" +
            "明るくて、楽しくて$R;" +
            "いっつも豪快に笑ってた……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑姉さま……。$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "黒姉さんと一緒に$R;" +
            "お墓を、ここに作ったの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "！？$R;" +
            "$Pちょっとお待ち下さい、緑姉さま！$R;" +
            "今、黒姉さんって……！？$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "……言ったわ。$R;" +
            "$P黒姉さんと２人で$R;" +
            "この人に憑いていたの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えっ、えーーー！？$R;" +
            "黒姉さまも！？$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "そう。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "で、では黒姉さまは$R;" +
            "今、いずこに！？$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "……今は、いない。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "きえて……しまわれた？$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "……違う。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "でっ、では！？$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "ご主人を殺した……ＤＥＭと一緒に$R;" +
            "行ってしまったの。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えーーーーー！？$R;" +
            "どっ、どういうことなのですか？$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "わからない。$R;" +
            "$Rでも、黒姉さんのことだから$R;" +
            "きっと、何か、理由がある。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "……でも、姉さま！$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "……うん。$R;" +
            "私も、納得できない。$R;" +
            "$Rだから、もう一度話を聞きにいく。$R;" +
            "黒姉さんに会って$R;" +
            "理由を聞くわ。$R;" +
            "$P……このまま、黒姉さんと$R;" +
            "お別れなんて、イヤ……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑姉さま……。。$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "この人、……借りるわ。$R;" +
            "$Rこの人と一緒に$R;" +
            "黒姉さんに会いに行く……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "……ちょっとお待ち下さい。$R;" +
            "この人って、ぬし様のことですか？$R;" +
            "$Pまことに申し訳ありませんが$R;"+
            "こればっかりは、緑姉さまでも$R:"+
            "お譲りすることは……！$R:", "ネコマタ（藍）");

            Say(pc, 0, 0, "譲って。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ダメです！$R;" +
            "ぬし様は、だって、私の……。$R;", "ネコマタ（藍）");

            Say(pc, 0, 0, "……。$R;" +
            "$Pいいわ。勝手に憑いちゃうから。$R;", "ネコマタ（緑）");
            Wait(pc, 990);
            PlaySound(pc, 4012, false, 100, 50);
            ShowEffect(pc, 4131);
            Wait(pc, 5940);
            GiveItem(pc, 10017918, 1);
            Say(pc, 0, 0, "『背負い魔・ネコマタ（新緑）』$Rを手に入れた！$R;" +
            "$P……。$R;" +
            "$P黒の聖堂の司祭が$R;" +
            "何かを、失っている可能性が高いって$R;" +
            "言っていたけれど……。$R;", "");
        }
        void 山吹(ActorPC pc)
        {
            Say(pc, 0, 0, "お墓がある。$R;" +
            "ここ……、かな？$R;", "");
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 990);
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 1980);
            ShowEffect(pc, 5013);
            Wait(pc, 3960);

            Say(pc, 0, 0, "ここ……。$R;" +
            "連れてきてくれて……ありがとう。$R;" +
            "$P……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ネコマタが肩を震わせている。$R;" +
            "……泣いているようだ。$R;", "");
            Wait(pc, 1980);
            Say(pc, 0, 0, "緑姉やん、もういいん？$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "……うん、ありがとう。$R;" +
            "これ、前に憑いていた人のお墓。$R;" +
            "$P優しい、おじさんだった……。$R;" +
            "$Rレジスタンスの戦士なんだけど$R;" +
            "明るくて、楽しくて$R;" +
            "いっつも豪快に笑ってた……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑姉やん……。。$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "黒姉さんと一緒に$R;" +
            "お墓を、ここに作ったの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "！？$R;" +
            "$Pちょっと待ってな、緑姉やん！$R;" +
            "今、黒姉さんって……！？$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "……言ったわ。$R;" +
            "$P黒姉さんと２人で$R;" +
            "この人に憑いていたの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えっ、えーーー！？$R;" +
            "あの黒姉やんも！？$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "そう。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "で、では黒姉やんは$R;" +
            "今、どこにいったん？？$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "……今は、いない。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "きえて……もうた？$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "……違う。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃ、じゃあ！？$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "ご主人を殺した……ＤＥＭと一緒に$R;" +
            "行ってしまったの。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えーーーーー！？$R;" +
            "どっ、どういうことなん？$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "わからない。$R;" +
            "$Rでも、黒姉さんのことだから$R;" +
            "きっと、何か、理由がある。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "……でも、緑姉やん！$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "……うん。$R;" +
            "私も、納得できない。$R;" +
            "$Rだから、もう一度話を聞きにいく。$R;" +
            "黒姉さんに会って$R;" +
            "理由を聞くわ。$R;" +
            "$P……このまま、黒姉さんと$R;" +
            "お別れなんて、イヤ……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑姉やん……。$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "この人、……借りるわ。$R;" +
            "$Rこの人と一緒に$R;" +
            "黒姉さんに会いに行く……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ちょっ、ちょっと待って！$R;" +
            "うちは？$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "ごめん。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ダメだよ！$R;" +
            "ご主人は私のだもん！$R;", "ネコマタ（山吹）");

            Say(pc, 0, 0, "……。$R;" +
            "$Pいいわ。勝手に憑いちゃうから。$R;", "ネコマタ（緑）");
            Wait(pc, 990);
            PlaySound(pc, 4012, false, 100, 50);
            ShowEffect(pc, 4131);
            Wait(pc, 5940);
            GiveItem(pc, 10017918, 1);
            Say(pc, 0, 0, "『背負い魔・ネコマタ（新緑）』$Rを手に入れた！$R;" +
            "$P……。$R;" +
            "$P黒の聖堂の司祭が$R;" +
            "何かを、失っている可能性が高いって$R;" +
            "言っていたけれど……。$R;", "");
        }
        void 菫(ActorPC pc)
        {
            Say(pc, 0, 0, "お墓がある。$R;" +
            "ここ……、かな？$R;", "");
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 990);
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 1980);
            ShowEffect(pc, 5013);
            Wait(pc, 3960);

            Say(pc, 0, 0, "ここ……。$R;" +
            "連れてきてくれて……ありがとう。$R;" +
            "$P……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ネコマタが肩を震わせている。$R;" +
            "……泣いているようだ。$R;", "");
            Wait(pc, 1980);
            Say(pc, 0, 0, "緑、もういいの？$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "……うん、ありがとう。$R;" +
            "これ、前に憑いていた人のお墓。$R;" +
            "$P優しい、おじさんだった……。$R;" +
            "$Rレジスタンスの戦士なんだけど$R;" +
            "明るくて、楽しくて$R;" +
            "いっつも豪快に笑ってた……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑……。$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "黒姉さんと一緒に$R;" +
            "お墓を、ここに作ったの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "！？$R;" +
            "$Pちょっと待ちなさい、緑！$R;" +
            "今、黒姉さんって……！？$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "……言ったわ。$R;" +
            "$P黒姉さんと２人で$R;" +
            "この人に憑いていたの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えっ、えーーー！？$R;" +
            "黒お姉さんも！？$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "そう。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "で、では黒お姉さんは$R;" +
            "今、どちらに！？！？$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "……今は、いない。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "きえて……しまった？$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "……違う。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃ、じゃあ！？$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "ご主人を殺した……ＤＥＭと一緒に$R;" +
            "行ってしまったの。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えーーーーー！？$R;" +
            "どっ、どういうことなの？$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "わからない。$R;" +
            "$Rでも、黒姉さんのことだから$R;" +
            "きっと、何か、理由がある。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "……でも、緑！！$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "……うん。$R;" +
            "私も、納得できない。$R;" +
            "$Rだから、もう一度話を聞きにいく。$R;" +
            "黒姉さんに会って$R;" +
            "理由を聞くわ。$R;" +
            "$P……このまま、黒姉さんと$R;" +
            "お別れなんて、イヤ……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑……。$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "この人、……借りるわ。$R;" +
            "$Rこの人と一緒に$R;" +
            "黒姉さんに会いに行く……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ちょっ、ちょっと待ちなさい！$R;" +
            "この人って、うちの人はダメよ！$R;" , "ネコマタ（菫）");

            Say(pc, 0, 0, "譲って。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "こればっかりは、いっくら緑でも！$R;" +
            "こればっかりは、いっくら緑でも！$R;", "ネコマタ（菫）");

            Say(pc, 0, 0, "……。$R;" +
            "$Pいいわ。勝手に憑いちゃうから。$R;", "ネコマタ（緑）");
            Wait(pc, 990);
            PlaySound(pc, 4012, false, 100, 50);
            ShowEffect(pc, 4131);
            Wait(pc, 5940);
            GiveItem(pc, 10017918, 1);
            Say(pc, 0, 0, "『背負い魔・ネコマタ（新緑）』$Rを手に入れた！$R;" +
            "$P……。$R;" +
            "$P黒の聖堂の司祭が$R;" +
            "何かを、失っている可能性が高いって$R;" +
            "言っていたけれど……。$R;", "");
        }
        void 茜(ActorPC pc)
        {
            Say(pc, 0, 0, "お墓がある。$R;" +
            "ここ……、かな？$R;", "");
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 990);
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 1980);
            ShowEffect(pc, 5013);
            Wait(pc, 3960);

            Say(pc, 0, 0, "ここ……。$R;" +
            "連れてきてくれて……ありがとう。$R;" +
            "$P……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ネコマタが肩を震わせている。$R;" +
            "……泣いているようだ。$R;", "");
            Wait(pc, 1980);
            Say(pc, 0, 0, "緑姉さん、もういいの？$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "……うん、ありがとう。$R;" +
            "これ、前に憑いていた人のお墓。$R;" +
            "$P優しい、おじさんだった……。$R;" +
            "$Rレジスタンスの戦士なんだけど$R;" +
            "明るくて、楽しくて$R;" +
            "いっつも豪快に笑ってた……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑姉さん……。$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "黒姉さんと一緒に$R;" +
            "お墓を、ここに作ったの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "！？$R;" +
            "$Pちょっと待って、緑姉さん！$R;" +
            "今、黒姉さんって……！？$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "……言ったわ。$R;" +
            "$P黒姉さんと２人で$R;" +
            "この人に憑いていたの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えっ、えーーー！？$R;" +
            "黒姉さんも！？$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "そう。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃ、じゃあ黒姉さんは！$R;" +
            "今、どこにいるの？？$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "……今は、いない。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "きえて……しまった？$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "……違う。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃ、じゃあ！？$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "ご主人を殺した……ＤＥＭと一緒に$R;" +
            "行ってしまったの。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えーーーーー！？$R;" +
            "どっ、どういうことよそれ？$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "わからない。$R;" +
            "$Rでも、黒姉さんのことだから$R;" +
            "きっと、何か、理由がある。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "……でも、緑姉さん！$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "……うん。$R;" +
            "私も、納得できない。$R;" +
            "$Rだから、もう一度話を聞きにいく。$R;" +
            "黒姉さんに会って$R;" +
            "理由を聞くわ。$R;" +
            "$P……このまま、黒姉さんと$R;" +
            "お別れなんて、イヤ……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑姉さん……。。$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "この人、……借りるわ。$R;" +
            "$Rこの人と一緒に$R;" +
            "黒姉さんに会いに行く……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ちょっ、ちょっと待って！$R;" +
            "急に何言うのよ！$R;", "ネコマタ（茜）");

            Say(pc, 0, 0, "譲って。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "あのねぇ、こいつは私のなの！$R;" +
            "私とずーっと一緒にいるの！$R;"+
            "貸し借りなんて！！！$R:", "ネコマタ（茜）");

            Say(pc, 0, 0, "……。$R;" +
            "$Pいいわ。勝手に憑いちゃうから。$R;", "ネコマタ（緑）");
            Wait(pc, 990);
            PlaySound(pc, 4012, false, 100, 50);
            ShowEffect(pc, 4131);
            Wait(pc, 5940);
            GiveItem(pc, 10017918, 1);
            Say(pc, 0, 0, "『背負い魔・ネコマタ（新緑）』$Rを手に入れた！$R;" +
            "$P……。$R;" +
            "$P黒の聖堂の司祭が$R;" +
            "何かを、失っている可能性が高いって$R;" +
            "言っていたけれど……。$R;", "");
        }
        void 杏(ActorPC pc)
        {
            Say(pc, 0, 0, "お墓がある。$R;" +
            "ここ……、かな？$R;", "");
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 990);
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 1980);
            ShowEffect(pc, 5013);
            Wait(pc, 3960);

            Say(pc, 0, 0, "ここ……。$R;" +
            "連れてきてくれて……ありがとう。$R;" +
            "$P……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ネコマタが肩を震わせている。$R;" +
            "……泣いているようだ。$R;", "");
            Wait(pc, 1980);
            Say(pc, 0, 0, "緑お姉ちゃん、もういいの？$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "……うん、ありがとう。$R;" +
            "これ、前に憑いていた人のお墓。$R;" +
            "$P優しい、おじさんだった……。$R;" +
            "$Rレジスタンスの戦士なんだけど$R;" +
            "明るくて、楽しくて$R;" +
            "いっつも豪快に笑ってた……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑お姉ちゃん……。$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "黒姉さんと一緒に$R;" +
            "お墓を、ここに作ったの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "！？$R;" +
            "いま、黒おねえさんって？$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "……言ったわ。$R;" +
            "$P黒姉さんと２人で$R;" +
            "この人に憑いていたの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えっ、えーーー！？$R;" +
            "黒お姉ちゃんもいたの？$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "そう。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃ、じゃあ黒お姉ちゃんは$R;" +
            "今、どこにいるの？？$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "……今は、いない。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "きえ……ちゃったの？$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "……違う。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃ、じゃあ！？$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "ご主人を殺した……ＤＥＭと一緒に$R;" +
            "行ってしまったの。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えーーーーー！？$R;" +
            "ど、どういうことなの？$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "わからない。$R;" +
            "$Rでも、黒姉さんのことだから$R;" +
            "きっと、何か、理由がある。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "……でも、緑お姉ちゃん！$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "……うん。$R;" +
            "私も、納得できない。$R;" +
            "$Rだから、もう一度話を聞きにいく。$R;" +
            "黒姉さんに会って$R;" +
            "理由を聞くわ。$R;" +
            "$P……このまま、黒姉さんと$R;" +
            "お別れなんて、イヤ……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑お姉ちゃん……。。$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "この人、……借りるわ。$R;" +
            "$Rこの人と一緒に$R;" +
            "黒姉さんに会いに行く……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えっ、ちょっとまってよ！$R;" +
            "$Pボクは？$R;", "ネコマタ（杏）");

            Say(pc, 0, 0, "お留守番。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "やだよぉ！$R;" +
            "それに、ボクのご主人なんだから$R;"+
            "ボクがお留守番なんて！！！$R:", "ネコマタ（杏）");

            Say(pc, 0, 0, "……。$R;" +
            "$Pいいわ。勝手に憑いちゃうから。$R;", "ネコマタ（緑）");
            Wait(pc, 990);
            PlaySound(pc, 4012, false, 100, 50);
            ShowEffect(pc, 4131);
            Wait(pc, 5940);
            GiveItem(pc, 10017918, 1);
            Say(pc, 0, 0, "『背負い魔・ネコマタ（新緑）』$Rを手に入れた！$R;" +
            "$P……。$R;" +
            "$P黒の聖堂の司祭が$R;" +
            "何かを、失っている可能性が高いって$R;" +
            "言っていたけれど……。$R;", "");
        }
        void 空(ActorPC pc)
        {
            Say(pc, 0, 0, "お墓がある。$R;" +
            "ここ……、かな？$R;", "");
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 990);
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 1980);
            ShowEffect(pc, 5013);
            Wait(pc, 3960);

            Say(pc, 0, 0, "ここ……。$R;" +
            "連れてきてくれて……ありがとう。$R;" +
            "$P……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ネコマタが肩を震わせている。$R;" +
            "……泣いているようだ。$R;", "");
            Wait(pc, 1980);
            Say(pc, 0, 0, "緑、もういいのか？$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "……うん、ありがとう。$R;" +
            "これ、前に憑いていた人のお墓。$R;" +
            "$P優しい、おじさんだった……。$R;" +
            "$Rレジスタンスの戦士なんだけど$R;" +
            "明るくて、楽しくて$R;" +
            "いっつも豪快に笑ってた……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑……。$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "黒姉さんと一緒に$R;" +
            "お墓を、ここに作ったの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "！？$R;" +
            "いま、黒ねえちゃんって？$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "……言ったわ。$R;" +
            "$P黒姉さんと２人で$R;" +
            "この人に憑いていたの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えっ、えーーー！？$R;" +
            "黒ねえちゃんもいたのか？？？$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "そう。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃ、じゃあねえちゃんは$R;" +
            "今、どこにいるの？？$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "……今は、いない。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃ、じゃあ！？$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "……違う。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "じゃっ、じゃあ！？$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "ご主人を殺した……ＤＥＭと一緒に$R;" +
            "行ってしまったの。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えーーーーー！？$R;" +
            "ど、どういうこと？$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "わからない。$R;" +
            "$Rでも、黒姉さんのことだから$R;" +
            "きっと、何か、理由がある。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "……おい、緑！$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "……うん。$R;" +
            "私も、納得できない。$R;" +
            "$Rだから、もう一度話を聞きにいく。$R;" +
            "黒姉さんに会って$R;" +
            "理由を聞くわ。$R;" +
            "$P……このまま、黒姉さんと$R;" +
            "お別れなんて、イヤ……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑……。$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "この人、……借りるわ。$R;" +
            "$Rこの人と一緒に$R;" +
            "黒姉さんに会いに行く……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ちょっ、ちょっと待ってよ！$R;" +
            "この人って、ご主人のこと！？$R;" +
            "$Pダメだよ！$Rご主人は私のだもん！$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "譲って。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "できるかぁっ！！$R;" +
            "これは譲れないぞ！！$R;", "ネコマタ（空）");

            Say(pc, 0, 0, "……。$R;" +
            "$Pいいわ。勝手に憑いちゃうから。$R;", "ネコマタ（緑）");
            Wait(pc, 990);
            PlaySound(pc, 4012, false, 100, 50);
            ShowEffect(pc, 4131);
            Wait(pc, 5940);
            GiveItem(pc, 10017918, 1);
            Say(pc, 0, 0, "『背負い魔・ネコマタ（新緑）』$Rを手に入れた！$R;" +
            "$P……。$R;" +
            "$P黒の聖堂の司祭が$R;" +
            "何かを、失っている可能性が高いって$R;" +
            "言っていたけれど……。$R;", "");
        }
        void 胡桃若菜(ActorPC pc)
        {
            Say(pc, 0, 0, "お墓がある。$R;" +
            "ここ……、かな？$R;", "");
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 990);
            ShowEffect(pc, 205, 69, 5057);
            Wait(pc, 1980);
            ShowEffect(pc, 5013);
            Wait(pc, 3960);

            Say(pc, 0, 0, "ここ……。$R;" +
            "連れてきてくれて……ありがとう。$R;" +
            "$P……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ネコマタが肩を震わせている。$R;" +
            "……泣いているようだ。$R;", "");
            Wait(pc, 1980);
            Say(pc, 0, 0, "緑おねえさん、もういいんですか？$R;", "ネコマタ（胡桃）");

            Say(pc, 0, 0, "……うん、ありがとう。$R;" +
            "これ、前に憑いていた人のお墓。$R;" +
            "$P優しい、おじさんだった……。$R;" +
            "$Rレジスタンスの戦士なんだけど$R;" +
            "明るくて、楽しくて$R;" +
            "いっつも豪快に笑ってた……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ん……、おねえちゃん……。$R;", "ネコマタ（若菜）");

            Say(pc, 0, 0, "黒姉さんと一緒に$R;" +
            "お墓を、ここに作ったの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "！？$R;" +
            "いま、黒おねえさんって？$R;", "ネコマタ（胡桃）");

            Say(pc, 0, 0, "……言ったわ。$R;" +
            "$P黒姉さんと２人で$R;" +
            "この人に憑いていたの……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えっ、えーーー！？$R;" +
            "黒おねえさんもいたんですか？$R;", "ネコマタ（胡桃）");

            Say(pc, 0, 0, "そう。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "ん……と、黒おねえちゃんは？$R;" +
            "若菜、黒おねえちゃんにも会いたいよ。$R;", "ネコマタ（若菜）");

            Say(pc, 0, 0, "……今は、いない。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "　ん……どうして？$R;", "ネコマタ（若菜）");

            Say(pc, 0, 0, "ご主人を殺した……ＤＥＭと一緒に$R;" +
            "行ってしまったの。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "えーーーーー！？$R;" +
            "ど、どういうことですか？$R;", "ネコマタ（胡桃）");

            Say(pc, 0, 0, "わからない。$R;" +
            "$Rでも、黒姉さんのことだから$R;" +
            "きっと、何か、理由がある。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "……おねえさん、でも！$R;", "ネコマタ（若菜）");

            Say(pc, 0, 0, "……うん。$R;" +
            "私も、納得できない。$R;" +
            "$Rだから、もう一度話を聞きにいく。$R;" +
            "黒姉さんに会って$R;" +
            "理由を聞くわ。$R;" +
            "$P……このまま、黒姉さんと$R;" +
            "お別れなんて、イヤ……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "緑おねえちゃん……。。$R;", "ネコマタ（若菜）");

            Say(pc, 0, 0, "この人、……借りるわ。$R;" +
            "$Rこの人と一緒に$R;" +
            "黒姉さんに会いに行く……。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0, "はい、……ってちょっと待ってください！$R;" +
            "$P私たちは？$R;", "ネコマタ（胡桃）");

            Say(pc, 0, 0, "お留守番。$R;", "ネコマタ（緑）");

            Say(pc, 0, 0,  "ん……、若菜、そんなのやだ！$R;", "ネコマタ（若菜）");
            Say(pc, 0, 0, "胡桃だって、いやです！$R:", "ネコマタ（胡桃）");

            Say(pc, 0, 0, "……。$R;" +
            "$Pいいわ。勝手に憑いちゃうから。$R;", "ネコマタ（緑）");
            Wait(pc, 990);
            PlaySound(pc, 4012, false, 100, 50);
            ShowEffect(pc, 4131);
            Wait(pc, 5940);
            GiveItem(pc, 10017918, 1);
            Say(pc, 0, 0, "『背負い魔・ネコマタ（新緑）』$Rを手に入れた！$R;" +
            "$P……。$R;" +
            "$P黒の聖堂の司祭が$R;" +
            "何かを、失っている可能性が高いって$R;" +
            "言っていたけれど……。$R;", "");
        }

    }
}