using System;

/**
 * C#.NETプログラミング Sample
 * 3_3_Instance
 * 
 * Account.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _3_3_Instance {
    /// <summary>口座情報管理クラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class Account {
        /// <summary>口座名義</summary>
        private string name = "田中一郎";
        /// <summary>残高</summary>
        private int balance = 20000;
        /// <summary>口座情報を表示する</summary>
        public void ShowAccount() {
            Console.WriteLine("口座名義：" + name);
            Console.WriteLine("残　　高：" + balance + "円");
        }
    }
}