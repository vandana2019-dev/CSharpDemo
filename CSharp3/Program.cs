using System;
using System.IO;

namespace CSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Hello World!");
            //    Console.WriteLine("** Part 40 Exception Handling **");
            //    StreamReader streamReader = new StreamReader(@"C:\SampleFiles\Data1.txt");
            //    Console.WriteLine(streamReader.ReadToEnd());
            //    streamReader.Close();
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Please check if file exists {0}", ex.FileName);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine();
            //    Console.WriteLine(ex.StackTrace);
            //}


            //try
            //{
            //    Console.WriteLine("** Part 41 Exception Handling **");
            //    Console.WriteLine("Enter first number");
            //    int firstNumber = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter second number");
            //    int secondNumber = Convert.ToInt32(Console.ReadLine());

            //    int result = firstNumber / secondNumber;

            //    Console.WriteLine("Result = {0}", result);
            //}

            //catch (Exception ex)
            //{
            //    string filePath = @"C:\SampleFiles\Data1.txt";
            //    if(File.Exists(filePath))
            //    {
            //        StreamReader streamReader = new StreamReader(filePath);
            //        Console.WriteLine(streamReader.ReadToEnd());
            //        streamReader.Close();
            //        Console.WriteLine("There is a problem, please try again later");
            //        Console.WriteLine(ex.GetType());
            //    }
            //    else
            //    {
            //        throw new FileNotFoundException(filePath + " is not present", ex);
            //    }
            //}
            //Console.WriteLine("** Part 43 Exception Handling abuse **");
            //throw new UserAlreadyLoggedException("Userd is logged in - no duplication session allowed");

            //try
            //{
            //    Console.WriteLine("** Part 41 Exception Handling **");
            //    Console.WriteLine("Enter first number");
            //    int firstNumber = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter second number");
            //    int secondNumber = Convert.ToInt32(Console.ReadLine());

            //    int result = firstNumber / secondNumber;

            //    Console.WriteLine("Result = {0}", result);
            //}

            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter a number");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Only numbers between {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Denominator cannot be zero");
            //}


            try
            {
                Console.WriteLine("** Part 44 Exception Handling abuse handling **");
                Console.WriteLine("Enter first numerator");
                int numerator;
                bool isNumeratorSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);

                if (isNumeratorSuccessful)
                {
                    Console.WriteLine("Enter second denominator");
                    int denominator;
                    bool isDenominatorSuccessful = Int32.TryParse(Console.ReadLine(), out denominator);

                    if (isDenominatorSuccessful)
                    {
                        int result = numerator / denominator;
                        Console.WriteLine("Result = {0}", result);
                    }
                    else
                    {
                        if (denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numerator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public class UserAlreadyLoggedException : Exception
        {
            public UserAlreadyLoggedException() : base()
            {

            }
            public UserAlreadyLoggedException(string message) : base()
            {

            }
        }

    }
}
