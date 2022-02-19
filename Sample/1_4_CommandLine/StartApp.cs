using System;

/**
 * C#.NETプログラミング Sample
 * 1_4_CommandLine
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _1_4_CommandLine {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>身長・体重からBMIを計算し、結果を表示するクラス</summary>
        /// <param name="args">名前・身長・体重</param>
        public static void Main(string[] args) {

            // 引数の検査
            if (args.Length != 3) {
                Console.WriteLine("＜名前＞ ＜身長cm＞ ＜体重kg＞を指定してください。");
                //Environment.Exit(1);
            } else {
                string name = args[0];
                double height = double.Parse(args[1]);
                double weight = double.Parse(args[2]);

                // BMI係数の計算
                string message = "";
                double bmi = weight / ((height / 100) * (height / 100));

                // 判定とメッセージ作成
                if (bmi >= 30) {
                    message = name + "さんは、肥満です。＜肥満度：" + bmi + "＞";
                } else if (bmi >= 25) {
                    message = name + "さんは、やや肥満です。＜肥満度：" + bmi + "＞";
                } else if (bmi >= 18.5) {
                    message = name + "さんは、正常範囲です。＜肥満度：" + bmi + "＞";
                } else {
                    message = name + "さんは、体重不足です。＜肥満度：" + bmi + "＞";
                }

                // 結果の表示
                Console.WriteLine("**** 計算結果を表示します ****");
                Console.WriteLine(message);
            }

        }
    }
}
