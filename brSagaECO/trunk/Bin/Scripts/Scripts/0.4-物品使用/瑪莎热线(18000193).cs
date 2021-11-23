using System;
using System.Collections.Generic;
using System.Text;

using SagaDB.Actor;
using SagaMap.Scripting;

using SagaLib;
using SagaScript.Chinese.Enums;
namespace SagaScript.瑪莎热线
{
    public class S18000193 : Event
    {
        public S18000193()
        {
            this.EventID = 18000193;
        }

        public override void OnEvent(ActorPC pc)
        {
            BitMask<Beginner_02> Beginner_02_mask = new BitMask<Beginner_02>(pc.CMask["Beginner_02"]);
            int selection;
            if (!Beginner_02_mask.Test(Beginner_02.第一次使用瑪莎熱線))
            {
               第一次瑪莎熱線(pc);
               return;
            }
            else
            {
                selection = Select(pc, "要做甚麼呢？", "", "瑪莎熱線　《跟瑪莎說話》", "多通道　　　《使用通信機能》", "切斷通信");

                // 02/09/2015 
                /*
                selection = Select(pc, "何をしますか？", "", "マーシャホットライン　《マーシャと話す》", "マルチチャンネル　　　《通信機能を使う》", "通信を切る");
                */

                while (selection != 3)
                {
                    switch (selection)
                    {
                        case 1:
                            Say(pc, 0, 0, "喂喂～？$R;" +
                            "這裡是$R;" +
                            "『瑪莎的冒險者協助$R;" +
                            "熱線』♪$R;" +
                            "" + pc.Name + "先生/小姐！ 午安！$R;" +
                            "$P 啊、還在那個島呢。$R;" +
                            "在到着那個島的時候$R;" +
                            "身邊的是誰？$R;" +
                            "假如有誰人的話、$R;" +
                            "首先嘗試跟他說話！$R;" +
                            "$P總之跟別人說話$R;" +
                            "收集情報的事情！$R;" +
                            "這是作為冒險者的$R;" +
                            "第一步唷$R;" +
                            "$P假如、即使這樣做了也不知道的話、$R;" +
                            "到連繫著世界中的冒險者$R;" +
                            "多通道的$R;" +
                            "初心者掲示板$R;" +
                            "檢索就可以了。$R;" +
                            "$P沒有任何情報的話、$R;" +
                            "自己$R;" +
                            "在初心者掲示板上$R;" +
                            "嘗試寫上、$R;" +
                            "自己的質問吧！$R;" +
                            "$P一定有經驗豐富的$R;" +
                            "其他冒險者$R;" +
                            "去幫助你的。$R;", "瑪莎");
                            break;

                        /*
                        Say(pc, 0, 0, "もしもし～？$R;" +
                        "こちらは$R;" +
                        "『マーシャの冒険者お助け$R;" +
                        "　ホットライン』です♪$R;" +
                        "" + pc.Name + "さん！ こんにちは！$R;" +
                        "$Pあ、まだあの島にいるのね。$R;" +
                        "その島に着いた時$R;" +
                        "近くに誰かいなかった？$R;" +
                        "もし誰かいたなら、$R;" +
                        "まずは話しかけてみて！$R;" +
                        "$Pとにかく人と話して$R;" +
                        "情報収集をすること！$R;" +
                        "それが冒険者としての$R;" +
                        "第一歩よ。$R;" +
                        "$Pもし、それでも判らなかったら、$R;" +
                        "世界中の冒険者と繋がる$R;" +
                        "マルチチャンネルの$R;" +
                        "初心者掲示板で$R;" +
                        "調べてみるといいわ。$R;" +
                        "$P何も情報がなければ、$R;" +
                        "自分で$R;" +
                        "初心者掲示板に$R;" +
                        "書き込んで、$R;" +
                        "質問をしてみてね！$R;" +
                        "$Pきっと経験豊かな$R;" +
                        "冒険者の誰かが$R;" +
                        "助けてくれるわ。$R;", "マーシャ");
                        break;
                        */

                        case 2:
                            通信機能(pc);
                            return;
                            //break;
                    }
                    selection = Select(pc, "何をしますか？", "", "マーシャホットライン　《マーシャと話す》", "マルチチャンネル　　　《通信機能を使う》", "通信を切る");
                }
                }

        }

        void 第一次瑪莎熱線(ActorPC pc)
        {
            BitMask<Beginner_02> Beginner_02_mask = new BitMask<Beginner_02>(pc.CMask["Beginner_02"]);
            
            switch (Select(pc, "要做甚麼呢？", "", "瑪莎熱線　《跟瑪莎說話》", "多通道　　　《使用通信機能》", "切斷通信"))

            /*
            switch (Select(pc, "何をしますか？", "", "マーシャホットライン　《マーシャと話す》", "マルチチャンネル　　　《通信機能を使う》", "通信を切る"))
            */
            {
                case 1:
                    Beginner_02_mask.SetValue(Beginner_02.第一次使用瑪莎熱線, true);
                    Say(pc, 0, 0, "喂喂～？$R;" +
                    "這裡是$R;" +
                    "『瑪莎的冒險者協助$R;" +
                    "熱線』♪$R;" +
                    "$P嗚霍霍(細聲笑)。$R;" +
                    "是的是的、 そうそう、そうやって使うの。$R;" +
                    "如果飛空庭已經降落了的話、 飛空庭を降りたら$R;" +
                    "首先、試試$R;" +
                    "瑪莎熱線呢♪$R;" +
                    "$P假如、瑪莎熱線$R;" +
                    "如果已經的話 なくしてしまったら$R;" +
                    "可以在阿高普路斯可動橋$R;" +
                    "嘗試拜託$R;" +
                    "初心者案内人呢。$R;" +
                    "$P 代わりのマーシャホットラインを$R;" +
                    " 渡してくれるように$R;" +
                    " お願いしておいたから！$R;" +
                    "$P それと、もう一つ。$R;" +
                    " これもどうぞ！$R;", "瑪莎");
                    Say(pc, 0, 0, "那麼就、$R;" +
                    "直到阿高普路斯城$R;" +
                    "全速前進ー！$R;" +
                    "為了不被拋開$R;" +
                    "要小心呢！$R;", "瑪莎");
                    Warp(pc, 10071000, 245, 82);
                    break;
                    
                    /*
                    Beginner_02_mask.SetValue(Beginner_02.第一次使用瑪莎熱線, true);
                    Say(pc, 0, 0, "もしもし～？$R;" +
                    "こちらは、$R;" +
                    "『マーシャの冒険者$R;" +
                    "　お助けホットライン』です♪$R;" +
                    "$Pうふふ。$R;" +
                    "そうそう、そうやって使うの。$R;" +
                    "飛空庭を降りたら$R;" +
                    "まず、マーシャホットラインを$R;" +
                    "使ってみてね♪$R;" +
                    "$Pもし、マーシャホットラインを$R;" +
                    "なくしてしまったら$R;" +
                    "アクロポリスの可動橋って所に$R;" +
                    "初心者案内人さんがいるから$R;" +
                    "彼にお願いをしてみてね。$R;" +
                    "$P代わりのマーシャホットラインを$R;" +
                    "渡してくれるように$R;" +
                    "お願いしておいたから！$R;" +
                    "$Pそれと、もう一つ。$R;" +
                    "これもどうぞ！$R;", "マーシャ");
                    Say(pc, 0, 0, "それじゃあ、$R;" +
                    "アクロポリスシティまで$R;" +
                    "全速力で行くわよー！$R;" +
                    "振り落とされないように$R;" +
                    "気をつけてね！$R;", "マーシャ");
                    Warp(pc, 10071000, 245, 82);
                    break;
                    */
                    
                case 2:
                    通信機能(pc);
                    return;
                    //break;
            }
        }

        void 通信機能(ActorPC pc)
        {
        Select(pc, "使いたい機能を選んでください。", "", "ヘルプ表示　　　《困ったときはヘルプ》", "初心者掲示板　　《質問はここで》", "パーティー募集　《仲間を探そう》", "アイテム募集　　《宝物を交換しよう》", "情報募集　　　　《情報収集はここで》", "チャットルーム　《楽しいお話広場》", "メール　　　　　《手紙を渡そう》", "その他の情報　  《世界の情報など》", "通信を切る");
        Say(pc, 0, 0, "坏了....;", "瑪莎");

        /*
        Select(pc, "使いたい機能を選んでください。", "", "ヘルプ表示　　　《困ったときはヘルプ》", "初心者掲示板　　《質問はここで》", "パーティー募集　《仲間を探そう》", "アイテム募集　　《宝物を交換しよう》", "情報募集　　　　《情報収集はここで》", "チャットルーム　《楽しいお話広場》", "メール　　　　　《手紙を渡そう》", "その他の情報　  《世界の情報など》", "通信を切る");
        Say(pc, 0, 0, "坏了....;", "マーシャ");
        */
        }







    }
    }
