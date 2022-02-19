/**
 * C#.NETプログラミング Sample
 * 7_2_Abstract
 * 
 * BaseCard.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _7_2_Abstract {
    /// <summary>カードクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public abstract class BaseCard {
        /// <summary>口座名義</summary>
        protected string Name { get; private set; }
        /// <summary>口座番号</summary>
        protected string Number { get; private set; }
        /// <summary>残高</summary>
        protected int Balance { get; set; }
        /// <summary>コンストラクタ </summary>
        /// <param name="name">口座名義</param>
        /// <param name="number">口座番号</param>
        protected BaseCard(string name, string number, int balance) {
            Name = name;
            Number = number;
            Balance = balance;
        }
        /// <summary>払い出す</summary>
        /// <param name="money">金額</param>
        public virtual void Withdraw(int money) {
        }
        /// <summary>借入をする</summary>
        /// <param name="loan">借入額</param>
        public virtual void TakeLoan(int loan) {
        }
        /// <summary>口座情報を表示する</summary>
        public abstract void ShowAccount();
    }
}