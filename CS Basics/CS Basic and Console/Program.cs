using System;

namespace CS_Basic_and_Console
{
    class Program
    {
        //built in data types:
        bool isTrue;
        sbyte b;
        byte ba;
        ulong ab;
        long abc;
        short s;
        ushort us;
        int i;
        uint ui;
        char chars;
        float f;
        double d;
        decimal dec;
        string str;
        static void Main(string[] args)
        {
            var path = "c:\\aditya\\doc";
            var path1 = @"c:\aditya\doc";
            Console.WriteLine("please enter your name");

            string username = Console.ReadLine();
            //Console.WriteLine("Hello " + username);
            Program p = new Program();
            Console.WriteLine("Hello {0}{1}", username, p.isTrue);
            Console.WriteLine("\"Hello\"");
            Console.WriteLine("one\ntwo\nthree");
            Console.ReadKey();
        }
    }
}
