using System;

namespace OverrideObjectClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Equals()
            int i = 10;
            int j = 10;
            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;
            //Console.WriteLine(direction1 == direction2);
            //Console.WriteLine(direction1.Equals(direction2));

            Customer c1 = new Customer();
            c1.FirstName = "Aditya";
            c1.LastName = "Prakash";
            Customer c2 = new Customer();
            c2.FirstName = "Aditya";
            c2.LastName = "Prakash";
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
            #endregion
            #region ToString()
            //Customer c = new Customer();
            //c.PrintFullName("Aditya", "Prakash");
            //Console.WriteLine(c.ToString());
            #endregion
            Console.ReadKey();
        }
    }

    #region ToString()
    //class Customer
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string PrintFullName(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //        return "Hello " + firstName + " " + lastName;
    //    }

    //    public override string ToString()
    //    {
    //        return "Hello from Tostring() - " + FirstName + " "+LastName; 
    //    }
    //}
    #endregion

    #region Equals()

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
    public enum Direction
    {
        North = 1,
        south = 2,
        East = 3,
        West = 4
    }
    #endregion

}
