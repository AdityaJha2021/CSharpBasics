using System;
using System.Reflection;

namespace ReflactionBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Reflection
            ////Type T = typeof(System.Console);
            ////string s = T.Assembly.FullName.ToString();
            ////Console.WriteLine("The fully qualified assembly name " +
            ////    "containing the specified class is {0}.", s);
            //Console.WriteLine();
            ////Type T = Type.GetType("ReflactionBasic.Customer");
            //Type T = Type.GetType("System.Int32");
            //Customer c = new Customer();
            ////Type T = typeof(Customer);
            ////Type T = c.GetType();
            //PropertyInfo[] propertyInfo = T.GetProperties();
            //foreach(PropertyInfo property in propertyInfo)
            //{
            //    Console.WriteLine("Type: {0}, Name: {1}", property.PropertyType, property.Name);
            //}
            //Console.WriteLine();
            //Console.Beep();
            //MethodInfo[] methodInfos = T.GetMethods();
            //foreach (MethodInfo method in methodInfos)
            //{
            //    Console.WriteLine("Method Name: {0}, Return Type: {1}", method.Name, method.ReturnType.Name);
            //}
            //Console.WriteLine();
            //ConstructorInfo[] constructorInfos = T.GetConstructors();
            //foreach (ConstructorInfo constructor in constructorInfos)
            //{
            //    Console.WriteLine("Constructor Name: {0}", constructor.ToString());
            //}
            #endregion

            #region Early binding, making object during compile time
            //Customer c = new Customer();
            //c.PrintFullName("Aditya", "Prakash");
            #endregion

            #region Late Binding, Making object at runtime
            //Load Assembly
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            //Type info of customer class/Type
            Type T = executingAssembly.GetType("ReflactionBasic.Customer");

            //Making object/Instance 
            object customerObject = Activator.CreateInstance(T);

            MethodInfo PrintFullNameMethod = T.GetMethod("PrintFullName");

            string[] parameters = new string[2];
            parameters[0] = "Aditya";
            parameters[1] = "Jha";

            string fullName = (string)PrintFullNameMethod.Invoke(customerObject, parameters);
            Console.WriteLine("Hello {0} - This is late Binding Example.", fullName);
            #endregion
            Console.ReadKey();
        }
    }
    class Customer
    {
        public void PrintFullName(string FirstName, string LastName)
        {
            Console.WriteLine("Welcome {0} {1}", FirstName, LastName);
        }

        #region reflection
        //public Customer()
        //{
                    
        //}
        //public Customer(int a, string b)
        //{

        //}
        //public int CustID { get; set; }
        //public string Name { get; set; }

        //public void PrintName()
        //{
        //    Console.WriteLine("Name: {0}", Name);
        //}
        //public void CustomerInfo()
        //{
        //    Console.WriteLine("Name: {0}, Customer ID: {}", Name, CustID);
        //}
        #endregion
    }

}
