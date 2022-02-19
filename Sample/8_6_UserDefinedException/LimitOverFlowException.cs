using System;

/**
 * C#.NETプログラミング Sample
 * 8_6_UserDefinedException
 * 
 * LimitOverFlowException.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _8_6_UserDefinedException {
    /// <summary>範囲内におさまらないときのユーザ定義例外クラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class LimitOverFlowException : Exception {
        /// <summary>コンストラクタ</summary>
        /// <param name="message">例外メッセージ</param>
        public LimitOverFlowException(string message) : base(message) {
        }
    }
}