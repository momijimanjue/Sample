using System;

/**
 * C#.NETプログラミング Sample
 * 7_2_Abstract
 * 
 * CashCard.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _7_2_Abstract {
    /// <summary>キャッシュカードクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class CashCard : BaseCard {
        /// <summary>コンストラクタ </summary>
        /// <param name="name">口座名義</param>
        /// <param name="number">口座番号</param>
        /// <param name="balance">残高</param>
        public CashCard(string name, string number, int balance)
            : base(name, number, balance) {
        }
        /// <summary>払い出す</summary>
        /// <param name="money">金額</param>
        public override void Withdraw(int money) {
            base.Withdraw(money);
            Balance -= money;
        }
        /// <summary>口座情報を表示する</summary>
        public override void ShowAccount() {
            Console.WriteLine("口座名義：" + Name);
            Console.WriteLine("口座番号：" + Number);
            Console.WriteLine("残    高：" + Balance + "円");
        }
    }
}