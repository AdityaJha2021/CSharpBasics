using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryVsList
{
    class Program
    {
        static void Main(string[] args)
        {
            Country c1 = new Country { Code = "AUS", Name = "Australia", Capital = "Canberra" };
            Country c2 = new Country { Code = "IND", Name = "India", Capital = "New Delhi" };
            Country c3 = new Country { Code = "USA", Name = "United States", Capital = "Washington D.C" };
            Country c4 = new Country { Code = "GBR", Name = "United Kingdom", Capital = "London" };
            Country c5 = new Country { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };
            #region using List
            //List<Country> listCountries = new List<Country> { c1, c2, c3, c4, c5 };
            //string usrChoice = string.Empty;
            //do
            //{
            //    Console.WriteLine("Please enter a country Code");
            //    string strCountryCode = Console.ReadLine();

            //    Country resultCountry = listCountries.Find(x => x.Code == strCountryCode);

            //    if (resultCountry == null)
            //    {
            //        Console.WriteLine("Country code not valid");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Name: {0}, Capital: {1}", resultCountry.Name, resultCountry.Capital);
            //    }
            //    do
            //    {
            //        Console.WriteLine("Do you want to Continue - YES or NO");
            //        usrChoice = Console.ReadLine().ToUpper();
            //    } while (usrChoice != "NO" && usrChoice != "YES");

            //} while (usrChoice == "YES");
            #endregion

            #region Using Dictionary
            //Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            //dictionaryCountries.Add(c1.Code, c1);
            //dictionaryCountries.Add(c2.Code, c2);
            //dictionaryCountries.Add(c3.Code, c3);
            //dictionaryCountries.Add(c4.Code, c4);
            //dictionaryCountries.Add(c5.Code, c5);
            //string usrChoice = string.Empty;
            //do
            //{
            //    Console.WriteLine("Please enter the Country Code");
            //    string countryCode = Console.ReadLine().ToUpper();
            //    Country resultCountry;
            //    bool isValid = dictionaryCountries.TryGetValue(countryCode, out resultCountry);
            //    if(!isValid)
            //    {
            //        Console.WriteLine("Invalid country Code");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Country Name: {0} Capital: {1}", resultCountry.Name, resultCountry.Capital);
            //    }
            //    do
            //    {
            //        Console.WriteLine("Do you want to continue - YES or NO");
            //        usrChoice = Console.ReadLine().ToUpper();
            //    } while (usrChoice != "NO" && usrChoice != "YES");

            //} while (usrChoice == "YES");

            #endregion

            #region Queue FIFO
            //Queue<Country> countryQueue = new Queue<Country>();
            //countryQueue.Enqueue(c1);
            //countryQueue.Enqueue(c2);
            //countryQueue.Enqueue(c3);
            //countryQueue.Enqueue(c4);
            //countryQueue.Enqueue(c5);

            //Console.WriteLine("count of country object " + countryQueue.Count);
            //Country country = countryQueue.Dequeue();
            //Console.WriteLine("Country Name: {0} removed", country.Name);
            //Console.WriteLine("count of country object " + countryQueue.Count);
            //Country Latestcountry = countryQueue.Peek();
            //Console.WriteLine("The first country in the queue is:" + Latestcountry.Name);
            //Console.WriteLine("Is Dequeued country present: " + countryQueue.Contains(country));
            #endregion

            #region ArrayList
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Aditya");
            //arrayList.Add(2);
            //arrayList.Add(2.05);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack LIFO
            //Stack<Country> countryStack = new Stack<Country>();
            //countryStack.Push(c1);
            //countryStack.Push(c2);
            //countryStack.Push(c3);
            //countryStack.Push(c4);
            //countryStack.Push(c5);

            //Country firstCountry = countryStack.Peek();
            //Console.WriteLine("The first country present in the stack is: " + firstCountry.Name);

            //Country removedCountry = countryStack.Pop();
            //Console.WriteLine("{0} is removed from the county stack", removedCountry.Name);

            //Console.WriteLine("Do country stack contain poped country: " + countryStack.Contains(removedCountry));
            #endregion

            Console.ReadKey();
        }

        
    }

    class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}
