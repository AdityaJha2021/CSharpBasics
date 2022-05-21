using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee{ID=1,FirstName="Aditya",LastName="Prakash",Designation="Software Devloper"},
                new Employee{ID=2,FirstName="Surbhi",LastName="Jha",Designation="Data Scientist"},
                new Employee{ID=3,FirstName="Vishal",LastName="Kaunilya",Designation="LDC"}
            };
        }
    }


}