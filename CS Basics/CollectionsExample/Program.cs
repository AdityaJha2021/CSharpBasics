using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 7, 9, 2, 4, 5, 8, 6 };
            
            Console.WriteLine("Numbers before Sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.Write("\nElements of array in sorted ascending order:\n");
            int i, j, tmp;
            for (i = 0; i < numbers.Length; i++)
            {
                for (j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        tmp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tmp;
                    }
                }
            }
            
            Console.WriteLine("Numbers in Ascending Order");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------------------------------------------------------");


            Employee employee1 = new Employee
            {
                EmployeeId = 101,
                Name = "Aditya",
                Salary = 10000
            };
            Employee employee2 = new Employee
            {
                EmployeeId = 102,
                Name = "Harshita",
                Salary = 8000
            };
            Employee employee3 = new Employee
            {
                EmployeeId = 103,
                Name = "Anji",
                Salary = 6000
            };

            #region List
            List<Employee> employees = new List<Employee>(2);
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            employees.Insert(0, employee3);
            Console.WriteLine(employees.IndexOf(employee3, 0, 3));
            if (employees.Contains(employee3))
                Console.WriteLine("List Contain employee3");
            if (employees.Exists(emp => emp.Name.StartsWith("B")))
                Console.WriteLine("Exists");
            List<Employee> emps = employees.FindAll(emp => emp.Salary > 7000);
            
            for(i = 0; i<employees.Count; i++)
            {
                Employee employee = employees[i];
                Console.WriteLine("employee Name: " + employee.Name);
            }
            #endregion
            #region Dictionary
            ////Converting Array into Dictionary:
            ////Employee[] employees = new Employee[] { employee1, employee2, employee3 };
            //List<Employee> employees = new List<Employee>() { employee1, employee2, employee3 };
            //Dictionary<int, Employee> employeeDictionary =  employees.ToDictionary(emp => emp.EmployeeId, emp => emp);
            //foreach (KeyValuePair<int, Employee> employee in employeeDictionary)
            //{
            //    Console.WriteLine("key is {0}", employee.Key);
            //    Console.WriteLine("Employee ID: {0}, Name: {1}, Salary: {2}", employee.Value.EmployeeId, employee.Value.Name, employee.Value.Salary);
            //    Console.WriteLine("-----------------------------------------------------------------------------------------------");
            //}
            ////Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>();
            ////employeeDictionary.Add(employee1.EmployeeId, employee1);
            ////employeeDictionary.Add(employee2.EmployeeId, employee2);
            ////employeeDictionary.Add(employee3.EmployeeId, employee3);

            ////Console.WriteLine("Total Employee in the Dictionary with salary greater than 7000 is: {0}",employeeDictionary.Count(kvp => kvp.Value.Salary > 7000));
            //////employeeDictionary.Remove(101);
            //////employeeDictionary.Clear();
            ////Employee employee103 = employeeDictionary[103];
            ////Employee employ102;
            ////if(employeeDictionary.TryGetValue(112, out employ102))
            ////{
            ////    Console.WriteLine("Employee with id 102 is present in dictionary and their details is:\nId: {0}\nName: {1}\nSalary: {2}", employ102.EmployeeId, employ102.Name, employ102.Salary);
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Employee with this ID Not Found in the dictionary");
            ////}
            ////Console.WriteLine("-----------------------------------------------------------------------------------------------");
            ////Console.WriteLine("Employee with Id 103 details: \nID: {0}\nName: {1}\nSalary:{2}", employee103.EmployeeId, employee103.Name, employee103.Salary);
            ////Console.WriteLine("-----------------------------------------------------------------------------------------------");
            ////foreach (KeyValuePair<int, Employee> employee in employeeDictionary)
            ////{
            ////    Console.WriteLine(employee.Key);
            ////    Employee emp = employee.Value;
            ////    Console.WriteLine("Employee Id: {0}\nEmployee Name: {1}\n Employee Salary: {2}", emp.EmployeeId, emp.Name, emp.Salary);
            ////    Console.WriteLine("-----------------------------------------------------------------------------------------------");
            ////}
            #endregion
            Console.ReadKey();
        }
    }

    #region Dictionary
    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
    #endregion
}
