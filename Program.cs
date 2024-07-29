using System;
using System.IO;

namespace testdebugneovim
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            File.AppendAllText(
                "c:/tmp/dbg.txt",
                "hello from testdebugneovim " + string.Join(",", args) + "\n"
            );
            Console.WriteLine("hello ");
            string[] t = ["bonjour", "le monde", "entier"];
            File.AppendAllText("c:/tmp/dbg.txt", "1\n");
            Console.WriteLine(string.Join(", ", t));
            string arguments = "no arg";
            Console.WriteLine(args.Length);
            File.AppendAllText("c:/tmp/dbg.txt", "two\n");
            if (args != null && args.Length != 0)
            {
                arguments = string.Join(",", args);
            }
            Console.WriteLine($"Hello World from NeoVIM [{arguments}]");
            File.AppendAllText("c:/tmp/dbg.txt", $"arguments [{arguments}]\n");
            File.AppendAllText("c:/tmp/dbg.txt", "this is the end of this wonderful test program");
            Test();

            Other other = new("autre");
            other.Do();
        }

        public static void Test()
        {
            Test2();
            Console.WriteLine("test");
            Console.WriteLine("this is a test");
        }

        public static void Test2()
        {
            Console.WriteLine("test2.2.2.2");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
