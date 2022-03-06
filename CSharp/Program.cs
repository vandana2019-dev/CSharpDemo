using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 and 2
            Console.WriteLine("Please enter your name");
            // Read the data
            string userName = Console.ReadLine();
            Console.WriteLine("Your entered this name " + userName);

            // Part 3
            Console.WriteLine("Data Types");
            bool b = true;
            int a = 1;
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);


            double d = 0.42e2;    //double data type
            Console.WriteLine(d); // output 42

            float f = 134.45E-2f;  //float data type
            Console.WriteLine(f); // output: 1.3445

            decimal m = 1.5E6m;   //decimal data type
            Console.WriteLine(m); // output: 1500000


            // Part 4 
            string name = "pragim";
            Console.WriteLine(name);

            // We want to print the below double quotes in the console
            // \ whatever precedes the backslash, treat is a special character
            string name1 = "\"pragim";
            Console.WriteLine(name1);

            // we want to print the numbers one, two and three in different lines
            string lines = "One\nTwo\nThree";
            Console.WriteLine(lines);


            string escapeback = "One\\nTwo\\nThree";
            Console.WriteLine(escapeback);

            string verbatim1 = @"One\\nTwo\\nThree";
            Console.WriteLine(verbatim1);

            // Verbatim literals (@) make escape sequences translate as normal printable characters to enhance readability.
            string verbatim = @"One\nTwo\nThree";
            Console.WriteLine(verbatim);

            // Part 5 Common Operators in C#
            int a1 = 2;

            int num1 = 10;
            int num2 = 2;

            // Arithmetic operators
            int num3 = num1 + num2;
            int num4 = num1 - num2;
            int num5 = num1 * num2;
            int num6 = num1 / num2; // divide
            int num7 = num1 % num2; // remainder

            Console.WriteLine("first number is " + num1 + " second number is " + num2);

            Console.WriteLine($"sum is {num3} , difference is { num4} , product is {num5} , quotient  {num6} , remainder {num7}");


            // To compare if 2 numbers are
            // equal use comparison operator ==
            int number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is equal to 10");
            }

            // To compare if 2 numbers are not
            // equal use comparison operator !=
            if (number != 5)
            {
                Console.WriteLine("Number is not equal to 5");
            }

            // When && operator is used all the conditions must
            // be true for the code in the "if" block to be executed
            int number1 = 10;
            int number2 = 20;

            if (number1 == 10 && number2 == 20)
            {
                Console.WriteLine("Both conditions are true");
            }

            // When || operator is used the code in the "if" block
            // is excuted if any one of the condition is true
            number1 = 10;
            number2 = 21;

            if (number1 == 10 || number2 == 20)
            {
                Console.WriteLine("Atleast one of the condition is true");
            }


            // Program without Ternary operator
            int numberTernary = 10;
            bool isNumber10;
            if (numberTernary == 10)
            {
                isNumber10 = true;
            }
            else
            {
                isNumber10 = false;
            }
            Console.WriteLine("Number == 10 is {0}", isNumber10);

            // Ternary operator example
            isNumber10 = numberTernary == 10 ? true : false;
            Console.WriteLine("Using Ternary");
            Console.WriteLine("Number == 10 is {0}", isNumber10);


            // Part 6 Nullable Types
            int? i = null;
            bool? major = null;
            Console.WriteLine("Print nullable data types {0} {1} ", i, major); // since they are not values, they are not printed
            i = 9;
            major = true;
            Console.WriteLine("Print data types with values {0} {1} ", i, major);

            int AvailableTickets;
            int? TicketsOnSale = null;
            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale;
            }
            Console.WriteLine("Available Tickets={0}", AvailableTickets);

            //Using null coalesce operator ??
            AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("Available Tickets={0}", AvailableTickets);


            //Part 7  Datatypes Conversion
            int i7 = 100;
            // float is bigger datatype than int. So, no loss of data and exceptions. Hence implicit conversion
            float f7 = i7;
            Console.WriteLine("Data Type Conversion");
            Console.WriteLine(f7);

            f7 = 100.25F;
            // Cannot implicitly convert float to int. Fractional part will be lost. Float is a bigger datatype than int, so there is
            // also a possiblity of overflow exception
            // int i = f;

            // Use explicit conversion using cast () operator
            i7 = (int)f7;

            // OR use Convert class
            // int i = Convert.ToInt32(f);

            Console.WriteLine(i7);


            // Part 8 Arrays in C#
            // Initialize and assign values in different lines
            int[] EvenNumbers = new int[3];
            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;

            // Initialize and assign values in the same line
            int[] OddNumbers = { 1, 3, 5 };
            Console.WriteLine("Printing EVEN Numbers");

            // Retrieve and print even numbers from the array
            for (int i8 = 0; i8 < EvenNumbers.Length; i8++)
            {
                Console.WriteLine(EvenNumbers[i8]);
            }
            Console.WriteLine("Printing ODD Numbers");

            // Retrieve and print odd numbers from the array
            for (int j8 = 0; j8 < OddNumbers.Length; j8++)
            {
                Console.WriteLine(OddNumbers[j8]);
            }

            // Part 10 Comments

            // Part 11 If Statment
            Console.WriteLine("*** IF Statement ***");
            Console.WriteLine("Please enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            if(userNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }
            if (userNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }
            if (userNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }
            if (userNumber != 1 && userNumber != 2 && userNumber != 3)
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

            // Else if 
            // ***  If the first If is true, then it does not bother to go other else conditions
            if (userNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }
           else if (userNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }
           else if (userNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }
           else if (userNumber != 1 && userNumber != 2 && userNumber != 3)
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

            // if the 1st condition is true, then only the 2nd condition is run
            if(userNumber == 1 || userNumber == 2 )
            {
                Console.WriteLine("Your number is either 1 or 2");
            }
            Console.WriteLine("*** Switch Statement ***");
            // Part 11 Switch Statement, the above if or if else statement can be written as the below switch statement
            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("Your number is 1");
                    break;
                case 2:
                    Console.WriteLine("Your number is 2");
                    break;
                case 3:
                    Console.WriteLine("Your number is 3");
                    break;
                default:
                    Console.WriteLine("Your number is not 1, 2 & 3");
                    break;
            }

            // Switch Statement
            switch (userNumber)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your number is {0}", userNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 1, 2 & 3");
                    break;
            }

            // Part 13 - While Loop
            Console.WriteLine("** While loop **");
            Console.WriteLine("Please enter your target");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;
            while(start <= userTarget)
            {
                Console.WriteLine(start);
                start = start + 2;
            }


            // Part 14 - Do While
            string userChoice = "";
            do
            {
                Console.WriteLine("Do you want to Continue?");
                userChoice = Console.ReadLine();
                if(userChoice != "Yes" && userChoice != "No")
                {
                    Console.WriteLine("Invalid Choice, please say yes or no");
                }

            } while (userChoice != "Yes" && userChoice != "No");

            // Part 15 - For and For each loop
            Console.WriteLine("** For loop **");
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            int i15 = 0;
            while(i15 < numbers.Length)
            {
                Console.WriteLine(numbers[i15]);
                i15++;
            }
            Console.WriteLine("** for loop **" );
            // the same can be in for loop
            for (int j15 = 0; j15<numbers.Length; j15++)
            {
                Console.WriteLine(numbers[j15]);
            }

            // for each
            Console.WriteLine("** for each loop **");
            foreach (int k in numbers)
            {
                Console.WriteLine(k);
            }

            // for continue
            Console.WriteLine("** continue **");
            for (int j15 = 0; j15 < numbers.Length; j15++)
            {
                if (j15 % 2 == 1)
                    continue;

                Console.WriteLine(numbers[j15]);
            }

        
        }

      
    }
}
