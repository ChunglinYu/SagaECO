﻿using System;
using System.Collections.Generic;
using System.Text;

using SagaDB.Actor;
using SagaMap.Scripting;

using SagaLib;
using SagaScript.Chinese.Enums;
namespace SagaScript.M10024000
{
    public class S11001977 : Event
    {
        public S11001977()
        {
            this.EventID = 11001977;
        }

        public override void OnEvent(ActorPC pc)
        {
            //Say(pc,11001977, 131, "现在不承接任何业务,以后再来吧$R;" , "柯尔契卡");
            BitMask<Iris_1> Iris_1_mask = new BitMask<Iris_1>(pc.CMask["Iris_1"]);

            if (Iris_1_mask.Test(Iris_1.第一次对话后))
            {
                Say(pc, 131, "怎么了$R;", "柯尔契卡");
                switch (Select(pc, "怎么办？", "", "卡片是什么", "扩充装备插槽", "听取扩充插槽的说明", "升级卡片(不推荐使用)", "听取升级卡片的说明"))
                {
                    case 1:
                        Say(pc, 131, "假如增加扩充装备插槽的话$R;" +
                        "要拿来对应的道具$R;" +
                        "并且有一定的风险$R;" +
                        "所以不能没有心理准备!$R;", "柯尔契卡");
                        break;
                    case 2:
                        ItemAddSlot(pc);

                        break;
                    case 3:
                        switch (Select(pc, "請問你要聽哪一個說明？", "", "擴充裝備插位是什麼？", "需要什麼道具？", "裝備的等級的需要"))
                        {
                            case 1:
                                Say(pc, 131, "在裝備上擴充是用作$R;" +
                                "IRIS卡片插位。$R;" +
                                "至於什麼裝備能擴充裝備插位？$R;" +
                                "$P右手用的武器和$R;" +
                                "兩手武器是可以的$R;" +
                                "但是投擲武器不同。$R;" +
                                "因為扔所以是不可能的！$R;", "灰のコルチカ");
                                Say(pc, 131, "以下是上下半身的裝備說明$R;" +
                                "上下半身的防具也可以$R;", "灰のコルチカ");

                                Say(pc, 131, "最後是其他的說明$R;" +
                                "即是在什麼地方$R;" +
                                "如果為了增加各種各樣插位$R;" +
                                "需要準備道具和加工成本。$R;" +
                                "另外不要忘記失敗的風險$R;" +
                                "不要忘記這件事。$R;", "灰のコルチカ");
                                break;
                            case 2:
                                Say(pc, 131, "簡單來說$R;" +
                                "「想いの結晶」這個的道具$R;" +
                                "是需要的。$R;" +
                                "$P這個是增加插位$R;" +
                                "裝備也可以有一點變化。$R;" +
                                "簡單地可以使用的東西，由於普通的$R;" +
                                "「想いの結晶」比較……$R;" +
                                "困難處理$R;" +
                                "某程度上重複處理得到經驗的$R;" +
                                "當玩家追求更多裝備上的能力變化$R;" +
                                "必須使用效果理想的想いの結晶。$R;", "灰のコルチカ");

                                Say(pc, 131, "提提你，想いの結晶$R;" +
                                "在商店不能賣掉。$R;" +
                                "如果請求ジーニャ博士的話、$R;" +
                                "東西變成原料形成道具、$R;" +
                                "那個不加工的$R;" +
                                "並且雖然轉讓本身的道具$R;", "灰のコルチカ");
                                break;
                        }
                        break;
                    case 4:
                        IrisCardAssemble(pc);
                        break;
                    case 5:
                        Say(pc, 131, "首先是準備道具的時候$R;" +
                        "$P首先準備普通的卡片$R;" +
                        "10張是必須準備的。$R;" +
                        "還要是全部相同的卡片$R;" +
                        "如果那麼沒有沒用因此。$R;" +
                        "$P當想法的力被攙合的時候$R;" +
                        "巧妙不接二連三地發生的的地方$R;" +
                        "全體被攙合,變得好像沒有。$R;", "灰のコルチカ");

                        Say(pc, 131, "從等級1到4的合計4階級有組裝。$R;" +
                        "效果變得內容豐富$R;" +
                        "卡片清楚多次做了組裝的一方？$R;" +
                        "$P雖然剛才說了可是做等級1的卡片$R;" +
                        "10枚的普通的卡片$R;" +
                        "變得需要、$R;" +
                        "當等級1完成了的時候$R;" +
                        "能變得挑戰的事使2枚的那個等級1的卡片變成素材$R;" +
                        "做等級2的卡。$R;" +
                        "$P在不來的風、$R;" +
                        "把2枚的等級2的卡片排在素材的3的卡片。$R;" +
                        "變得能做把2枚的等級3的卡片。$R;" +
                        "排在素材的4的卡片$R;" +
                        "理論上可能會跳起來。$R;", "灰のコルチカ");

                        Say(pc, 131, "每當印組裝的時候那張卡的$R;" +
                        "效果完成。$R;" +
                        "甚至當ちゃけ、風險用完、$R;" +
                        "並且因為是東西$R;" +
                        "所以到需要的地方做組裝了的時候$R;" +
                        "$P把手留在中的一個的手段？$R;" +
                        "啊假如在隔壁的賭博好像好、$R;" +
                        "並且也許一下子變成か或者ん的話,雖然不打算發牢騷可是睡覺,並且是ー。$R;", "灰のコルチカ");

                        Say(pc, 11001975, 131, "……へっ梳子ゅん！$R;" +
                        "謠傳你在說我的事情,た？$R;", "壊し屋バキア");

                        Say(pc, 131, "う好是什麼。$R;" +
                        "不過啊多麼說嗎？……$R;" +
                        "有許多最近裝備插位的擴充$R;" +
                        "和組裝果斷挑戰的人的多了……$R;", "灰のコルチカ");

                        Say(pc, 131, "雖然這盡管不說但是清楚認為$R;" +
                        "可是也像溝擴充那樣組裝$R;" +
                        "有失敗的風險$R;" +
                        "$P組裝因為單一卡其本身$R;" +
                        "變成素材所以對其他沒有素材$R;" +
                        "也好……$R;" +
                        "全體消失、因為變得沒有高成功率$R;" +
                        "所以只有心理准備認定失敗！$R;" +
                        "$P等級1的組裝$R;" +
                        "是成功率還高的一方……$R;" +
                        "因為在全世界$R;" +
                        "絕對沒有事情是準確成功。$R;", "灰のコルチカ");
                        break;
                }
            }
            else
            {
                Say(pc, 11001975, 138, "去,並且是っ！　已經是一次！$R;" +
                "假如是這個的話,能做好！$R;" +
                "絕對地能做好！$R;", "壊し屋バキア");

                Say(pc, 131, "去的わよっ！$R;" +
                "雖然風險高可是去的わよっ！$R;" +
                "已經不能後退的わよっ！$R;", "灰のコルチカ");

                Say(pc, 11001975, 158, "啊是～～$R;" +
                "か,借來的スタンブレイドが……$R;" +
                "另外,在身無分文是往回走或者～～$R;", "壊し屋バキア");

                Say(pc, 0, 0, "（……正做什麼吧？）$R;", " ");

                Say(pc, 11001975, 134, "くっそぉ～～、$R;" +
                "從明天起生活並且使用假名。$R;", "壊し屋バキア");
                ShowEffect(pc, 11001975, 4516);

                Say(pc, 11001975, 131, "ん？$R;" +
                "我是仁慈？$R;", "壊し屋バキア");
                ShowEffect(pc, 4506);

                Say(pc, 0, 0, "非是,因此沒有……$R;", " ");
                ShowEffect(pc, 11001977, 4516);

                Say(pc, 131, "バキア。你騒い,並且,因並且出來所以是よ。$R;", "灰のコルチカ");

                Say(pc, 11001975, 210, "……包裹吧,但是あたい身體無分句子吧被用深的悲任所以成是自己ま,因是尾不做。$R;" +
                "って,めん不干。$R;" +
                "把你留下來。$R;" +
                "$P有あた,並且是是コルチカ。$R;" +
                "那裡的是的笨蛋バキア。$R;", "壊し屋バキア");

                Say(pc, 131, "啊是那？、$R;" +
                "非是,壞壞。熱收成非的智智っち非非非是一切性的～。$R;" +
                "是否是什麼是？……$R;" +
                "什麼,る的事但是時っ,盡管正清楚危挑候,必當是男人的西面的よ,並且是バキア。$R;" +
                "$P你對像西面理由於普通的博是し,並且是ょ。$R;" +
                "原來在做之前正當地成功的概率低速去,是了。$R;" +
                "然後最好被停止的っ,個人個,並且照射但是只西失,方面原來好幾次在る的對像是氣有自信。$R;", "灰のコルチカ");

                Say(pc, 11001975, 131, "那。$R;", "壊し屋バキア");

                Say(pc, 131, "……包裹吧$R;" +
                "但是あたい身無分文、$R;" +
                "被用深的悲任、$R;" +
                "所以成是自己ま$R;" +
                "$Pって,めん不干。$R;" +
                "把你留下來。$R;" +
                "有あた,並且是是コルチカ。$R;" +
                "那裡的是的笨蛋バキア。$R;", "灰のコルチカ");

                Say(pc, 11001975, 131, "做什麼$R;" +
                "……啊你好？$R;" +
                "你的冒,確是對像$R;" +
                "收成夢的欠缺片的ろ？$R;" +
                "是る知道姓名,的ぜ。$R;", "壊し屋バキア");

                Say(pc, 11001975, 131, "搞紊亂知道卡片っ,,是る？$R;" +
                "好像什麼首都$R;" +
                "以及“想いの力”什麼性的是成了卡的是西面。$R;" +
                "物らしい。$R;" +
                "$P細かい理屈は俺にはわからないが、$R;" +
                "理由,但是首先加工武器以及防具$R;" +
                "加入卡我非干淨整潔的小性的能。$R;" +
                "該結果$R;" +
                "$P並且加入卡的候那套裝$R;" +
                "利益理由於收成フシギ性的力大。$R;", "壊し屋バキア");

                Say(pc, 0, 0, "收成是フシギ性的力？$R;", " ");

                Say(pc, 131, "最理由上是什麼?、$R;" +
                "是否說給博士聽$R;", "灰のコルチカ");

                Say(pc, 11001975, 131, "是那？……$R;" +
                "不如委托與那個我是家的事是第一？$R;", "壊し屋バキア");

                Say(pc, 0, 0, "結果,並且才的西成到底？……$R;", " ");

                Say(pc, 11001975, 361, "啊……$R;" +
                "剛才加工裝備……$R;" +
                "被說了的ろ？$R;" +
                "$P原來關於這張卡$R;" +
                "研究也還沒有結束,$R;" +
                "並且那種加工當然仍然有失敗的事……$R;", "壊し屋バキア");

                Say(pc, 131, "第一次的家容易還成功。$R;" +
                "抱住在ど,經常失敗的有可能性$R;" +
                "從第3次相當危險。$R;" +
                "$R當出來,並且失敗的時候……$R;", "灰のコルチカ");

                Say(pc, 11001975, 158, "像我那樣漂亮地弄壞全部裝備$R;", "壊し屋バキア");

                Say(pc, 11001975, 134, "啊是っ！　已經好！$R;" +
                "把那樣的過去忘記吧！$R;" +
                "我們應該看未來吧！$R;" +
                "應該更向前去！$R;", "壊し屋バキア");

                Say(pc, 131, "什麼應該在過去學多？$R;" +
                "$P如果當失敗的時候風險的高的賭博艱難$R;" +
                "比方說是か。。$R;" +
                "$R當隨便搞亂借來的裝備,$R;" +
                "被朋友發怒的時候是か。$R;", "灰のコルチカ");
                ShowEffect(pc, 11001975, 4506);

                Say(pc, 11001975, 131, "不,那個是作為だ的ぁ……$R;" +
                "$Pほ,ほ是っ。$R;" +
                "是因為使人等候的事壞$R;" +
                "並且去早地方吧的ぜ。$R;" +
                "$P但是有理由壞R;" +
                "不能表明。$R;" +
                "也默默給混成騎士團て？$R;" +
                "因為我是引導所以跟我來吧。$R;", "壊し屋バキア");
                Warp(pc, 30166000, 9, 16);
                Iris_1_mask.SetValue(Iris_1.第一次对话后, true);
            }

        }
    }
}
