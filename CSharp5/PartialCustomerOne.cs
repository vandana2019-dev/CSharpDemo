using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp5
{
    public partial class  PartialCustomer 
    {
        private string firstName;
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        partial void SamplePartialMethod();
         
        public void PublicMethod()
        {
            Console.WriteLine("Public method invoked");
            SamplePartialMethod();
        }
    }
}
