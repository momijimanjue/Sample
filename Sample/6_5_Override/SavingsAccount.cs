using System;

/**
 * C#.NETプログラミング Sample
 * 6_5_Override
 * 
 * SavingsAccount.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _6_5_Override {
    /// <summary>総合口座情報管理クラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class SavingsAccount: Account {
        /// <summary>借入額</summary>
        private int loan;
        /// <summary>コンストラクタ </summary>
        /// <param name="name">口座名義</param>
        /// <param name="balance">残高</param>
        /// <param name="loan">借入額</param>
        public SavingsAccount(string name, int balance, int loan) : base(name, balance) {
            this.loan = loan;
        }
        /// <summary>借入額を表示する</summary>
        public override void ShowAccount() {
            base.ShowAccount();
            Console.WriteLine("借 入 額：" + loan + "円");
        }
        ///// <summary>借入額を表示する</summary>
        //public new void ShowAccount() {
        //    base.ShowAccount();
        //    Console.WriteLine("借 入 額：" + loan + "円");
        //}
    }
}