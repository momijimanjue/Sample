using System;

/**
 * C#.NETプログラミング Sample
 * 7_3_Interface
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _7_3_Interface {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>Accountクラスのインスタンスを扱う</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // CreditCardクラスのインスタンスを生成します。
            ICard credit = new CreditCard("田中一郎", "1234567", 100000);

            // 借入額を設定して、口座名義、残高、借入額を表示します。
            credit.TakeLoan(80000);
            credit.ShowAccount();
            Console.WriteLine();

            // CashCardクラスのインスタンスを生成します。
            ICard cash = new CashCard("田中一郎", "1234567", 100000);

            // 払出額を設定して、口座名義、口座番号、残高を表示します。
            cash.Withdraw(20000);
            cash.ShowAccount();

        }
    }
}