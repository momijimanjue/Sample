using System;

/**
 * C#.NETプログラミング Sample
 * 9_5_Dictionary
 * 
 * Novel.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _9_5_Dictionary {
    /// <summary>文学作品クラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class Novel {
        /// <summary>タイトル</summary>
        public string Title { get; private set; }
        /// <summary>作家</summary>
        public string Author { get; private set; }
        /// <summary>内容</summary>
        public string Content { get; private set; }

        /// <summary>コンストラクタ</summary>
        /// <param name="title">タイトル</param>
        /// <param name="author">作家</param>
        /// <param name="content">内容</param>
        public Novel(string title, string author, string content) {
            Title = title;
            Author = author;
            Content = content;
        }

        /// <summary>タイトル、作家、作品内容を表示する</summary>
        public void ShowNovel() {
            Console.WriteLine(Title + " → " + Author + " → " + Content);
        }
    }
}
