using System;

namespace Sample {
    public class HelloWorld {
        public static void Main(string[] args) {
            Console.WriteLine("こんにちは　C#の世界へようこそ！");
        }
    }
}

/**
 * 型名を利用しないで静的メソッドにアクセスする
 */
namespace Sample.Static {
    using static System.Console;
    public class HelloWorld {
        public static void Main(string[] args) {
            WriteLine("こんにちは　C#の世界へようこそ！");
        }
    }
}

/**
 * 型の別名を定義する
 */
namespace Sample.Arias {
    
    using c = System.Console;
    public class HelloWorld {
        public static void Main(string[] args) {
            c.WriteLine("こんにちは　C#の世界へようこそ！");
        }
    }
}
