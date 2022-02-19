using System;

/**
 * C#.NETプログラミング Sample
 * 6_4_Constructor
 * 
 * Account.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _6_4_Constructor {
    /// <summary>口座情報管理クラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class Account {
        /// <summary>口座名義</summary>
        private string name;
        /// <summary>残高</summary>
        private int balance;
        /// <summary>コンストラクタ </summary>
        /// <param name="name">口座名義</param>
        /// <param name="balance">残高</param>
        public Account(string name, int balance) {
            this.name = name;
            this.balance = balance;
        }
        /// <summary>口座情報を表示する</summary>
        public void ShowAccount() {
            Console.WriteLine("口座名義：" + name);
            Console.WriteLine("残    高：" + balance + "円");
        }
    }
}