/**
 * C#.NETプログラミング Sample
 * 3_3_Instance
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _3_3_Instance {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>Accountクラスのインスタンスを扱う</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // Accountクラスのインスタンスを生成します。
            Account acc = new Account();

            // 口座名義、残高を表示します。
            acc.ShowAccount();

        }
    }
}
