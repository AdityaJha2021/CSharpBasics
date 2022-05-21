using System;
using System.Collections.Generic;

namespace OOPS
{
    #region inheritance
    //class Employee
    //{
    //    public Employee()
    //    {
    //        Console.WriteLine("Parent always comes first :) ");
    //    }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    public string email { get; set; }

    //    public void PrintFullName()
    //    {
    //        Console.WriteLine("Employee full name: {0} {1}", firstName, lastName);
    //    }
    //}

    //class FullTimeEmployee : Employee
    //{
    //    public FullTimeEmployee()
    //    {
    //        Console.WriteLine("I am the child!!!");
    //    }
    //    public float salary { get; set; }
    //}

    //class PartTimeEmployee : Employee
    //{
    //    public float hourlyRate { get; set; }
    //}
    #endregion
    #region method Hiding

    //public class ParentClass
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("parent always comes first ----:)");
    //    }
    //}

    //public class ChildClass: ParentClass
    //{
    //    public int sample { get; set; }
    // we can add new here
    //    public void Print()
    //    {
    //        Console.WriteLine("Hi !!!, I am a child");
    //        // 1st: we can use base.method_name() to use hidden base class method;
    //        base.Print();
    //    }
    //}
    #endregion
    #region polymorphism
    //public class Employee
    //{

    //    public string firstName { get; set; } = "first";
    //    public string lastName { get; set; } = "Last";

    //    public virtual void Print() 
    //    {
    //        Console.WriteLine("Hello {0} {1}", firstName, lastName);
    //        //Console.WriteLine(fullName);
    //    }
    //}
    //public class ParmanentEmployee : Employee
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine("Hello {0} {1}", firstName, lastName + " - parmanent");
    //        //Console.WriteLine(fullName);
    //    }
    //}
    //public class PartTimeEmployee : Employee
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine("Hello {0} {1}", firstName, lastName + " - PartTime");
    //        //Console.WriteLine(fullName);
    //    }
    //}
    //public class TemproryEmployee : Employee 
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine("Hello {0} {1}", firstName, lastName +" - Temprory");
    //        //Console.WriteLine(fullName);
    //    }
    //    public void ABC()
    //    {

    //    }
    //}
    #endregion
    #region method overriding and method hiding
    //public class BaseClass
    //{
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Coming from base class");
    //    }
    //}

    //public class DerivedClass : BaseClass
    //{
    //    public new void Print()
    //    {
    //        Console.WriteLine("coming from derived class");
    //    }
    //}
    #endregion
    #region Need for Properties instead of Fields
    //public class Student
    //{
    //    ////Buisness Requirements
    //    ////ID can't be negative
    //    //public int ID;
    //    ////Name can't be null, if nothing then noName should be assigned
    //    //public string Name;
    //    ////passMark should be read-only
    //    //public int passMark = 35;

    //    private int _id;
    //    private string _name;
    //    private int _passMark = 35;

    //    public int GetPassMark()
    //    {
    //        return this._passMark;
    //    }
    //    public void SetName(string Name)
    //    {
    //        if (string.IsNullOrEmpty(Name))
    //        {
    //            throw new Exception("Name can not be null");
    //        }
    //        this._name = Name;
    //    }

    //    public string GetName()
    //    {
    //        if (string.IsNullOrEmpty(_name))
    //        {
    //            return "No Name";
    //        }
    //        else
    //        {
    //            return this._name;
    //        }
    //    }
    //    public void SetID(int ID)
    //    {
    //        if (ID < 0)
    //        {
    //            throw new Exception("ID value can not be negative");
    //        }
    //        this._id = ID;
    //    }

    //    public int GetID()
    //    {
    //        return this._id;
    //    }
    //}
    #endregion
    #region Properties
    //public class Student
    //{
    //    private int _id;
    //    private string _name;
    //    private int passMark = 35;
    //    public string City { get; set; } //Auto implemented prop. intoduced in c# 3.0.
    //    public int PassMark { get { return this.passMark; } }
    //    public string Name
    //    {
    //        get { return string.IsNullOrEmpty(this._name) ? "No Name" : this._name; }
    //        set
    //        {
    //            if (string.IsNullOrEmpty(value))
    //            {
    //                throw new Exception("Name can not be null");
    //            }
    //            this._name = value;
    //        }
    //    }
    //    public int ID
    //    {

    //        get { return this._id; }
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                throw new Exception("Id can not be negative\nEnter valid ID");
    //            }
    //            this._id = ID;
    //        }
    //    }
    //}
    #endregion
    #region stuct/structures
    //public struct Customer
    //{
    //    public int Id { get; set; }
    //    private string _name;
    //    public string Name { get => _name; set => _name = value; }

    //    public Customer(int id, string Name)
    //    {
    //        Id = id;
    //        _name = Name;
    //    }

    //    public void PrintName()
    //    {
    //        Console.WriteLine("ID: {0}, Name: {1}", Id, _name);
    //    }
    //}
    #endregion
    #region interface
    //public interface ICustomer1
    //{
    //    void print();
    //}

    //public interface ICustomer2
    //{
    //    void print2();
    //}

    //public class Customer : ICustomer1,ICustomer2
    //{

    //    public void print()
    //    {
    //        Console.WriteLine("Method of ICustomer");
    //    }

    //    public void print2()
    //    {
    //        Console.WriteLine("Method of ICustomer2");
    //    }
    //}
    #endregion
    #region delegate

    public delegate void PrintDelegate(string Name);

    #endregion
    class Program
    {
        public void Print(string Name)
        {
            Console.WriteLine(Name);
        }
        static void Main(string[] args)
        {
            #region delegate
            Program p = new Program();
            PrintDelegate del = new PrintDelegate(p.Print);
            del("Hello From Delgate");
            #endregion
            #region intrface
            //Customer customer = new Customer();
            //customer.print();
            //customer.print2();
            //ICustomer1 customer1 = new Customer();
            //customer1.print();
            #endregion
            #region stuct/structures
            //Customer C1 = new Customer(101, "Aditya Prakash");
            //C1.PrintName();
            //Customer C2 = new Customer();
            //C2.Id = 102;
            //C2.Name = "Aditya Jha";
            //C2.PrintName();
            //Customer C3 = new Customer()
            //{
            //    Id = 103,
            //    Name = "Aditya Dgr8"
            //};
            //C3.PrintName();
            #endregion
            #region properties
            //Student student = new Student();
            //student.Name = "Aditya Prakash";
            //student.ID = 101;
            //Console.WriteLine("ID: {0}, Name: {1}, Pass Mark: {2}", student.ID, student.Name, student.PassMark);
            #endregion
            #region Need for Properties instead of Fields
            ////Anyone can easily voilate the buisness requirements, if field is public as it is externally accessible and anyone 
            ////Student student = new Student();
            ////student.ID = -101;
            ////student.Name = null;
            ////student.passMark = 0;
            ////Console.WriteLine("ID = {0}, Name = {1}, PassMark = {2}", student.ID, student.Name, student.passMark);
            //Student student = new Student();
            //student.SetID(101);
            //student.SetName("Aditya");
            //Console.WriteLine("ID: {0} Name: {1} Pass Mark: {2}", student.GetID(), student.GetName(), student.GetPassMark());
            #endregion
            #region method overriding and method hiding
            //BaseClass b = new DerivedClass();
            //b.Print();
            #endregion
            #region polymorphism
            //Employee[] employee = new Employee[4];
            //employee[0] = new ParmanentEmployee();
            //employee[1] = new PartTimeEmployee();
            //employee[2] = new TemproryEmployee();
            //employee[3] = new Employee();

            //foreach(Employee emp in employee)
            //{
            //    emp.Print();
            //}
            #endregion
            #region method Hiding
            //ChildClass cc = new ChildClass();
            ////3rd way ,creating parent class object using child class
            //ParentClass pc = new ChildClass();
            ////2nd: we can use type cast(cast to parent) for using hidden base method
            //((ParentClass)cc).Print();
            //pc.Print();
            #endregion
            #region Inheritance
            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE.firstName = "Aditya";
            //FTE.lastName = "Prakash";
            //FTE.PrintFullName();
            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE.firstName = "Harshita";
            //PTE.lastName = "Kumari";
            //PTE.PrintFullName();
            #endregion
            Console.ReadKey();
        }
        #region method overloading
        //public void Add(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //}
        //public void Add(int a, int b, int c)
        //{
        //    Console.WriteLine(a + b + c);
        //}
        //public void Add(int a, float b)
        //{
        //    Console.WriteLine(a + b);
        //}
        //public static void Add(int a, int b, out int sum)
        //{
        //    sum = a + b;
        //}
        #endregion
    }
}

