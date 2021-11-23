﻿using System;
using System.Collections.Generic;
using System.Text;

using SagaDB.Actor;
using SagaMap.Scripting;

using SagaLib;
using SagaScript.Chinese.Enums;
namespace SagaScript.M30166000
{
    public class S11001972 : Event
    {
        public S11001972 ()
        {
            this.EventID = 11001972;
        }

        public override void OnEvent(ActorPC pc)
        {
            BitMask<Iris_1> Iris_1_mask = new BitMask<Iris_1>(pc.CMask["Iris_1"]);
            //int selection;
            if (Iris_1_mask.Test(Iris_1.博士))
            {
                if (Iris_1_mask.Test(Iris_1.博士2))
                {

                    Say(pc, 131, "あ……$R;" +
                    "あの……$R;" +
                    "" + pc.Name + "さん……$R;" +
                    "お疲れ様……です……$R;" +
                    "ごようは……？$R;", "ジーニャ博士");
                   switch (Select(pc, "どうする？", "", "素材が……欲しい", "……話を聞きたい", "カードを保管したい", "特にないです……"))
                   {
                       case 1:
                           switch (Select(pc, "どうする？", "", "説明を聞く", "素材を購入する"))
                           {
                               case 1:
                                   Say(pc, 131, "素材には「一次材料」と$R;" +
                                   "「二次素材」があります。$R;" +
                                   "一次材料は、虹の力を切り取った$R;" +
                                   "だけの本当の材料です。$R;" +
                                   "$Pあ……虹の力といっても、$R;" +
                                   "仮にそう呼んでいるだけです。$R;" +
                                   "詳しく説明するのも難しいですが$R;" +
                                   "実際に効果があることは保障します。$R;" +
                                   "$P一次材料はそれなりに安価では$R;" +
                                   "ありますけど、自分か誰かに頼んで、$R;" +
                                   "二次素材に加工してもらわないと$R;" +
                                   "いけないので、手間がかかります。$R;", "ジーニャ博士");

                                   Say(pc, 131, "一次材料を加工することで$R;" +
                                   "二次素材が精製されます。$R;" +
                                   "$DI虹石$CDからは$DIハートストーン$CDが、$R;" +
                                   "$DI虹枝$CDからは$DI想い出箱$CDが、$R;" +
                                   "$DI虹水$CDからは$DIイリスリキッド$CDが$R;" +
                                   "精製されます。$R;" +
                                   "$P上級のアイテムは加工の為に$R;" +
                                   "より強力な素材を使う必要があります。$R;" +
                                   "「大きな」と書かれた素材は二番目、$R;" +
                                   "「真実の」と書かれた素材が$R;" +
                                   "最も強力な素材になります。$R;", "ジーニャ博士");

                                   Say(pc, 131, "これは一次材料も、二次素材も$R;" +
                                   "同じ扱いになります。$R;" +
                                   "大きいが真ん中で、真実は一番強いと$R;" +
                                   "いうのは確定的に明らかです。$R;" +
                                   "$R二次素材を加工することで、$R;" +
                                   "スロットを拡張するために必要な$R;" +
                                   "想いの結晶を精製出来ます。$R;" +
                                   "$Pこの結晶を使うことで、装備品に$R;" +
                                   "イリスカードをつけるスロットが$R;" +
                                   "増やせるようになります。$R;", "ジーニャ博士");

                                   Say(pc, 131, "……とは言っても、必ずスロットを$R;" +
                                   "増やせるわけではありません。$R;" +
                                   "この加工は、元々心を持たない装備に$R;" +
                                   "かりそめの心を与えるようなものです。$R;" +
                                   "$Pマリオネットに心を与えると$R;" +
                                   "ゴーレムになることはご存知ですか？$R;" +
                                   "この技術はそれと同じように、$R;" +
                                   "装備に心を持たせることで、$R;" +
                                   "装備が想いを持てるようにするんです。$R;", "ジーニャ博士");


                                   break;
                               case 2:
                                   switch (Select(pc, "どちらの素材にする？", "", "「一次材料」", "「二次素材」"))
                                   {
                                       case 1:
                                           OpenShopBuy(pc, 270);
                                           break;
                                       case 2:
                                           OpenShopBuy(pc, 271);
                                           break;
                                   }
                                   break;

                           }

                           break;
                       case 2:
                           switch (Select(pc, "どうする？", "", "あなたは誰？", "この研究所は何？", "イリスカードって何", "想いの力の研究って何？", "この研究の歴史について", "カードのアセンブルとは？"))
                           {
                               case 1:
                                   ShowEffect(pc, 11001972, 4506);

                                   Say(pc, 131, "……！$R;" +
                                   "$P……ご、ごめんなさい……$R;" +
                                   "ま……まだ言ってなかったですか。$R;" +
                                   "わたしは、ジーニャといいます……$R;" +
                                   "この研究所の主任研究者で、$R;" +
                                   "一人だけの職員……です。$R;" +
                                   "$Pこの分野は研究している$R;" +
                                   "人が少ないので……$R;" +
                                   "まだ未熟ですけど……$R;" +
                                   "精一杯やらせていただいてます。$R;", "ジーニャ博士");

                                   Say(pc, 0, 0, "元々、イリスカードの$R;" +
                                   "研究をしていたの？$R;", " ");

                                   Say(pc, 131, "……あ、すいません……$R;" +
                                   "そうではなく……$R;" +
                                   "わたしは、元々人の心の働きを$R;" +
                                   "研究していたのですが……$R;" +
                                   "$Pイリスレポートが発掘された$R;" +
                                   "際に、レポートを調査していた$R;" +
                                   "クォーク博士から協力を依頼されて$R;" +
                                   "……手伝っていたら$R;" +
                                   "……いつの間にか、専門の……$R;" +
                                   "研究員になっていました……$R;", "ジーニャ博士");

                                   Say(pc, 131, "その……あの……$R;" +
                                   "すいません……$R;" +
                                   "こんないいかげんな事情で……$R;", "ジーニャ博士");
                                   break;
                               case 2:
                                   Say(pc, 131, "……この研究所はアクロポリスの$R;" +
                                   "地下に隠されています。$R;" +
                                   "目的は、先日エレキテルラボで$R;" +
                                   "発掘された、資源戦争時代の書物$R;" +
                                   "「イリスレポート」を研究し、その$R;" +
                                   "研究内容を世に広めること……です。$R;", "ジーニャ博士");

                                   Say(pc, 131, "ギルド元宮からある程度の$R;" +
                                   "援助を受けていますが、ギルド公認の$R;" +
                                   "組織と言うわけではありません。$R;" +
                                   "$P前に言いましたが、一つの国が$R;" +
                                   "この技術を独占できないように、$R;" +
                                   "今のうちに多くの人にこの技術を$R;" +
                                   "知って、利用してもらうことが$R;" +
                                   "わたしたちの狙いです。$R;", "ジーニャ博士");

                                   Say(pc, 131, "そのため、いまだに正式な名前は$R;" +
                                   "ありません……イリスカードの研究を$R;" +
                                   "しているのではなく、研究の結果$R;" +
                                   "イリスカードを利用できただけなのに、$R;" +
                                   "バキアさんたちはここをカードラボと$R;" +
                                   "呼んでいます……。$R;", "ジーニャ博士");

                                   Say(pc, 131, "アクロニア地下探索研究所が、$R;" +
                                   "みんなからエレキテルラボラトリーと$R;" +
                                   "呼ばれているので、その名前に$R;" +
                                   "あわせた呼び名になってしまいました。$R;" +
                                   "$P近いと言えば近いのですが、$R;" +
                                   "あちらにご迷惑をかけるわけには$R;" +
                                   "行きませんので……$R;" +
                                   "その……同じ研究なのだとは$R;" +
                                   "思わないで……下さい……$R;", "ジーニャ博士");
                                   break;
                               case 3:
                                   Say(pc, 131, "世界に散らばった「想いの力」が$R;" +
                                   "薄い板状の形に固まったもの……$R;" +
                                   "というのが近い……と思います。$R;" +
                                   "$Pもともと、この世界には想いの力が$R;" +
                                   "物質になるという事があります。$R;" +
                                   "かなり稀ではあるんですが……$R;" +
                                   "$Pアクロポリスのおとぎ話に、$R;" +
                                   "大事な人や、大切な出来事の思い出は$R;" +
                                   "いつかきれいな星になって自分に$R;" +
                                   "かえってくる、というものがあります。$R;", "ジーニャ博士");

                                   Say(pc, 131, "遺跡の島であるマイマイには、$R;" +
                                   "先祖代々の心を受け継ぐ仮面があり、$R;" +
                                   "それを守る一族がいる……$R;" +
                                   "なんていう話があります。$R;" +
                                   "$Pこのように、普通は見る事も$R;" +
                                   "出来ない「誰かを想う心」が実際に$R;" +
                                   "形を取って存在するということは、$R;" +
                                   "確証を得られないまでも、うわさ話や$R;" +
                                   "おとぎ話の中に存在しています。$R;", "ジーニャ博士");

                                   Say(pc, 131, "イリスカードは、その想いの力が$R;" +
                                   "結晶化したものと考えてください。$R;" +
                                   "水が冷たいところで氷になるように、$R;" +
                                   "想いの力はなんらかの条件で板……$R;" +
                                   "というか、カードのような形になる$R;" +
                                   "事がわかったんです。$R;" +
                                   "$Pでも、カードとは言っても、$R;" +
                                   "これはまだ不安定な状態です。$R;" +
                                   "しっかりと保管しておかないと、$R;" +
                                   "氷が解けてしまうように、カードは$R;" +
                                   "いつの間にかなくなってしまいます。$R;", "ジーニャ博士");

                                   Say(pc, 131, "倉庫などしまっておく分には、$R;" +
                                   "あまり問題はないみたいですが……$R;" +
                                   "装備につけて使っていると、$R;" +
                                   "消えてしまうことが多いようです。$R;" +
                                   "$P装備品につけたイリスカードが$R;" +
                                   "なくならないようにするためには、$R;" +
                                   "装備品のスロットからカードが$R;" +
                                   "落ちてしまわないよう、スロットに$R;" +
                                   "鍵をかけておく必要があります。$R;", "ジーニャ博士");

                                   Say(pc, 131, "この鍵をかける処理を、今は$R;" +
                                   "スロットロックと呼んでいます。$R;" +
                                   "$Rスロットロックを行うのは$R;" +
                                   "容易なのですが……$R;" +
                                   "……一度ロックしてしまうと$R;" +
                                   "イリスカードが……$R;" +
                                   "取り外せなく……なります$R;" +
                                   "……注意して……ください。$R;", "ジーニャ博士");
                                   break;
                               case 4:
                                   Say(pc, 131, "あなたは……$R;" +
                                   "誰かを想ったことや……$R;" +
                                   "何かについて……ずっと考えたり$R;" +
                                   "悩んだりしたことはないですか？$R;" +
                                   "$P想いの力というのは……$R;" +
                                   "そう、想いの力は、$R;" +
                                   "人の心がいつも生み出している$R;" +
                                   "「誰か」「何か」を想う、$R;" +
                                   "その気持ちのことなのです。$R;", "ジーニャ博士");

                                   Say(pc, 131, "本来、それらの想いと言う物は$R;" +
                                   "手を触れることが出来ませんよね。$R;" +
                                   "でも、触れることが出来ないから$R;" +
                                   "といって、その想いが存在しない$R;" +
                                   "なんて、誰も言いませんよね。$R;" +
                                   "$P誰かを好きになることや、$R;" +
                                   "誰かを守りたいと考えること。$R;" +
                                   "誰かに勝ちたいと考えることや、$R;" +
                                   "何かを達成したいと願うこと。$R;" +
                                   "これらの心の動きは、現実世界で$R;" +
                                   "計測できるものではありません。$R;", "ジーニャ博士");

                                   Say(pc, 131, "でも、その気持ちは実際に$R;" +
                                   "結果に影響を与えます。$R;" +
                                   "気のせいとも、気の持ちようとも$R;" +
                                   "言いますが……気の持ちようによって$R;" +
                                   "何らかの変化が……$R;" +
                                   "何らかの影響があるということは、$R;" +
                                   "みんな薄々気がついているんです。$R;", "ジーニャ博士");

                                   Say(pc, 131, "例えば……ファーマーさんたちが$R;" +
                                   "丹精込めて作った作物と、$R;" +
                                   "捨てられた種が偶然育った作物では、$R;" +
                                   "作物の大きさや、味の良さが違う……$R;" +
                                   "などというのも、その一つです。$R;" +
                                   "$P気のせいかもしれないけど、$R;" +
                                   "気のせいではない結果が出る事もある。$R;" +
                                   "そういった現象を起こすのが、$R;" +
                                   "想いの力なのです。$R;" +
                                   "……まだ、ある程度は仮説ですけど。$R;", "ジーニャ博士");
                                   break;
                               case 5:
                                   Say(pc, 131, "はるか昔、まだアクロニアに$R;" +
                                   "大きな王国がいくつかあった頃。$R;" +
                                   "エミルの国々は互いに争っていました。$R;" +
                                   "$P高い技術を持っていたという国や、$R;" +
                                   "アクロポリスを中心とした、$R;" +
                                   "アクロニア王国と言う大きい国が$R;" +
                                   "ありました。$R;", "ジーニャ博士");

                                   Say(pc, 131, "世界に残された資源を取り合って$R;" +
                                   "起きた戦争は、当時は資源戦争と$R;" +
                                   "呼ばれていました。$R;" +
                                   "$P資料を見せてもらった限りでは、$R;" +
                                   "その戦争のさなかにタイタニアや$R;" +
                                   "ドミニオンの世界との交流が……$R;" +
                                   "……初期は、争いと言う形で……$R;" +
                                   "始まったようです。$R;", "ジーニャ博士");

                                   Say(pc, 131, "新しい世界の資源を求め、$R;" +
                                   "天まで続く塔、あるいは$R;" +
                                   "地深く潜る回廊と呼ばれる$R;" +
                                   "建造物が作られたのがそもそもの$R;" +
                                   "きっかけだと思われます。$R;" +
                                   "$Pこれらの建造物が現存するのか、$R;" +
                                   "違うものなのか、同じものなのか、$R;" +
                                   "今ではわからないのですが……$R;" +
                                   "こちらは、わたしの研究ではないので$R;" +
                                   "詳しいことはわかりません。$R;", "ジーニャ博士");

                                   Say(pc, 131, "話を戻しますが、想いの力の$R;" +
                                   "研究と言うのは、この資源戦争の$R;" +
                                   "時代に始まったもののようです。$R;" +
                                   "研究を進めていたのは、イリス博士。$R;" +
                                   "$Pノーザン地方出身の女性としか$R;" +
                                   "記録が残っていません。$R;", "ジーニャ博士");

                                   Say(pc, 131, "イリス博士の研究は、戦争のための$R;" +
                                   "新しいエネルギーとして期待されて$R;" +
                                   "いたようです。$R;" +
                                   "本来、資源が足りなくなったから$R;" +
                                   "戦争になったのに、戦争のために$R;" +
                                   "新しい資源の研究が行われるのは$R;" +
                                   "悲しいことですが……$R;" +
                                   "$P想いの力は、機械や兵器を動かす$R;" +
                                   "ための動力としては使えないという$R;" +
                                   "ことがわかって、研究は凍結します。$R;" +
                                   "戦争の役に立たない研究に予算は$R;" +
                                   "出ないということだったんでしょう。$R;", "ジーニャ博士");

                                   Say(pc, 131, "ですが、資源戦争の後期には再び$R;" +
                                   "研究が再開しています。$R;" +
                                   "資料には「心持たぬ敵に対抗する」$R;" +
                                   "なんていう言葉が残されているの$R;" +
                                   "ですが、これが何を示しているのかは$R;" +
                                   "まだわかりません……。$R;" +
                                   "$Pとにかく、研究は再開しました。$R;" +
                                   "イリス博士という方はいわゆる天才$R;" +
                                   "だったらしく、マリオネットの研究、$R;" +
                                   "機械の研究、魔術に関する知識を$R;" +
                                   "兼ね備え、色々な分野に手を出して$R;" +
                                   "いたことがうかがえます。$R;", "ジーニャ博士");

                                   Say(pc, 131, "そこで研究されていたのは、$R;" +
                                   "大きく分けて三つ。$R;" +
                                   "想いの力を実体化させる事、$R;" +
                                   "想いの力を燃料として利用すること、$R;" +
                                   "想いの力を物質に付与すること。$R;" +
                                   "$P一つ目は、理論だけ出来ていて$R;" +
                                   "実験が出来ていなかった状態でした。$R;" +
                                   "二つ目は無理だとわかったのか、$R;" +
                                   "研究は早々と破棄されました。$R;" +
                                   "三つ目が、当時から完成が近く、$R;" +
                                   "この研究所で実用化されたものです。$R;", "ジーニャ博士");

                                   Say(pc, 131, "想いの力の実体化とは、$R;" +
                                   "今はイリスカードの実体化と$R;" +
                                   "同じ意味になります。他の例が、$R;" +
                                   "まだ確認できていないためです。$R;" +
                                   "$Pこれはまだ推測なのですが、$R;" +
                                   "想いの力がとても強ければ、$R;" +
                                   "何もないところに、何か作り出す事も$R;" +
                                   "可能なのではないかと思うんです。$R;" +
                                   "$P例えば……幽霊なんていうのも、$R;" +
                                   "誰かの残された想いが、その場所に$R;" +
                                   "取り残されてしまったものと$R;" +
                                   "考えることは出来ませんか？$R;", "ジーニャ博士");

                                   Say(pc, 131, "話がそれてしまいました。$R;" +
                                   "想いの力を付与するというのは、$R;" +
                                   "心を持たない物体に心を与える$R;" +
                                   "というような事だと思ってください。$R;" +
                                   "$Pマリオネットに乗り移ったり、$R;" +
                                   "装備に憑依をおこなうことと、$R;" +
                                   "意味合い的には近いですね。$R;" +
                                   "ただ、その対象が違うだけです。$R;" +
                                   "$P貴方がマリオネットに$R;" +
                                   "乗り移るのは、あなたと言う心が$R;" +
                                   "マリオネットと言う器に入る、$R;" +
                                   "ということです。$R;", "ジーニャ博士");
                                   break;
                               case 6:
                                   Say(pc, 131, "……あ、はい……$R;" +
                                   "想いの力が集まってできた$R;" +
                                   "イリスカードは、物質であり、$R;" +
                                   "なおかつ非物質でもあると……$R;" +
                                   "$Pあ、いえ、すいません。$R;" +
                                   "詳細な説明は省きますが……$R;" +
                                   "イリスカードは、複数枚をまとめて$R;" +
                                   "一枚にすることができます。$R;" +
                                   "$Pこれには条件があります。$R;" +
                                   "まず、まとめることができるのは$R;" +
                                   "同一の種類のイリスカードだけです。$R;" +
                                   "プルルのカードならば、それだけを$R;" +
                                   "集めてこないといけません。$R;", "ジーニャ博士");

                                   Say(pc, 131, "はい、これは同じ種類の想いの力を$R;" +
                                   "精製して、一枚のカードにまとめる$R;" +
                                   "という作業になります。$R;" +
                                   "$P想いの力の純度が高まっていく、$R;" +
                                   "という表現の方がいいでしょうか。$R;" +
                                   "$Pたいていは、そのイリスカードが$R;" +
                                   "もともと持っている力が強くなる$R;" +
                                   "のですが……もしかしたら新しい$R;" +
                                   "力を発現させたりすることも$R;" +
                                   "あるのかもしれません。$R;" +
                                   "$Pこれを、現在私たちは$R;" +
                                   "カードアセンブルと呼んでいます。$R;", "ジーニャ博士");

                                   Say(pc, 131, "最初は１０枚のイリスカードを$R;" +
                                   "まとめたカードを作ます。$R;" +
                                   "この第一段階のカードを、いまは$R;" +
                                   "「ランク１」と呼んでいます。$R;" +
                                   "$Pランク１のカードを２枚使うことで$R;" +
                                   "また新しいカードにできます。$R;" +
                                   "これを「ランク２」と呼びます。$R;" +
                                   "同様に、ランク２を２枚でランク３、$R;" +
                                   "ランク３を２枚で、ランク４に。$R;" +
                                   "$P理論的には、ランク４が最大に$R;" +
                                   "なるはずです……。$R;" +
                                   "それでも、充分に強力な効果を$R;" +
                                   "発揮すると思います。$R;", "ジーニャ博士");

                                   Say(pc, 131, "これだけ聞けば、凄くよい事のように$R;" +
                                   "思えるとは思うのですけれど……$R;", "ジーニャ博士");

                                   Say(pc, 0, 131, "あ、もしかしてやっぱり……$R;", " ");
                                   ShowEffect(pc, 4506);

                                   Say(pc, 131, "はい……$R;" +
                                   "$Pもともと、壊れやすい物ですし$R;" +
                                   "精製してまとめる時に壊れてしまう$R;" +
                                   "ことも多数有ります……$R;" +
                                   "というか……その、苦手で……$R;" +
                                   "やり方はわかるんですけど、$R;" +
                                   "自分では今まで一度も……$R;", "ジーニャ博士");

                                   Say(pc, 131, "コルチカさんなら、それなりに$R;" +
                                   "うまく行く事があるんですけど……$R;" +
                                   "$P私は理論はわかるんですけど、$R;" +
                                   "手を動かすのはどうにも苦手で。$R;" +
                                   "実際にアセンブルを行うのは$R;" +
                                   "アイテム精製のスキルの高い$R;" +
                                   "冒険者さんのほうが上手く行くと$R;" +
                                   "思います……$R;" +
                                   "$Pごめんなさい、わたし、$R;" +
                                   "お料理とかお裁縫とか苦手で……$R;", "ジーニャ博士");

                                   break;
                           }
                           break;
                       case 3:
                           if (Iris_1_mask.Test(Iris_1.卡包))
                           {

                               Say(pc, 131, "……え……はい。$R;" +
                               "持ってませんでしたっけ……$R;" +
                               "ご、ごめんなさい。$R;" +
                               "必要ならばお譲りしますが、$R;" +
                               "二つ目は有料となってしまいます……$R;" +
                               "10000goldかかるけど、$R;" +
                               "大丈夫ですか……？$R;", "ジーニャ博士");
                               if (Select(pc, "カードホルダーを買う？", "", "買う", "買わない") == 1)
                               {
                                   if (pc.Gold > 9999)
                                   {
                                       pc.Gold -= 10000;
                                       GiveItem(pc, 31163400, 1);
                                       return;
                                   }
                                   else
                                   {
                                       Say(pc, 131, "啊……$R;" +
                                       "錢不夠……$R;", "ジーニャ博士");
                                       return;
                                   }
                               }
                           }
                           Say(pc, 131, "あ……はい。$R;" +
                           "イリスカードは、実体があるとも$R;" +
                           "ないとも言えるフシギな存在です。$R;" +
                           "その為、倉庫などに入れる事も$R;" +
                           "出来るようですが、専用の$R;" +
                           "保管道具があります……$R;", "ジーニャ博士");

                           Say(pc, 131, "これは、執事をしてくれている$R;" +
                           "ハレルヤが持ってきてくれた本なの$R;" +
                           "ですが……この本には特殊な処理を$R;" +
                           "おこなってあり、イリスカードを$R;" +
                           "この中に保管することが出来ます。$R;" +
                           "$Pちょっとサイズが大きいから$R;" +
                           "普段持ち歩いて使うことは$R;" +
                           "出来ません……$R;" +
                           "飛空庭においてくださいね。$R;", "ジーニャ博士");

                           Say(pc, 131, "この本は、ある意味心を移す$R;" +
                           "鏡のようなものです。$R;" +
                           "他人からこの本を受け取っても、$R;" +
                           "他人の持っているイリスカードは$R;" +
                           "見えないし、取り出せません。$R;" +
                           "$Pどうやっても、自分の持っている$R;" +
                           "イリスカードしかみる事も、$R;" +
                           "取り出す事も出来ないようです。$R;", "ジーニャ博士");

                           Say(pc, 131, "せっかくですので、$R;" +
                           "一つお渡ししておきますね。$R;", "ジーニャ博士");
                           PlaySound(pc, 2030, false, 100, 50);

                           Say(pc, 0, 131, "『カードホルダー』を貰った。$R;", " ");
                           GiveItem(pc, 31163400, 1);
                           Iris_1_mask.SetValue(Iris_1.卡包, true);
                           break;
                       case 4:
                           Say(pc, 131, "あ……はい$R;" +
                           "……ごめんなさい……$R;", "ジーニャ博士");
                           break;
                   }
                   return;
                }
                Say(pc, 131, "では……改めて説明します。$R;" +
                "よろしいですか……？$R;", "ジーニャ博士");
                switch (Select(pc, "説明を聞きますか？", "", "いいですよ！", "いやです"))
                {
                    case 1:
                        Say(pc, 131, "ありがとうございます……$R;" +
                        "$Pまず……は……$R;" +
                        "$Pまずは、どう利用できるのか$R;" +
                        "と言う実践の部分から説明します。$R;", "ジーニャ博士");

                        Say(pc, 0, 0, "（説明になると人が変わるんだ……）$R;", " ");

                        Say(pc, 131, "先ほども言いましたが、$R;" +
                        "この研究所では想いの力の$R;" +
                        "研究をしています。その研究の$R;" +
                        "成果が$DHイリスカード$CDです。$R;" +
                        "$P世界中に満ちている想いの力を$R;" +
                        "集めて、カードの形に結晶化させる、$R;" +
                        "と言えばわかりやすいでしょうか。$R;" +
                        "その想いの力の結晶の事を$R;" +
                        "イリスカードと呼びます。$R;", "ジーニャ博士");

                        Say(pc, 131, "イリスカードはそのままでは$R;" +
                        "ただのカードに過ぎません。$R;" +
                        "ある手法を使って装備品を加工し、$R;" +
                        "イリスカードを付与可能にします。$R;" +
                        "$Pこのある手法と言うものは、$R;" +
                        "装備品と心を通わせるというか、$R;" +
                        "装備品に心を持たせるというべきか。$R;" +
                        "説明は必要ならば後で行いますが、$R;" +
                        "やり方はコルチカさんが知っています。$R;", "ジーニャ博士");

                        Say(pc, 131, "カードを付与可能にしたら、$R;" +
                        "そこにイリスカードを挿し込みます。$R;" +
                        "利用するための手順はこれだけです。$R;" +
                        "$P想いの力は色々な種類があります。$R;" +
                        "近い方向性を持つカードを増やせば、$R;" +
                        "その力は重なって、より大きな力に$R;" +
                        "なるだろうと思われます。$R;" +
                        "$Pこの研究も技術もまだ未完成で、$R;" +
                        "安定しているともいえません。$R;" +
                        "それでも、この技術はきっと、$R;" +
                        "あなたたちの冒険の手助けになると$R;" +
                        "思われます。$R;", "ジーニャ博士");

                        Say(pc, 131, "さて、これで一旦説明は終わりです。$R;" +
                        "装備品にカードを持たせる事に$R;" +
                        "ついては、コルチカさんに。$R;" +
                        "イリスカードの入手方法は……$R;" +
                        "バキアさんが良く入手されている$R;" +
                        "ようですので、話を聞いてみると$R;" +
                        "よいのではないかと思います。$R;" +
                        "$P装備品の加工に必要な素材に$R;" +
                        "関しては、わたしが管理しています$R;" +
                        "……なので、必要に応じて$R;" +
                        "お分けします……$R;", "ジーニャ博士");
                        ShowEffect(pc, 11001972, 4506);

                        Say(pc, 131, "あ、あの……$R;" +
                        "話が長くなってしまって……$R;" +
                        "ごめんなさい……。$R;", "ジーニャ博士");
                        Iris_1_mask.SetValue(Iris_1.博士2, true);
                        break;
                    case 2:
                        Say(pc, 131, "……ごめんなさい……$R;" +
                        "あの……説明を聞ける$R;" +
                        "……時間が、できたら……$R;" +
                        "わたしに……その……$R;" +
                        "……ごめんなさい。$R;", "ジーニャ博士");
                        Iris_1_mask.SetValue(Iris_1.博士2, true);
                        break;
                }
                return;
            }
            Say(pc, 131, "あ……。$R;" +
            "冒険者の、方ですか……？$R;", "ジーニャ博士");

            Say(pc, 0, 0, "そうですけど……$R;", " ");
            ShowEffect(pc, 11001972, 4506);

            Say(pc, 131, "あ、その。ごめんなさい。$R;" +
            "いきなり……こんな所に$R;" +
            "つれてこられて……$R;" +
            "お……怒ってます……？$R;", "ジーニャ博士");

            Say(pc, 0, 0, "いや、別に……$R;", " ");

            Say(pc, 131, "ごめんなさい……$R;" +
            "何から説明すればいいか……$R;" +
            "$Pまず、ここはイリスカードの$R;" +
            "研究をしている……研究所です。$R;", "ジーニャ博士");

            Say(pc, 0, 0, "$DHイリスカード$CD？$R;", " ");

            Say(pc, 131, "はい……耳慣れない言葉かと$R;" +
            "思いますが……少しお時間を$R;" +
            "いただきます……。$R;" +
            "$Pまず……この研究所は$R;" +
            "……現在、混成騎士団などの$R;" +
            "国家に関わる機関に対しては$R;" +
            "知られないように運営されています。$R;", "ジーニャ博士");

            Say(pc, 0, 0, "え、何か、まずいことを？$R;", " ");
            ShowEffect(pc, 11001972, 4506);

            Say(pc, 131, "あ……ごめんなさい。$R;" +
            "その……軍事利用されるから……$R;", "ジーニャ博士");
            ShowEffect(pc, 4506);

            Say(pc, 0, 0, "軍事利用！？$R;", " ");

            Say(pc, 11001974, 131, "……差し出がましいようですが、$R;" +
            "わたくしから説明させて$R;" +
            "いただけますでしょうか。$R;", "夢見のハレルヤ");

            Say(pc, 0, 0, "（え、どこから声が？）$R;", " ");
            ShowEffect(pc, 11001972, 4506);

            Say(pc, 131, "部屋の端にいる……$R;" +
            "ハレルヤの声です。$R;" +
            "今は私の仕事を……$R;" +
            "手伝ってくれています。$R;" +
            "$Pフシギな力を持っている$R;" +
            "様ですが……いい人です……。$R;", "ジーニャ博士");

            Say(pc, 11001974, 131, "突然の口出し、申し訳ありません。$R;" +
            "先ず、この研究所はギルド元宮の$R;" +
            "ギルド長、ルーラン様の援助を$R;" +
            "受けて運営されております。$R;", "夢見のハレルヤ");

            Say(pc, 0, 0, "ギルド元宮の？$R;", " ");

            Say(pc, 11001974, 131, "さようでございます。$R;" +
            "地下探索研究所……$R;" +
            "いわゆるエレキテルラボラトリー$R;" +
            "同様に、この研究が生み出す物が$R;" +
            "軍事的な利用が可能と思われるため、$R;" +
            "特定国家による独占を防ぐべく……$R;", "夢見のハレルヤ");

            Say(pc, 131, "そこからは……わたしが話します。$R;" +
            "$Pまず、遥か昔のことです。$R;" +
            "その頃、この世界では有限の$R;" +
            "資源をめぐって、いろいろな国で$R;" +
            "戦争が起きていました。$R;" +
            "$Pアクロニアにはかつて$R;" +
            "アクロニア王国という国家や$R;" +
            "高い技術を持っていたといわれる国が。$R;" +
            "今では全て失われているのですが……$R;", "ジーニャ博士");

            Say(pc, 0, 0, "（長い話になりそうだ……）$R;", " ");

            Say(pc, 131, "あ……ごめんなさい。$R;" +
            "研究のことになると……話をどこで$R;" +
            "止めていいかわからなくて……$R;" +
            "$P話を大幅に省略しますが……$R;" +
            "その研究は、想いの力を利用して$R;" +
            "新しいエネルギーにしよう、$R;" +
            "と言うものだったようです。$R;", "ジーニャ博士");

            Say(pc, 131, "暖炉に火をつけるためには、$R;" +
            "普通は火と薪が必要です。$R;" +
            "魔法を使って火をつけることも$R;" +
            "出来ますが、魔力も減ってしまいます。$R;" +
            "$Pそこで着目されたのが想いの力$R;" +
            "による、尽きないエネルギーです。$R;" +
            "でも、その研究は完成することはなく$R;" +
            "中断されてしまいました。$R;", "ジーニャ博士");

            Say(pc, 0, 0, "研究はうまくいかなかったの？$R;", " ");

            Say(pc, 131, "いろいろと苦労はあったようですが$R;" +
            "研究は途中まで進んでいました。$R;" +
            "中断した理由は別にあります。$R;" +
            "$P戦争で、研究施設があった$R;" +
            "アクロポリスシティが攻撃され、$R;" +
            "都市が滅びてしまったのです。$R;", "ジーニャ博士");

            Say(pc, 0, 0, "……！$R;", " ");

            Say(pc, 131, "エレキテルラボで発掘された資料は$R;" +
            "資料の記載者の名前から$R;" +
            "「イリスレポート」として保管され、$R;" +
            "ここで研究が行われました。$R;" +
            "その結果、過去には不可能だった$R;" +
            "想いの力の実用化が……$R;" +
            "一部ですが、可能になっています。$R;" +
            "$P本来、想いの力と言うものが$R;" +
            "何かを説明すべきなのですが、$R;" +
            "まずは何が出来るかを説明します。$R;" +
            "$Pわたしたちは「想いの力」を$R;" +
            "一時的に物質にして、装備品に$R;" +
            "付与することができます。$R;", "ジーニャ博士");

            Say(pc, 131, "例えば「強くなりたい」という$R;" +
            "想いを強く持っていた場合、$R;" +
            "その想いは「強くなる」という$R;" +
            "想いの方向性を持ちます。$R;" +
            "「誰かを守りたい」「死にたくない」$R;" +
            "などと言う想いも同様です。$R;" +
            "$Pそれらの想いにはそれぞれの$R;" +
            "想いの持つ方向性があって、$R;" +
            "その方向性にあったフシギな力を、$R;" +
            "その中に秘めているのです。$R;" +
            "$Pその力を武器や、防具などの$R;" +
            "装備品に付与することで、$R;" +
            "想いの力は装備に宿るんです。$R;" +
            "……信じられないかもしれませんが。$R;", "ジーニャ博士");

            Say(pc, 0, 0, "ちょっと、混乱してきた……。$R;", " ");
            Iris_1_mask.SetValue(Iris_1.博士, true);

        }
    }
}
