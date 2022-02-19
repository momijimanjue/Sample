using System;

/**
 * C#.NETプログラミング Sample
 * 8_6_UserDefinedException
 * 
 * Account.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _8_6_UserDefinedException {
    /// <summary>口座情報管理クラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class Account {
        /// <summary>口座名義</summary>
        private string name;
        /// <summary>残高</summary>
        private int balance;
        /// <summary>借入額</summary>
        private int loan;
        /// <summary>コンストラクタ </summary>
        /// <param name="name">口座名義</param>
        /// <param name="balance">残高</param>
        public Account(string name, int balance) {
            this.name = name;
            this.balance = balance;
        }
        /// <summary>借り入れる</summary>
        /// <param name="money">借入額</param>
        public void TakeLoan(int money) {
            int sum = loan + money;
            if (balance < sum) {
                throw new LimitOverFlowException("借入合計額が限度を超えています。");
            } else {
                loan = sum;
            }
        }
        /// <summary>口座情報を表示する</summary>
        public void ShowAccount() {
            Console.WriteLine("口座名義：" + name);
            Console.WriteLine("残    高：" + balance + "円");
            Console.WriteLine("合計" + loan + "円の借り入れがあります。");
        }
    }
}