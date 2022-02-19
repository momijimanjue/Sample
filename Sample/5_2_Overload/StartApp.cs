using System;

/**
 * C#.NETプログラミング Sample
 * 5_2_Overload
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _5_2_Overload {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>Accountクラスのインスタンスを扱う</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // Accountクラスのインスタンスを生成します。
            Account acc = new Account();
            acc.Name = "田中一郎";
            acc.Balance = 50000;

            // 払出額を設定して、口座名義、残高を表示します（一部を払い出す）。
            acc.Withdraw(10000);
            acc.ShowAccount();
            Console.WriteLine();

            // 払出額を設定せず、口座名義、残高を表示します（全額を払い出す）。
            acc.Withdraw();
            acc.ShowAccount();

        }
    }
}