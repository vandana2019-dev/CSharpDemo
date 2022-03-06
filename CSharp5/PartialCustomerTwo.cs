using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp5
{
    public partial class PartialCustomer
    {
        public string getFullName()
        {
            return firstName + " " + lastName;
        }
        partial void SamplePartialMethod()
        {
            Console.WriteLine("Sample partial method invoked");
        }
    }
}