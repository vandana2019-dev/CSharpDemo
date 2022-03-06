using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static CSharp6.CustomerName;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("*** Part 77 - Sort a list Simple Type ***");
            Console.WriteLine("Numbers before sorting");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();
            Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();
            Console.WriteLine("Numbers after sorting in reverse order");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Create a list of strings
            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
            Console.WriteLine("Alphabets before sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();
            Console.WriteLine("Alphabets after sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();
            Console.WriteLine("Alphabets after sorting in descending order");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }


            // Create an instances of Customer class
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };


            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("*** Sorting Complex type - Class ***");
            Console.WriteLine("Before sorting");
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            listCustomers.Sort();
            Console.WriteLine("After sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            listCustomers.Reverse();
            Console.WriteLine("After sorting in reverse order");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }


            // Create an instances of Customer Name class
            CustomerName customerName1 = new CustomerName()
            {
                ID = 101,
                Name = "Zoy",
                Salary = 4000
            };

            CustomerName customerName2 = new CustomerName()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            CustomerName customerName3 = new CustomerName()
            {
                ID = 103,
                Name = "A",
                Salary = 5500
            };

            List<CustomerName> listCustomerNames = new List<CustomerName>();
            listCustomerNames.Add(customerName1);
            listCustomerNames.Add(customerName2);
            listCustomerNames.Add(customerName3);

            Console.WriteLine("***Part 78 Sorting Complex type - Class with Name Property ***");
            Console.WriteLine("Before sorting");
            foreach (CustomerName c in listCustomerNames)
            {
                Console.WriteLine(c.Name);
            }

            listCustomerNames.Sort();
            Console.WriteLine("After sorting");
            foreach (CustomerName c in listCustomerNames)
            {
                Console.WriteLine(c.Name);
            }

            listCustomerNames.Reverse();
            Console.WriteLine("After sorting in reverse order");
            foreach (CustomerName c in listCustomerNames)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("Sorting by Name using SortByName");
            SortByName sortByName = new SortByName();
            listCustomerNames.Sort(sortByName);
            foreach (CustomerName c in listCustomerNames)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("*** Part 80 Useful methods of List collection class ***");
            Console.WriteLine("Are all salaries greater than 5000 " + listCustomerNames.TrueForAll(x => x.Salary > 5000));

            Console.WriteLine("Are all salaries greater than 3000 " + listCustomerNames.TrueForAll(x => x.Salary > 3000));

            ReadOnlyCollection<CustomerName> readOnlyCustomer = listCustomerNames.AsReadOnly();
            Console.WriteLine("Items = " + readOnlyCustomer.Count);


            List<CustomerName> listCustomerNames2 = new List<CustomerName>(100);
            listCustomerNames2.Add(customerName1);
            listCustomerNames2.Add(customerName2);
            listCustomerNames2.Add(customerName3);

            Console.WriteLine("Capacity before trimming = " + listCustomerNames2.Capacity);
            listCustomerNames2.TrimExcess();
            Console.WriteLine("Capacity after trimming = " + listCustomerNames2.Capacity);
        }
    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else
            //    return 0;


            // The above lines can be replaced by
            return this.Salary.CompareTo(other.Salary);
        }
    }

    public class CustomerName : IComparable<CustomerName>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(CustomerName other)
        {
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else
            //    return 0;

            // The above lines can be replaced by
            return this.Name.CompareTo(other.Name);
        }

      
    }

    public class SortByName : IComparer<CustomerName>
    {
        public int Compare(CustomerName x, CustomerName y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
