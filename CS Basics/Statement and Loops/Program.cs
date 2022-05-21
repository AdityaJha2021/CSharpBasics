using System;

namespace Statement_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region switch statement:
            //    Console.WriteLine("Enter any Number");
            //    int EnteredNumber = int.Parse(Console.ReadLine());
            //    switch (EnteredNumber)
            //    {
            //        case 10:
            //            Console.WriteLine("Entered Number is 10");
            //            break;
            //        case 20:
            //            Console.WriteLine("Entered no. is 20");
            //            break;
            //        case 30:
            //            Console.WriteLine("Entered no. is 30");
            //            break;
            //        default:
            //            Console.WriteLine("Enter no is not 10, 20 and 30");
            //            break;
            //    }
            //    switch (EnteredNumber)
            //    {
            //        case 10:
            //        case 20:
            //        case 30:
            //            Console.WriteLine("Number entered is {0}", EnteredNumber);
            //            break;
            //        default:
            //            Console.WriteLine("Entered no. is not 10, 20 and 30");
            //            break;
            //    }
            //  //Buying coffee and billing program:
            //start:
            //    int totalCoffeCost = 0;
            //startAgain:
            //    Console.WriteLine("Which coffe yuo want to buy:\n1 - small\n2 - Medium \n3 - Large");
            //    int userChoice = int.Parse(Console.ReadLine());
            //    switch (userChoice)
            //    {
            //        case 1:
            //            totalCoffeCost += 10;
            //            break;
            //        case 2:
            //            totalCoffeCost += 15;
            //            break;
            //        case 3:
            //            totalCoffeCost += 20;
            //            break;
            //        default:
            //            Console.WriteLine("you have entered invalid choice\nplease try again");
            //            goto start;
            //    }
            //    Console.WriteLine("do you want to continue coffee shopping");
            //    string userDecision = Console.ReadLine();
            //    switch (userDecision.ToUpper())
            //    {
            //        case "YES":
            //            goto startAgain;
            //        case "NO":
            //            break;
            //    }
            //    Console.WriteLine("your billed amount is {0}", totalCoffeCost);
            #endregion
            #region while loop
            //Console.WriteLine("Enter the target number");
            //int userNumber = int.Parse(Console.ReadLine());
            //int start = 0;
            //while (start <= userNumber)
            //{
            //    Console.Write(start+ " ");
            //    start = start + 2;
            //}
            #endregion
            #region do while loop:
            //string userChoice = string.Empty;
            //do
            //{
            //    int start = 0;
            //    Console.WriteLine("Enter the number target");
            //    int userNumber = int.Parse(Console.ReadLine());

            //    while (start <= userNumber)
            //    {
            //        {
            //            Console.Write(start + " ");
            //            start += 2;
            //        }
            //    }
            //    do
            //    {
            //        Console.WriteLine("do you want to enter no. again - yes or no");
            //        userChoice = Console.ReadLine().ToUpper();
            //        if (userChoice != "NO" && userChoice != "YES")
            //        {
            //            Console.WriteLine("Invalid choice\nplease try again...");
            //        }
            //    } while (userChoice != "NO" && userChoice != "YES");
            //} while (userChoice == "YES");

            #endregion
            #region for loop
            //int[] numbers = new int[3];
            //numbers[0] = 101;
            //numbers[1] = 102;
            //numbers[2] = 103;
            //int i = 0;
            //while(i < numbers.Length)
            //{
            //    Console.WriteLine(numbers[i]);
            //    i++;
            //}
            //Console.WriteLine("\n");
            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    Console.WriteLine(numbers[j]);
            //}
            //Console.WriteLine("\n");
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            int a;
            int b = 10;
            Sample(10, ref b);
            Sample1(10, out a);
            Sample2(10,10, 20, 30, 40);
        }

        public static void Sample(int a, ref int b)
        {
            int c = b;
        }

        public static void Sample1(int a, out int b)
        {
            b = 10;
        }

        public static void Sample2(int a, params int[] b)
        {

        }
    }
}
