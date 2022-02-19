using System;

/**
 * C#.NETプログラミング Sample
 * 8_6_UserDefinedException
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _8_6_UserDefinedException {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>ユーザ定義例外処理サンプル</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // Accountクラスのインスタンスを生成します。
            Account acc = new Account("田中一郎", 50000);

            // 例外処理
            try {
                // 残高と借入額を設定します。
                acc.TakeLoan(50000);
                acc.TakeLoan(30000); // ☆彡ここで例外が発生する
            } catch (LimitOverFlowException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            } finally {
                // ☆彡例外発生有無にかかわらず必ず実行される
                // 口座名義、口座番号、残高を表示します。
                acc.ShowAccount();
            }

        }
    }
}