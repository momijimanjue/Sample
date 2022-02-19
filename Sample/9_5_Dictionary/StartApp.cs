
/**
 * C#.NETプログラミング Sample
 * 9_5_Dictionary
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _9_5_Dictionary {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>書庫に文学作品の情報を登録する</summary>
        /// <param name="args">文学作品のタイトル</param>
        public static void Main(string[] args) {

            // Library クラスのインスタンスを生成します。
            Library library = new Library();

            // 文学作品を登録します。
            library.AddNovel(new Novel("吾輩は猫である", "夏目漱石", "吾輩は猫である。名前はまだない。・・・"));
            library.AddNovel(new Novel("走れメロス", "太宰治", "メロスは激怒した。必ず、かの邪知暴虐の王を・・・"));
            library.AddNovel(new Novel("雪国", "川端康成", "国境の長いトンネルを抜けると雪国だった。・・・"));
            library.AddNovel(new Novel("羅生門", "芥川龍之介", "ある日の暮れ方のことである。一人の下人が・・・"));
            library.AddNovel(new Novel("セロ弾きのゴーシュ", "宮沢賢治", "ゴーシュは町の活動写真館でセロを弾く係りでした。・・・"));
            library.AddNovel(new Novel("こころ", "夏目漱石", "私はその人のことをいつも先生と呼んでいた。・・・"));

            // 文学作品を表示します。
            if (args.Length == 1) {
                library.ShowNovel(args[0]);
            } else {
                library.ShowNovel();
            }

        }
    }
}
