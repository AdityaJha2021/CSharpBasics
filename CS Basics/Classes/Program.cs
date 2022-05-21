using System;

namespace Classes
{
    public abstract class Ab1
    {
        public abstract int Adi();
    }

    public class Ab : Ab1
    {
        public override int Adi()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float a = 10.67F;
            Customer customer = new Customer("Aditya", "Prakash");
            Customer customer1 = new Customer();
            customer.Print();
            customer1.Print();
        }
    }

    class Customer
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        public Customer() : this("No First Name", "No Last Name")
        {

        }
        public Customer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

       
        public void Print()
        {
            Console.WriteLine("Welcome Mr./Ms. {0} {1}", _firstName, _lastName);
        }
        ~Customer()
        {
            //cleanup logic
        }
    }
}
