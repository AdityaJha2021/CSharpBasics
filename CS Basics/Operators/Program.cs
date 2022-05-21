using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 10;
            //bool isNumber10;
            //if(number == 10)
            //{
            //    isNumber10 = true;
            //}
            //else
            //{
            //    isNumber10 = false;
            //}
            //bool isNuber11 = number == 11 ? true : false;
            //Console.WriteLine("nuber == 10 is {0}", isNumber10);
            //int? NonNullabe = 0;
            ////NonNullabe = null
            //number = NonNullabe ?? 0;
            //number = NonNullabe.Value;

            //float val = 20.02F;
            //int val1 = (int)val;
            //int val2 = Convert.ToInt32(val);
            Console.WriteLine("Enter a number, to check it is valid or not");
            string par = Console.ReadLine();
            //int parVal = int.Parse(par); // Here exception will be thrown. So better use TryParse Here
            int parVal1;
            bool isPossible = int.TryParse(par, out parVal1);

            string a = "10";
            int b = int.Parse(a);
            bool c = int.TryParse(a, out b);
            if (isPossible)
            {
                Console.WriteLine("you enterd {0}", parVal1);
            }
            else
            {
                Console.WriteLine("please enter a valid Number");
            }
            Console.ReadKey();


        }
    }
}
