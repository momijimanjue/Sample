using System;

/**
 * C#.NETプログラミング Sample
 * 8_3_Exception
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _8_3_Exception {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>例外処理サンプル</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // コマンドライン引数の数をチェック
            if (args.Length != 1) {
                Console.WriteLine("引数の個数は、距離（m）の1個だけです。");
                //Environment.Exit(1);
            } else {
                // 時間計算（分速）
                int speed = 80;

                // 例外処理
                try {
                    // コマンドライン引数の距離と時間を計算し表示する
                    int distance = int.Parse(args[0]);
                    int time = distance / speed;
                    Console.WriteLine(distance + "mは、一般的な歩行速度で" + time + "分かかります。");
                } catch (FormatException e) {
                    // 変換失敗時に例外発生
                    Console.WriteLine("整数に変換できない文字列が入力されました。");
                    Console.WriteLine(e);
                }
            }

        }
    }
}