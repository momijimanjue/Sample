/**
 * C#.NETプログラミング Sample
 * 6_4_Constructor
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _6_4_Constructor {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>Accountクラスのインスタンスを扱う</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // SavingsAccountクラスのインスタンスを生成します。
            SavingsAccount acc = new SavingsAccount("田中一郎", 50000, 70000);

            // 口座名義、残高を表示します。
            acc.ShowAccount();

            // 借入額を表示します。
            acc.ShowLoan();

            // デフォルトコンストラクタが作成されないため
            // 以下のコードはエラー
            // SavingsAccount acc = new SavingAccount();

        }
    }
}