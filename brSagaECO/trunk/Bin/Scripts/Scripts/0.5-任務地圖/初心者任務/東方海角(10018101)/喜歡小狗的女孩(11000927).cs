using System;
using System.Collections.Generic;
using System.Text;

using SagaDB.Actor;
using SagaMap.Scripting;

using SagaLib;
using SagaScript.Chinese.Enums;
//所在地圖:東方海角(10018101) NPC基本信息:喜歡小狗的女孩(11000927) X:201 Y:90
namespace SagaScript.M10018101
{
    public class S11000927 : Event
    {
        public S11000927()
        {
            this.EventID = 11000927;
        }

        public override void OnEvent(ActorPC pc)
        {
            BitMask<Beginner_01> Beginner_01_mask = new BitMask<Beginner_01>(pc.CMask["Beginner_01"]);

            if (!Beginner_01_mask.Test(Beginner_01.已經與埃米爾進行第一次對話))
            {
                尚未與埃米爾對話(pc);
                return;
            }

            //尚未插入♪表情
            Say(pc, 11000927, 0, "太可愛了~♪$R;" +
                                 "$R您找我有什麼事情嗎?$R;", "喜歡小狗的女孩");

            switch (Select(pc, "在看什麼?", "", "那「♪」是…?", "沒什麼"))
            {
                case 1:
                    Say(pc, 11000927, 0, "這是「表情」唷!$R;" +
                                         "$R打開「表情」視窗，$R;" +
                                         "就可以簡單地使用。$R;" +
                                         "$P旁邊較大的聊天用視窗$R;" +
                                         "看到了嗎?$R;" +
                                         "$R想要打開「表情」視窗，$R;" +
                                         "就點擊這個視窗右邊的$R;" +
                                         "笑臉圖示。$R;" +
                                         "$P在「表情」和「動作」視窗，$R;" +
                                         "雙擊要使用的圖示即可。$R;" +
                                         "$P很簡單吧~♪$R;" +
                                         "$R跟朋友說話時，$R;" +
                                         "使用各種表情$R;" +
                                         "會更有趣的唷!$R;", "喜歡小狗的女孩");
                    break;
                    
                case 2:
                    break;
            }
        }

        void 尚未與埃米爾對話(ActorPC pc)
        {
            Say(pc, 11000927, 0, "太可愛了!!$R;" +
                                 "$R(…好像沒有一是周圍的情況。)$R;", "喜歡小狗的女孩");
        }  
    }
}
