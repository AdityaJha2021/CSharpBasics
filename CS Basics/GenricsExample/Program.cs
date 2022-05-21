using System;

namespace GenricsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.FirstName = "Aditya";
            c1.LastName = "Prakash";
            Calculator c2 = new Calculator();
            c2 = c1;
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1.ToString());
            bool areEqual = Calculator.AreEqual<string>("A", "A");
            if (areEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.ReadKey();
        }
    }

    class Calculator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }
    }
}
