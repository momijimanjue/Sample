using System;

/**
 * C#.NETプログラミング Sample
 * 6_1_Inheritance
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _6_1_Inheritance {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>Accountクラスのインスタンスを扱う</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // SavingsAccountクラスのインスタンスを生成します。
            SavingsAccount acc = new SavingsAccount();

            // 口座名義と残高を設定して表示します。
            acc.Name = "田中一郎";
            acc.Balance = 70000;
            acc.ShowAccount();
            Console.WriteLine();

            // 借入額を設定して表示します。
            acc.TakeLoan(30000);
            acc.ShowLoan();

        }
    }
}
