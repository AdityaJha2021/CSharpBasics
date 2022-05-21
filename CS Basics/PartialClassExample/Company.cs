using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClassExample
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string  Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company
    {
        List<Employee> employees = new List<Employee>();
        //{ new Employee { EmployeeID = 1, Gender = "Female", Name = "Harshita" } };

        public Company()
        {
            employees = new List<Employee>
            {
                new Employee{EmployeeID = 1, Name="Aditya", Gender="Male"},
                new Employee{EmployeeID = 2, Gender = "Female", Name = "Harshita"},
                new Employee{EmployeeID = 3, Name="Kumud", Gender="Male"},
                new Employee{EmployeeID = 4, Name="Shivam", Gender="Male"},
                new Employee{EmployeeID = 5, Name="Rabbit", Gender="Female"},
            };
        }

        //making an indexer
        public string this[int employeeID]
        {
            get
            {
                return employees.FirstOrDefault(emp => emp.EmployeeID == employeeID).Name;
            }
            set
            {
                employees.FirstOrDefault(emp => emp.EmployeeID == employeeID).Name = value;
            }
        }

        public int this[string gender]
        {
            get
            {
                return employees.Count(emp => emp.Gender == gender);
            }
        }
    }
}