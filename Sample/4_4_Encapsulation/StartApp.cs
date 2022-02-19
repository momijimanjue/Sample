/**
 * C#.NETプログラミング Sample
 * 4_4_Encapsulation
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _4_4_Encapsulation {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>Accountクラスのインスタンスを扱う</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // Accountクラスのインスタンスを生成します。
            Account acc = new Account();

            // 口座名義と残高を設定して表示します。
            acc.Name = "田中一郎";
            acc.Balance = 40000;
            acc.ShowAccount();

        }
    }
}