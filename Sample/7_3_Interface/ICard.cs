/**
 * C#.NETプログラミング Sample
 * 7_3_Interface
 * 
 * ICard.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _7_3_Interface {
    /// <summary>カード操作インターフェイス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    interface ICard {
        /// <summary>払い出す</summary>
        /// <param name="money">金額</param>
        void Withdraw(int money);
        /// <summary>借入をする</summary>
        /// <param name="loan">借入額</param>
        void TakeLoan(int loan);
        /// <summary>口座情報を表示する</summary>
        void ShowAccount();
    }
}