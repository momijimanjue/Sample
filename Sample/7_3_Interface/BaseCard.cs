using System;

/**
 * C#.NETプログラミング Sample
 * 7_3_Interface
 * 
 * BaseCard.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _7_3_Interface {
    /// <summary>カードクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class BaseCard {
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
    }
}