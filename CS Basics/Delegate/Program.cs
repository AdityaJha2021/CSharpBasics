using System;
using System.Collections.Generic;
using System.IO;

namespace Delegate
{
    #region simple List
    //public class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //    public int Experience { get; set; }

    //    public static void PromoteEmployee(List<Employee> employees)
    //    {
    //        foreach (Employee emp in employees)
    //        {
    //            if (emp.Experience > 4)
    //            {
    //                Console.WriteLine(emp.Name+" Promoted");
    //            }
    //        }   
    //    }
    //}
    #endregion

    #region enum
    //public class Employee
    //{
    //    public int EmployeeId { get; set; }
    //    public Gender gender { get; set; }

    //    public static string Privilages(Gender getGender)
    //    {
    //        switch (getGender)
    //        {
    //            case Gender.Male:
    //                return "You are male";
    //            case Gender.Female:
    //                return "You are Female";
    //            case Gender.Other:
    //                return "Unkown";
    //            default:
    //                return "Invalid data detected";
    //        }
    //    }
    //}
    // public enum Gender
    //{
    //    Male,
    //    Female,
    //    Other
    //}
    #endregion

    public class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, customer> custmoreDictionary = new Dictionary<int, customer>();

            customer customer1 = new customer() { Id = 101, Name = "Aditya", Salary = 1000 };
            customer customer2 = new customer() { Id = 102, Name = "Harshi", Salary = 2000 };
            customer customer3 = new customer() { Id = 103, Name = "Rabbit", Salary = 2000 };
            custmoreDictionary.Add(customer1.Id, customer1);
            custmoreDictionary.Add(customer2.Id, customer2);
            custmoreDictionary.Add(customer3.Id, customer3);

            customer customer101 = custmoreDictionary[101];
            Console.WriteLine("{0},{1},{2}",customer101.Id, customer101.Name, customer101.Salary);

            foreach (KeyValuePair<int,customer> cst in custmoreDictionary)
            {
                Console.WriteLine(cst.Key);
                customer cust = cst.Value;
                Console.WriteLine("{0},{1},{2}", cust.Id, cust.Name, cust.Salary);
            }
            

            #region exception Handling
            //try
            //{
            //    StreamReader streamReader = new StreamReader(@"C:\Users\aprakash58\OneDrive - DXC Production\Desktop\self\Data.txt");
            //    Console.WriteLine(streamReader.ReadToEnd());
            //    streamReader.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine(ex.StackTrace);
            //}
            #endregion
            #region simple list
            //List<Employee> employees = new List<Employee>();
            //employees.Add(new Employee() { Id = 101, Name = "Aditya", Salary = 5000, Experience = 5 });
            //employees.Add(new Employee() { Id = 102, Name = "Ram", Salary = 4000, Experience = 4 });
            //employees.Add(new Employee() { Id = 103, Name = "Shyam", Salary = 3000, Experience = 3 });
            //employees.Add(new Employee() { Id = 104, Name = "Mohan", Salary = 2000, Experience = 2 });
            //Employee.PromoteEmployee(employees);
            #endregion
            Console.ReadKey();
        }
    }
}
