using System;

/**
 * C#.NETプログラミング Sample
 * 6_1_Inheritance
 * 
 * Account.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _6_1_Inheritance {
    /// <summary>口座情報管理クラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class Account {
        /// <summary>口座名義</summary>
        public string Name { get; set; }
        /// <summary>残高</summary>
        public int Balance { get; set; }
        /// <summary>口座情報を表示する</summary>
        public void ShowAccount() {
            Console.WriteLine("口座名義：" + Name);
            Console.WriteLine("残    高：" + Balance + "円");
        }
    }
}