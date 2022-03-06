using System;
using System.Collections.Generic;

namespace CSharp7
{
    class Program
    {
       public static void Main(string[] args)
        {
            Country country1 = new Country() { Code = "AUS", Name = "Australia", Captial = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "India", Captial = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "United States", Captial = "Washington DC" };
            Country country4 = new Country() { Code = "GBR", Name = "United Kingdom", Captial = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "Canada", Captial = "Ottawa" };

            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);


            Console.WriteLine(" ** Part 81 When to use a dictionary **");

            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter country code");
                string countryCode = Console.ReadLine().ToUpper();

                Country resultCountry = listCountries.Find(country => country.Code == countryCode);
                Console.WriteLine("Using List Find to find an item");
                if (resultCountry == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Captial);
                }

                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO ?");
                    userChoice = Console.ReadLine().ToUpper();
                } while (userChoice != "NO" && userChoice != "YES");



                Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
                dictionaryCountries.Add(country1.Code, country1);
                dictionaryCountries.Add(country2.Code, country2);
                dictionaryCountries.Add(country3.Code, country3);
                dictionaryCountries.Add(country4.Code, country4);
                dictionaryCountries.Add(country5.Code, country5);

                Country resultCountryDict = dictionaryCountries.ContainsKey(countryCode) ? dictionaryCountries[countryCode] : null;
                Console.WriteLine("Using Dictionary ContainsKey");
                if (resultCountryDict == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Captial);
                }


            } while (userChoice == "YES");


            Console.WriteLine(" ** Part 82 Generic Queue **");
            // Create an instances of Customer Name class
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };
            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };

            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            Console.WriteLine(" Items in the Queue ");
            foreach (Customer customer in queueCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Gender);
            }
            Console.WriteLine("Total items in the Queue" + queueCustomers.Count);

            Console.WriteLine("Remove the first item in the Queue - using Dequeue");
            Customer c1 = queueCustomers.Dequeue();
            Console.WriteLine(c1.ID + " _" + c1.Name);
            Console.WriteLine("Total items in the Queue - using Dequeue =" + queueCustomers.Count);
            Console.WriteLine(" Items in the Queue after Dequeue");
            foreach (Customer customer in queueCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Gender);
            }

            Console.WriteLine("Remove the first item in the Queue - using Peek");
            Customer c2 = queueCustomers.Peek();
            Console.WriteLine(c2.ID + " _" + c2.Name);
            Console.WriteLine("Total items in the Queue using Peek =" + queueCustomers.Count);
            Console.WriteLine(" Items in the Queue after Peek");
            foreach (Customer customer in queueCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Gender);
            }

            if(queueCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 exists");
            }
            else
            {
                Console.WriteLine("customer1 does not exist");
            }

            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            Console.WriteLine(" ** Part 83 Generic Stack **");
            Console.WriteLine(" Items in the Stack ");
            foreach (Customer customer in stackCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Gender);
            }

            Customer customer6 = stackCustomers.Pop();
            Console.WriteLine(customer6.ID + " _" + customer6.Name);
            Console.WriteLine("Total items in the Stack using Pop =" + stackCustomers.Count);
            Console.WriteLine(" Items in the Stack after Pop ");
            //foreach (Customer customer in stackCustomers)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Gender);
            //}

            Customer customer7 = stackCustomers.Peek();
            Console.WriteLine(customer7.ID + " _" + customer7.Name);
            Console.WriteLine("Total items in the Stack using Peek =" + stackCustomers.Count);


            if (stackCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 exists");
            }
            else
            {
                Console.WriteLine("customer1 does not exist");
            }
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Captial { get; set; }
    }

    public class Customer  
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
