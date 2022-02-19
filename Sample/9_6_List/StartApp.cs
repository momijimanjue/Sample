using System;
using System.Collections.Generic;

/**
* C#.NETプログラミング Sample
* 9_6_List
* 
* StartApp.cs
* 
* Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
*/
namespace _9_6_List {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>書庫に文学作品の情報を登録する</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // リストを生成します。
            List<Novel> novels = new List<Novel>();

            // Novel型の変数を定義します。
            Novel novel;

            // 1つ目の文学作品を登録します。
            novel = new Novel();
            novel.Content = "吾輩は猫である。名前はまだない。・・・";
            novel.Author = "夏目漱石";
            novel.Title = "吾輩は猫である";
            novels.Add(novel);

            // 2つ目の文学作品を登録します。
            novel = new Novel();
            novel.Content = "メロスは激怒した。必ず、かの邪知暴虐の王を・・・";
            novel.Author = "太宰治";
            novel.Title = "走れメロス";
            novels.Add(novel);

            // 3つ目の文学作品を登録します。
            novel = new Novel();
            novel.Content = "国境の長いトンネルを抜けると雪国だった。・・・";
            novel.Author = "川端康成";
            novel.Title = "雪国";
            novels.Add(novel);

            // 4つ目の文学作品を登録します。
            novel = new Novel();
            novel.Content = "ある日の暮れ方のことである。一人の下人が・・・";
            novel.Author = "芥川龍之介";
            novel.Title = "羅生門";
            novels.Add(novel);

            // 5つ目の文学作品を登録します。
            novel = new Novel();
            novel.Content = "ゴーシュは町の活動写真館でセロを弾く係りでした。・・・";
            novel.Author = "宮沢賢治";
            novel.Title = "セロ弾きのゴーシュ";
            novels.Add(novel);

            // 6つ目の文学作品を登録します。
            novel = new Novel();
            novel.Content = "私はその人のことをいつも先生と呼んでいた。・・・";
            novel.Author = "夏目漱石";
            novel.Title = "こころ";
            novels.Add(novel);

            // 文学作品を表示します。
            for (int i = 0; i < novels.Count; i++) {
                novel = novels[i];
                Console.Write(novel.Title + " → ");
                Console.Write(novel.Author + " → ");
                Console.WriteLine(novel.Content);
            }

        }
    }
}