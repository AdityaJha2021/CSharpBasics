using System;
using PATA = Methods.TeamA;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
        Program p = new Program();
            //p.EvenNumber();
            //EvenNumber(40);
            string i = "Hello Aditya";
            Console.WriteLine(i);
            //SimpleMethod(ref i);
            int sum = 10;
            int prod = 0;
            //SimpleMethod(10, 20, out sum, out prod);
            SomeFunction(out sum);
            Console.WriteLine("sum is {0} and Product is {1}", sum, prod);
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            ParameterArray(1,2,4,3);
            PATA.Program.Print();
            PATA.Program pp = new PATA.Program("aditya", "prakash");
            PATA.Program.Print();
        }

        //instance method --- to call this method we have to make instance of the class which is containing that method.
        //public void EvenNumber()
        //{
        //    for(int i = 2; i<=20; i += 2)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //public static void EvenNumber(int target)
        //{
        //    for(int i = 2; i <= target; i += 2)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}

        //public static void SimpleMethod(ref string j)
        //{
        //    j = "Hello Again";
        //}

        //public static void SimpleMethod(int a, int b, out int sums, out int prods)
        //{
        //    sums = a + b;
        //    prods = a * b;
        //}
        static void SomeFunction(out int insideVar)
        {
            insideVar = 0;
            insideVar += 20;
        }

        static void ParameterArray(params int[] a)
        {

        }

    }
    namespace TeamA
    {
        class Program
        {
            public string _firstName { get; set; }
            public string _lastName { get; set; }
            public Program(string firstName, string LastName)
            {
                _firstName = firstName;
                _lastName = LastName;
            }
            public static void Print()
            {
                Console.WriteLine("Hello From Team A");
            }
            
        }
    }
}
