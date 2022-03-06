using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **  Part 56 Generics ** ");
            bool equal = Calculator.AreEqual(1, 2);
            bool equal2 = Calculator.AreEqualBool("1", "2");
            bool equal3 = Calculator.AreEqualGeneric<int>(10, 10);
            bool equal4 = Calculator.AreEqualGeneric<string>("age", "age2");

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            if (equal4)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.WriteLine(" **  Part 57 Override to string ** ");
            CustomerName c1 = new CustomerName();
            c1.FirstName = "Simon";
            c1.LastName = "Tam";

            Console.WriteLine(c1.ToString());

            // Another option
            Console.WriteLine(Convert.ToString(c1));

            Console.WriteLine(" **  Part 58 Override to equals ** ");
            int i = 10;
            int j = 10;

            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;

            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));


            CustomerName c2 = c1;
            Console.WriteLine("c1 and c2 refers to the same object");
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));


            CustomerName c3 = new CustomerName();
            c3.FirstName = "Simon";
            c3.LastName = "Tam";

            Console.WriteLine("c1 and c3 refers to the different object");
            Console.WriteLine(c1 == c3);
            Console.WriteLine(c1.Equals(c3));

            Console.WriteLine(" **  Part 59 Convert.ToString() and ToString() ** ");
            Customer c4 = new Customer();
            string str = c4.ToString();
            Console.WriteLine(str);

            Customer c5 = new Customer();
            string str5 = Convert.ToString(c5);
            Console.WriteLine(str5);

            // Here we get null reference exception
            //Customer c6 = null;
            //string str6 = c6.ToString();
            //Console.WriteLine(str6);

            Customer c7 = null;
            string str7 = Convert.ToString(c7);
            Console.WriteLine("Using Convert " + str7); // Convert.ToString converts to empty string

            Console.WriteLine(" **  Part 60 Difference between string and string builder ** ");
            string userString = "C#";
            userString += " video";
            userString += " tutorial";
            userString += " for";
            userString += " beginners";
            Console.WriteLine(userString);

            Console.WriteLine("Using string builder");
            StringBuilder userString2 = new StringBuilder("C#");
            userString2.Append(" video");
            userString2.Append(" tutorial");
            userString2.Append(" for");
            userString2.Append(" beginners");
            Console.WriteLine(userString2);

            Console.WriteLine(" ** Part 60 and Part 61 Partial classes and partial methods **");
            PartialCustomer partialCustomer = new PartialCustomer();
            partialCustomer.FirstName = "FirstName";
            partialCustomer.LastName = "Lname";
            Console.WriteLine(partialCustomer.getFullName());


            Console.WriteLine(" ** Part 63 Partial methods **");
            PartialCustomer partialCustomer1 = new PartialCustomer();
            partialCustomer1.PublicMethod();


            Console.WriteLine(" ** Part 72 Dictionary **");
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            Customer customer5 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };

            Customer customer6 = new Customer()
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            // The keys in a dictionary should always be unique
            // To check if the key exists , check the below condition

            if (!dictionaryCustomers.ContainsKey(customer1.ID))
            {
                dictionaryCustomers.Add(customer1.ID, customer1);
            }


            Customer customer4 = dictionaryCustomers[119];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer4.ID, customer4.Name, customer4.Salary);


            foreach (KeyValuePair<int, Customer> keyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("ID = {0}", keyValuePair.Key);
                Customer customer = keyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
                Console.WriteLine("-------------------------------------------------");
            }


            Console.WriteLine("*** Print Dictionary keys ***");
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("*** Print Dictionary values ***");
            foreach (Customer customerDictionary4 in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customerDictionary4.ID, customerDictionary4.Name, customerDictionary4.Salary);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("*** Part 73 Dictionary Continued ***");
            if (dictionaryCustomers.TryGetValue(110, out customer1))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer1.ID, customer1.Name, customer1.Salary);
            }
            else
            {
                Console.WriteLine("The key is not found");
            }

            Console.WriteLine("Dictionary total items = {0}", dictionaryCustomers.Count);
            //dictionaryCustomers.Remove(119); // removes 1 item from the dictionary
            //dictionaryCustomers.Clear(); // clears all items

            Console.WriteLine("*** Part 74 List Collection ***");
            List<Customer> lstCustomerDictionaries = new List<Customer>(3);
            lstCustomerDictionaries.Add(customer1);
            lstCustomerDictionaries.Add(customer2);
            lstCustomerDictionaries.Add(customer3);

            // Insert at specific index
            //lstCustomerDictionaries.Insert(0, customerDictionary3);

            Customer customerDictionary5 = lstCustomerDictionaries[0];
            Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", customerDictionary5.ID, customerDictionary5.Name, customerDictionary5.Salary);

            Console.WriteLine("** for loop List ***");

            for (int i10 = 0; i10 < lstCustomerDictionaries.Count; i10++)
            {
                Customer customerDictionary4 = lstCustomerDictionaries[i10];
                Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", customerDictionary4.ID, customerDictionary4.Name, customerDictionary4.Salary);
            }

            Console.WriteLine("** for each loop ***");
            foreach (var item in lstCustomerDictionaries)
            {
                Console.WriteLine(item.ID);
            }

            Console.WriteLine("Index of customerDictionary3 {0} ", lstCustomerDictionaries.IndexOf(customer3));
            Console.WriteLine("Index of customerDictionary1 {0} ", lstCustomerDictionaries.IndexOf(customer1));

            if(lstCustomerDictionaries.Contains(customer1))
            {
                Console.WriteLine("customerDictionary1 exists in the list");
            }
            else
            {
                Console.WriteLine("customerDictionary3 does exists in the list");
            }

            if (lstCustomerDictionaries.Exists(cust => cust.Name.StartsWith("P")))
            {
                Console.WriteLine("customerDictionaries contains item that starts with P");
            }
            else
            {
                Console.WriteLine("customerDictionaries contains item that does not starts with P");
            }

            if (lstCustomerDictionaries.Exists(cust => cust.Name.StartsWith("Z")))
            {
                Console.WriteLine("customerDictionaries contains item that starts with Z");
            }
            else
            {
                Console.WriteLine("customerDictionaries contains item that does not starts with Z");
            }

            Console.WriteLine("Salary of the customer greater than 3000 (Find the first customer)");
            Customer customerDictionary6 =  lstCustomerDictionaries.Find(customerDictionary => customerDictionary.Salary > 3000);
            Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", customerDictionary6.ID, customerDictionary6.Name, customerDictionary6.Salary);


            Customer customerDictionary7 = lstCustomerDictionaries.FindLast(customerDictionary => customerDictionary.Salary > 3000);
            Console.WriteLine("Salary of the last customer greater than 3000 (Find the last customer)");
            Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", customerDictionary7.ID, customerDictionary7.Name, customerDictionary7.Salary);


            Console.WriteLine("List of Customers by FindAll");
            List<Customer> customerDictionary8 = lstCustomerDictionaries.FindAll(customerDictionary => customerDictionary.Salary > 3000);
            foreach (var item in customerDictionary8)
            {
                Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", item.ID, item.Name, item.Salary);
            }

            Console.WriteLine("List of Customers by Index");
            // finds the first index
            var index = lstCustomerDictionaries.FindIndex(customerDictionary => customerDictionary.Salary > 3000);
            Console.WriteLine("Index of customers with salary greater than 3000 is {0} ", index);


            Console.WriteLine("List of Customers by Last Index");
            var indexLast = lstCustomerDictionaries.FindLastIndex(customerDictionary => customerDictionary.Salary > 3000);
            Console.WriteLine("Index of customers with salary greater than 3000 is {0} ", indexLast);

            Customer[] customerArray = new Customer[3];
            customerArray[0] = customer1;
            customerArray[1] = customer2;
            customerArray[2] = customer3;

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            listCustomers.ToArray();

            //Dictionary<int, CustomerDictionary> dictionary = listCustomers.ToD

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer5);
            listCorporateCustomers.Add(customer6);

            listCustomers.AddRange(listCorporateCustomers);

            Console.WriteLine("** Part 76 - Generic List **");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            Console.WriteLine("** Using Insert Range **");
            listCustomers.InsertRange(0, listCorporateCustomers);

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            Console.WriteLine("** Remove List Item **");
            listCustomers.Remove(customer1);
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("** RemoveAt List Item **");
            listCustomers.RemoveAt(5);
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name ={1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
        }

    }

    public class Calculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }

        public static bool AreEqualBool(object value1, object value2)
        {
            return value1 == value2;
        }

        public static bool AreEqualGeneric<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    public class CustomerName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((CustomerName)obj).FirstName &&
                   this.LastName == ((CustomerName)obj).LastName;
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.FirstName.GetHashCode();
        }
    }

    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }
}
