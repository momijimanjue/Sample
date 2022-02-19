/**
 * C#.NETプログラミング Sample
 * 3_6_Constructor
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _3_6_Constructor {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>Accountクラスのインスタンスを扱う</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // Accountクラスのインスタンス生成をします。
            Account acc = new Account("田中一郎", 30000);

            // 口座名義、残高を表示します。
            acc.ShowAccount();

            // デフォルトコンストラクタが生成されないため
            // 以下のコードはコンパイルエラー
            //Account acc = new Account();

        }
    }
}