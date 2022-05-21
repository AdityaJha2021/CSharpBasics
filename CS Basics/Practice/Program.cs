using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Practice
{
    public partial class ParEx
    {
        partial void Adi();

    }

    public partial class ParEx
    {
        partial void Adi()
        {
            throw new NotImplementedException();
        }
    }

    public delegate void SampleDelegate(int a, int b, ref int c, ref int d);

    public class GenricClassEDxample<T>
    {
        string stringExample = "Aditya";
    }
    public class RefAndOut
    {
        public string employeeId { get; set; }
        public string this[string id]
        {
            get
            {
                return employeeId;
            }
        }

        public static void RefMethod(int a, int b, ref int c, [Optional]ref int d)
        {
            RefAndOut refand = new RefAndOut();
            string cd = refand["Hello"];
            GenricClassEDxample<int> gc = new GenricClassEDxample<int>();
            var ab = 10;
            dynamic abc;
            abc = 20;
            abc = "aditya";
        }

        public static void OutMethod(int a, int b, out int c, out int d)
        {
            c = 10;
            d = 20;
        }
    }
    public class IncapsulationExample
    {
        private int _id;

        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _id = value;
            }
        }
    }


    class Program
    {
        public void Concat1(string s1)
        {
            s1 = string.Concat(s1, " Prakash");
        }

        public void Concat2(StringBuilder s2)
        {
            s2.Append(" prakash");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string samp1 = "Aditya";
            p.Concat1(samp1);
            Console.WriteLine(samp1);
            StringBuilder samp2 = new StringBuilder("Aditya");
            p.Concat2(samp2);
            Console.WriteLine(samp2);


            int z = 10;
            int y = 20;
            SampleDelegate del = new SampleDelegate(RefAndOut.RefMethod);
            del(1, 2, ref y, ref z);
            List<int> intList = new List<int>();
            intList.Add(2);
            intList.Add(5);
            intList.Add(10);

            var result = intList.Where(l => l % 2 == 1);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            int c = 0;
            int d = 0;
            RefAndOut.RefMethod(1, 2, ref c, ref d);

            int e;
            int f;
            RefAndOut.OutMethod(1, 2, out e, out f);

            int a = 0;
            do
            {
                Console.WriteLine("Hello" + a);
                a++;
            }
            while (a == 0);
            Console.WriteLine("while below");
            while (a == 0)
            {
                Console.WriteLine("hello");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }
}
