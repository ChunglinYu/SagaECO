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
            BitMask<Iris_1> Iris_1_mask = new BitMask<Iris_1>(pc.CMask["Iris_1"]);

            if (Iris_1_mask.Test(Iris_1.第一次对话后))
            {
                Say(pc, 131, "あら、どうしたの？$R;", "灰のコルチカ");
                switch (Select(pc, "どうする？", "", "なんでもない", "スロットを拡張する", "スロット拡張の説明を聞く", "カードアセンブルをする", "カードアセンブルの説明を聞く"))
                {
                    case 1:
                        Say(pc, 131, "スロットを増やすなら、$R;" +
                        "素材を持ってきてから話しかけてね。$R;" +
                        "当然リスクもあるんだから、$R;" +
                        "覚悟を決めてきなさいよね！$R;", "灰のコルチカ");
                        break;
                    case 2:
                        ItemAddSlot(pc);

                        break;
                    case 3:
                        switch (Select(pc, "どの説明を聞く？", "", "スロット拡張とは何か？", "何が必要なのか？", "装備のレベルと必要な素材"))
                        {
                            case 1:
                                Say(pc, 131, "装備品に、イリスカードを装着する$R;" +
                                "ためのスロットをつけることね。$R;" +
                                "スロットを増やせるのは……$R;" +
                                "$Pまずは右手を使う武器。$R;" +
                                "これは両手武器も含むわよ。$R;" +
                                "ただし、投擲武器は別。$R;" +
                                "投げちゃうからね。$R;", "灰のコルチカ");
                                Say(pc, 131, "次に、上半身部分を含む防具。$R;" +
                                "上半身だけにつけるスモックや、$R;" +
                                "上半身だけではなくて、$R;" +
                                "きぐるみのように、上半身と$R;" +
                                "それ以外の部分を持つ装備も$R;" +
                                "含むわよ。$R;", "灰のコルチカ");

                                Say(pc, 131, "最後は胸アクセサリーね。$R;" +
                                "誰でも装備できるものが多いから$R;" +
                                "結構便利に使われてるみたいよ。$R;" +
                                "$Pどこにつけるにしても、$R;" +
                                "スロットを増やすには色々と$R;" +
                                "準備が必要になるわよ。$R;" +
                                "素材とか、加工費とか。$R;" +
                                "その上で、失敗するリスクも$R;" +
                                "あることを忘れないでね。$R;", "灰のコルチカ");
                                break;
                            case 2:
                                Say(pc, 131, "おおざっぱに言うと、$R;" +
                                "$DI「想いの結晶」$CDという素材が$R;" +
                                "必要になるのよ。$R;" +
                                "$Pこれは、スロットを増やす$R;" +
                                "装備品によって少し変わってくるの。$R;" +
                                "簡単に使えるものなら、普通の$R;" +
                                "「想いの結晶」でいいんだけど……$R;" +
                                "扱いが難しくて、ある程度経験を$R;" +
                                "重ねて強くなった人じゃないと装備も$R;" +
                                "出来ないようなものだと、効果の高い$R;" +
                                "想いの結晶を使わないといけないのよ。$R;", "灰のコルチカ");

                                Say(pc, 131, "ちなみに、想いの結晶は$R;" +
                                "お店では売ってないわよ。$R;" +
                                "ジーニャ博士に頼めば、$R;" +
                                "素材を作る原料になる物も、$R;" +
                                "素材そのものも譲ってもらえるけど、$R;" +
                                "それも加工しなきゃいけないしねー。$R;", "灰のコルチカ");
                                break;
                        }
                        break;
                    case 4:
                        IrisCardAssemble(pc);
                        break;
                    case 5:
                        Say(pc, 131, "細かい理屈はわからないから、$R;" +
                        "そっちはジーニャ博士に聞いてよね。$R;" +
                        "あたいが説明できるのは、$R;" +
                        "どうやったらイリスカードを$R;" +
                        "アセンブルする事が出来るか、$R;" +
                        "ってことだけなんだからさ。$R;" +
                        "$Pまず、材料を用意しないとね。$R;" +
                        "まずは普通のイリスカードを$R;" +
                        "１０枚用意する必要があるわ。$R;" +
                        "これ、全部同じイリスカード$R;" +
                        "じゃないと、だめだからね。$R;" +
                        "$P想いの力が混ざっちゃうと$R;" +
                        "上手く重ならないどころか、$R;" +
                        "全部混ざってなくなっちゃうみたい。$R;", "灰のコルチカ");

                        Say(pc, 131, "アセンブルは、ランク１から４までの$R;" +
                        "あわせて４段階あるわ。$R;" +
                        "もちろん、何回もアセンブルした方が$R;" +
                        "効果が濃くなってるのはわかるわね？$R;" +
                        "$Pさっきも言ったけど、ランク１の$R;" +
                        "イリスカードを作るためには、$R;" +
                        "１０枚の普通のイリスカードが$R;" +
                        "必要になるの。ランク１ができたら、$R;" +
                        "そのランク１のイリスカード２枚を$R;" +
                        "材料にしてランク２のカードを作る$R;" +
                        "ことに挑戦できるようになるわ。$R;" +
                        "$Pこんな風に、$R;" +
                        "ランク２のイリスカード２枚を材料に$R;" +
                        "ランク３のイリスカードを。$R;" +
                        "ランク３のイリスカード２枚を材料に$R;" +
                        "ランク４のイリスカードを作ることが$R;" +
                        "可能になっているわ……理論上はね。$R;", "灰のコルチカ");

                        Say(pc, 131, "アセンブルするたびに、そのカードの$R;" +
                        "効果は上がっていくわ。$R;" +
                        "ぶっちゃけ、リスクはつき物だから、$R;" +
                        "必要なところまでアセンブルしたら$R;" +
                        "手を止める事だって一つの手段よ？$R;" +
                        "$Pまぁ、隣にいるバクチ好きみたいに$R;" +
                        "すっからかんになっても良いなら、$R;" +
                        "文句をつける気はないけどねー。$R;", "灰のコルチカ");

                        Say(pc, 11001975, 131, "……へっくしゅん！$R;" +
                        "ん、なんか俺の事を噂してたか？$R;", "壊し屋バキア");

                        Say(pc, 131, "ううん、なんでもないわ。$R;" +
                        "でもまぁ、なんというか……$R;" +
                        "最近、スロットの拡張もアセンブルも$R;" +
                        "果敢に挑戦する人が多いわねぇ……$R;", "灰のコルチカ");

                        Say(pc, 131, "言わなくてもわかるとは思うけど、$R;" +
                        "アセンブルもスロット拡張みたいに$R;" +
                        "失敗のリスクがあるわ。$R;" +
                        "$Pアセンブルはイリスカードそのものが$R;" +
                        "素材になるから、ほかに素材は$R;" +
                        "なくてもいいんだけど……$R;" +
                        "失敗すると、全部消えてなくなるから$R;" +
                        "覚悟だけは決めておきなさいよね！$R;" +
                        "$Pランク１のアセンブルはまだ$R;" +
                        "成功率は高い方だけど……$R;" +
                        "世の中には絶対確実なんてこと、$R;" +
                        "めったにないんだからね。$R;", "灰のコルチカ");
                        break;
                }
            }
            else
            {
                Say(pc, 11001975, 138, "いけっ！　もう一回だ！$R;" +
                "これならいける！$R;" +
                "絶対いける！$R;", "壊し屋バキア");

                Say(pc, 131, "いくわよっ！$R;" +
                "リスク高いけどいくわよっ！$R;" +
                "もう後戻りできないわよっ！$R;", "灰のコルチカ");

                Say(pc, 11001975, 158, "あぁ～～$R;" +
                "か、借り物のスタンブレイドが……$R;" +
                "また、無一文に逆戻りか～～$R;", "壊し屋バキア");

                Say(pc, 0, 0, "（……何しているんだろう？）$R;", " ");

                Say(pc, 11001975, 134, "くっそぉ～～、$R;" +
                "明日から生活どうするかなぁ。$R;", "壊し屋バキア");
                ShowEffect(pc, 11001975, 4516);

                Say(pc, 11001975, 131, "ん？$R;" +
                "なんか、俺達に用があるのか？$R;", "壊し屋バキア");
                ShowEffect(pc, 4506);

                Say(pc, 0, 0, "いや、そういうわけではなく……$R;", " ");
                ShowEffect(pc, 11001977, 4516);

                Say(pc, 131, "バキア。あんたが騒いでるからよ。$R;", "灰のコルチカ");

                Say(pc, 11001975, 210, "あぁ、そうか。$R;" +
                "いや、悪い悪い。ついつい$R;" +
                "熱くなっちまってな～。$R;" +
                "$Pなんと言うのか、こう……$R;" +
                "男だったら、危険とわかっていても$R;" +
                "挑まなければならない時ってものが$R;", "壊し屋バキア");

                Say(pc, 131, "何言ってるのよバキア、$R;" +
                "あんたのはただのバクチでしょ。$R;" +
                "そもそも、やる前にちゃんと$R;" +
                "成功する確率は低いって言ったわよ。$R;" +
                "$Pやめた方がいいって言ってるのに、$R;" +
                "そもそも何度も失敗してるのに、$R;" +
                "どれだけ自分の運に自信があるのよ。$R;", "灰のコルチカ");

                Say(pc, 11001975, 131, "それほどでもない。$R;", "壊し屋バキア");

                Say(pc, 131, "……ま、自分の責任なんだから、$R;" +
                "無一文になろうが、$R;" +
                "深い悲しみに包まれようが、$R;" +
                "あたいは止めやしないけどね。$R;" +
                "$Pって、ごめんごめん。$R;" +
                "君を置き去りにしちゃったね。$R;" +
                "あたいはコルチカ。$R;" +
                "そこの赤毛の馬鹿はバキアよ。$R;", "灰のコルチカ");

                Say(pc, 11001975, 131, "え、何してたのかって？$R;" +
                "……まぁ、お前さんなら良いか。$R;" +
                "お前さん、たしか冒険者の$R;" +
                "夢の欠片だろ？$R;" +
                "名前くらいは知ってるぜ。$R;", "壊し屋バキア");

                Say(pc, 11001975, 131, "イリスカードって知ってるかい？$R;" +
                "何でも、誰かや何かに対する$R;" +
                "“想いの力”がカードになった$R;" +
                "物らしい。$R;" +
                "$P細かい理屈は俺にはわからないが、$R;" +
                "まずは武器や防具を加工して$R;" +
                "カードをつけることが$R;" +
                "できるようにする。$R;" +
                "$Pで、カードをつけると、その装備が$R;" +
                "フシギな力で強くなるんだ。$R;", "壊し屋バキア");

                Say(pc, 0, 0, "フシギな力？$R;", " ");

                Say(pc, 131, "実際にどんな理屈なのかは、$R;" +
                "博士に聞いた方がいいよ。$R;", "灰のコルチカ");

                Say(pc, 11001975, 131, "そうだな……俺たちが言うよりは、$R;" +
                "専門家に任せるのが一番か。$R;", "壊し屋バキア");

                Say(pc, 0, 0, "で、さっきのは一体……$R;", " ");

                Say(pc, 11001975, 361, "あぁ……$R;" +
                "さっき、装備を加工して……って$R;" +
                "言ったろ？$R;" +
                "$Pそもそもこのカードに関する$R;" +
                "研究もまだ終わってないんだ。$R;" +
                "で、当然その加工は、やっぱり$R;" +
                "失敗する事もあるわけで……$R;", "壊し屋バキア");

                Say(pc, 131, "最初のうちはまだ成功しやすいの。$R;" +
                "だけど、常に失敗の可能性はあるし$R;" +
                "３回目くらいからは結構危ないわよ。$R;" +
                "$Rで、失敗すると……$R;", "灰のコルチカ");

                Say(pc, 11001975, 158, "俺みたいに装備を全部、きれいに$R;" +
                "ぶっ壊してしまうってわけさ。$R;", "壊し屋バキア");

                Say(pc, 11001975, 134, "あぁっ！　もういい！$R;" +
                "そんな過去は忘れよう！$R;" +
                "俺達は未来を見るべきだろう！$R;" +
                "もっと前向きにいくべきだ！$R;", "壊し屋バキア");

                Say(pc, 131, "過去に学ぶべき事も多いわよ？$R;" +
                "$P例えば、リスクの高い賭けは$R;" +
                "失敗すると辛いとか。$R;" +
                "$R借り物の装備を勝手に壊して$R;" +
                "友達から怒られるとか。$R;", "灰のコルチカ");
                ShowEffect(pc, 11001975, 4506);

                Say(pc, 11001975, 131, "いや、ソレはだなぁ……$R;" +
                "$Pほ、ほらっ、なんだ。$R;" +
                "人を待たせるのも悪いからな、$R;" +
                "早いところ行こうぜ。$R;" +
                "$P悪いが、場所は故あって$R;" +
                "明らかに出来ないんだ。$R;" +
                "混成騎士団にも黙っててくれよ？$R;" +
                "案内するから、ついてきてくれ。$R;", "壊し屋バキア");
                Warp(pc, 30166000, 9, 16);
                Iris_1_mask.SetValue(Iris_1.第一次对话后, true);
            }

        }
    }
}
