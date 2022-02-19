using System;

/**
 * C#.NETプログラミング Sample
 * 8_5_ThrowException
 * 
 * StartApp.cs
 * 
 * Copyright(C) 2016 emBex Education Inc. All Rights Reserved.
 */
namespace _8_5_ThrowException {
    /// <summary>アプリケーションクラス</summary>
    /// <author>emBex Education</author>
    /// <version>1.00</version>
    public class StartApp {
        /// <summary>例外をスローするサンプル</summary>
        /// <param name="args">この引数は使用しない</param>
        public static void Main(string[] args) {

            // 例外処理
            try {
                // コマンドライン引数の数をチェック
                if (args.Length != 1) {
                    throw new ArgumentException("引数の個数は、距離（m）の1個だけです。");
                } else {
                    // 時間計算（分速）
                    int speed = 80;

                    // 例外処理
                    try {
                        // コマンドライン引数の距離と時間を計算し表示する
                        int distance = int.Parse(args[0]);
                        int time = distance / speed;
                        Console.WriteLine(distance + "mは、一般的な歩行速度で" + time + "分かかります。");
                    } catch {
                        throw;
                    }
                }
            } catch (FormatException e) {
                Console.WriteLine("整数に変換できない文字列が入力されました。");
                Console.WriteLine(e);
            } catch (Exception e) {
                Console.WriteLine(e);
            }

        }
    }
}