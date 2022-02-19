using System;

/**
 * C#.NETプログラミング Sample
 * 7_3_Interface
 * 
 * CreditCard.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _7_3_Interface {
    /// <summary>クレジットカードクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class CreditCard : BaseCard, ICard {
        /// <summary>借入額</summary>
        private int loan;
        /// <summary>コンストラクタ </summary>
        /// <param name="name">口座名義</param>
        /// <param name="number">口座番号</param>
        /// <param name="balance">残高</param>
        public CreditCard(string name, string number, int balance) 
            : base(name, number, balance) {
        }
        /// <summary>払い出す</summary>
        /// <param name="money">金額</param>
        public void Withdraw(int money) {
            // 実装はありません
        }
        /// <summary>借入をする</summary>
        /// <param name="loan">借入額</param>
        public void TakeLoan(int loan) {
            this.loan += loan;
        }
        /// <summary>口座情報を表示する</summary>
        public void ShowAccount() {
            Console.WriteLine("口座名義：" + Name);
            Console.WriteLine("口座番号：" + Number);
            Console.WriteLine("残    高：" + Balance + "円");
            Console.WriteLine("借 入 額：" + loan + "円");
        }
    }
}