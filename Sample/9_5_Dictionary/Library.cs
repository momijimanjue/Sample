using System;
using System.Collections.Generic;

/**
 * C#.NETプログラミング Sample
 * 9_5_Dictionary
 * 
 * Library.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _9_5_Dictionary {
    /// <summary>文学作品集クラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class Library {
        /// <summary>文学作品を格納するリスト</summary>
        private readonly Dictionary<string, Novel> novels;

        public Library() {
            novels = new Dictionary<string, Novel>();
        }

        /// <summary>文学作品を追加する</summary>
        /// <param name="novel">文学作品</param>
        public void AddNovel(Novel novel) {
            novels.Add(novel.Title, novel);
        }

        /// <summary>すべての文学作品を表示する</summary>
        public void ShowNovel() {
            foreach (KeyValuePair<string, Novel> novel in novels) {
                novel.Value.ShowNovel();
            }
            //foreach (var novel in novels) {/**ローカル変数の型推論**/
            //    novel.Value.ShowNovel();
            //}
        }

        /// <summary>文学作品を表示する</summary>
        /// <summary>文学作品のタイトル</summary>
        public void ShowNovel(string title) {
            if (novels.ContainsKey(title)) {
                Novel novel = novels[title];
                Console.WriteLine("「" + novel.Title + "」の作者は、" + novel.Author + "です。");
                Console.WriteLine("その書き出しは、「" + novel.Content + "」");
            } else {
                Console.WriteLine("「" + title + "」はみつかりません。");
            }
        }
    }
}
