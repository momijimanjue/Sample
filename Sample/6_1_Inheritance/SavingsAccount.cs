using System;

/**
 * C#.NETプログラミング Sample
 * 6_1_Inheritance
 * 
 * SavingsAccount.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _6_1_Inheritance {
    /// <summary>総合口座情報管理クラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class SavingsAccount: Account {
        /// <summary>借入額</summary>
        private int loan;
        /// <summary>借り入れる</summary>
        /// <param name="money">借入額</param>
        public void TakeLoan(int money) {
            loan += money;
        }
        /// <summary>借入額を表示する</summary>
        public void ShowLoan() {
            Console.WriteLine("借 入 額：" + loan + "円");
        }
    }
}
