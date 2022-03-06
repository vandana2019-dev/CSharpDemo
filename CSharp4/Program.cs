using System;

namespace CSharp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" *** Part 45 Why Enums *** ");
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = 2
            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = 0
            };

            foreach(Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
            }


            Console.WriteLine(" *** Part 45 Enums  Example *** ");
            CustomerEnum[] customerEnum = new CustomerEnum[3];

            customerEnum[0] = new CustomerEnum
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customerEnum[1] = new CustomerEnum
            {
                Name = "Mary",
                Gender = Gender.Female
            };
            customerEnum[2] = new CustomerEnum
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };

            foreach (CustomerEnum customerEnum1 in customerEnum)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customerEnum1.Name, GetGenderEnum(customerEnum1.Gender));
            }

            Console.WriteLine(" *** Part 47 Enums*** ");
            int[] values = (int[])Enum.GetValues(typeof(Gender));

            foreach(int value in values)
            {
                Console.WriteLine(value);
            }

            string[] names = Enum.GetNames(typeof(Gender));
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            short[] valuesShort = (short[])Enum.GetValues(typeof(GenderShort));
            foreach (int value in valuesShort)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(" *** Part 48 Types and Type members *** ");
            CustomerType customerType = new CustomerType();
            customerType.Id = 10;
            customerType.FirstName = "Mark";
            customerType.LastName = "CCC";

            Console.WriteLine(customerType.GetFullName());


        }

        public static string GetGender(int gender)
        {
            switch(gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }

        public static string GetGenderEnum(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public enum GenderShort : short
    {
        Unknown,
        Male,
        Female
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }

    public class CustomerEnum
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    public class CustomerType
    {
        #region Fields
        private int id;
        private string firstName;
        private string lastName;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }
        #endregion
    }
}
