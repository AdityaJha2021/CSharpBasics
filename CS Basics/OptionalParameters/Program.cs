using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(1,c:30);
            Console.WriteLine(AddNumber(1, 2));
            Console.ReadKey();
        }

        //public static int AddNumber(int firstNumber, int secondNumber)
        //{
        //    return AddNumber(firstNumber, secondNumber, null);
        //}
        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("Value of A: " + a);
            Console.WriteLine("Value of B: " + b);
            Console.WriteLine("Value of C: " + c);
        }
        //we can make parameter optional using [Optional] which is present in System.Runtime.InteropServices or simply marking ? to the parameter.
        public static int AddNumber(int firstNumber, int secondNumber,int[] numbers = null)
        {
            int sum = firstNumber + secondNumber;
            if(numbers != null)
            {
                foreach (int number in numbers)
                {
                    sum += number;
                }
            }
            return sum;
        }
        #region Params for Optional Parameter
        //public static int AddNumber(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        sum += number;
        //    }
        //    return sum;
        //} 
        #endregion
    }
}
