using System;
using PATA = ProjectA.TeamA; // namespaces alias
using PATB = ProjectA.TeamB;


namespace CSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 16 - Methods
            Console.WriteLine("** Methods **");

            Program p = new Program();
            Console.WriteLine("** Even numbers **");
            p.evenNumbers();
            Console.WriteLine("** Odd Numbers **");
            oddNumbers();

            int sum = p.add(10, 20);
            Console.WriteLine("Sum = {0}", sum);

            // Part 17 - Method Parameters
            Console.WriteLine("** Method Paramters **");

            int i17 = 0;
            SimpleMethod(i17);
            Console.WriteLine(i17);

            SimpleMethodRef(ref i17);
            Console.WriteLine(i17);

            int total = 0;
            int product = 0;
            Calculate(10, 20, out total, out product);
            Console.WriteLine("Number are 10, 20 Sum = {0} && Product = {1}", total, product);

            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            paramsMethod(numbers); // if params is mentioned we need to always pass the parameters
            paramsMethod2();
            paramsMethod3(7); // arguments
                              // paramsMethod3(); // need to pass the other parameter


            Console.WriteLine("** Namespaces example **");
            ProjectA.TeamA.ClassA.Print();
            ProjectA.TeamB.ClassA.Print();

            PATA.ClassA.Print();
            PATB.ClassA.Print();


            // Class Part 19
            Console.WriteLine("** Classes example **");
            Customer c1 = new Customer(); // default parameter less constructor
            Customer c2 = new Customer("Apeksha", "Logi");
            c1.PrintFullName();
            c2.PrintFullName();

            Customer c3 = new Customer("Apoorva", "Logi");
            c3.PrintFullName();

            // overloading constructor - by the number and type of the parameters


            // Part 20 Static and Instance class
            Console.WriteLine("** Static class example **");
            Circle circle1 = new Circle(5);
            float area1 = circle1.CalculateArea();

            Console.WriteLine("Area = {0}", area1);


            Circle circle2 = new Circle(6);
            float area2 = circle2.CalculateArea();

            Console.WriteLine("Area = {0}", area2);

            CircleStatic circleStatic = new CircleStatic(5);
            circleStatic.CalculateArea();

            // Part 21 Inheritance
            Console.WriteLine("** Part 21 Inheritance **");
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.firstName = "apeksha";
            fte.lastName = "logi";
            fte.yearlySalary = 50000;
            fte.PrintFullName();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.firstName = "apoorva";
            pte.lastName = "logi";
            pte.hourlyRate = 40;
            pte.PrintFullName();

            ChildClass cc = new ChildClass();

            // Part 22 Method hiding
            Console.WriteLine("**  Part 22 Method hiding **");
            Employee22 employee22 = new Employee22();
            employee22.firstName = "Fulltime";
            employee22.lastName = "employee";
            employee22.PrintFullName();


            PartTimeEmployee22 partTimeEmployee22 = new PartTimeEmployee22();
            partTimeEmployee22.firstName = "Partime";
            partTimeEmployee22.lastName = "employee";
            partTimeEmployee22.PrintFullName();

            // Part 23 Polymorphism
            Console.WriteLine("**  Part 23 Polymorphism **");
            Employee23[] employees23 = new Employee23[4];

            employees23[0] = new Employee23();
            employees23[0].firstName = "fname";
            employees23[0].lastName = "lname";

            employees23[1] = new PartTimeEmployee23();
            employees23[1].firstName = "partimefname1";
            employees23[1].lastName = "partimelname1";

            employees23[2] = new FullTimeEmployee23();
            employees23[2].firstName = "fulltimefname1";
            employees23[2].lastName = "fulltimelname1";

            employees23[3] = new TemporaryEmployee23();
            employees23[3].firstName = "temptimefname1";
            employees23[3].lastName = "temptimelname1";

            foreach (Employee23 e in employees23)
            {
                // Here, only the derived class method is called
                e.PrintFullName();
            }

            // Part 24 Method overridding vs Method Hiding
            Console.WriteLine("**  Part 24 Method overridding vs Method Hiding **");
            BaseClass24 baseClass24 = new DerivedClass24override();
            baseClass24.Print();

            BaseClass24 baseClass24new = new DerivedClass24new();
            baseClass24new.Print();


            //Part 25 MethodOverloading
            Console.WriteLine("**  Part 25 MethodOverloading  **");
            MethodOverloading.Add(5, 6);
            MethodOverloading.Add(5.5f, 5.0f);
            MethodOverloading.Add(5, 6, out sum);
            Console.WriteLine("Sum using out parameter = {0}", sum);

            //Part 26 Why Properties
            Console.WriteLine("**  Part 26 Propeties  **");
            Student s1 = new Student();
            s1.ID = -101;
            //s1.Name = null;
            s1.passMark = 0;
            Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}", s1.ID, s1.Name, s1.passMark);

            //s1.GetPassMark();
            //s1.setId(10);
            //s1.setName("");

            Console.WriteLine("Student Pass mark = {0}", s1.GetPassMark());
            //Console.WriteLine("Student Id = {0}", s1.getId());
            //Console.WriteLine("Student Name = {0}", s1.getName());

            //Part 27  Properties
            Console.WriteLine("**  Part 27 Properties  **");
            StudentProp studentProp = new StudentProp();
            studentProp.Id = 101;
            studentProp.Name = "vanda";
          
            Console.WriteLine("StudentProp Id = {0}", studentProp.Id);
            Console.WriteLine("StudentProp Name = {0}", studentProp.Name);
            Console.WriteLine("StudentProp GetPassMark = {0}", studentProp.GetPassMark);

            // Part 28 Structs
            Console.WriteLine("**  Part 28 Structs  **");
            CustomerStruct customerStruct = new CustomerStruct(101, "Mark");
            customerStruct.PrintDetails();

            // Using the properties of the structure to initialize the fields
            CustomerStruct customerStruct2 = new CustomerStruct();
            customerStruct2.ID = 101;
            customerStruct2.Name = "John";
            customerStruct2.PrintDetails();

            CustomerStruct customerStruct3 = new CustomerStruct
            {
                ID = 104,
                Name = "Rob"
            };
            customerStruct3.PrintDetails();

            // Part 30 Interfaces
            Console.WriteLine("**  Part 30 Interfaces  **");
            CustomerInterface customerInterface = new CustomerInterface();
            customerInterface.Print();
            customerInterface.I2Method();
            customerInterface.Print2();

            // Part 31 Interfaces
            Console.WriteLine("**  Part 31 Explicit Interfaces  **");
            ClassFromInterfaces1 classFromInterfaces1 = new ClassFromInterfaces1();
            classFromInterfaces1.InterfaceMethod();

            // Explicitly call an interface method
            Console.WriteLine("**  Explicitly call same Interfaces methods **");
            ((Interface1)classFromInterfaces1).InterfaceMethod();
            ((Interface2)classFromInterfaces1).InterfaceMethod();

            ClassFromInterfaces2 classFromInterfaces2 = new ClassFromInterfaces2();
            // Explicitly call an interface method
            Console.WriteLine("**  Explicitly call From same Interfaces methods - implemented differently **");
            ((Interface1)classFromInterfaces2).InterfaceMethod();
            ((Interface2)classFromInterfaces2).InterfaceMethod();

            // Call interface methods using class
            Interface1 interface1 = new ClassFromInterfaces2();
            Interface2 interface2 = new ClassFromInterfaces2();

            Console.WriteLine("**  Call the class methods using the Interface reference **");
            interface1.InterfaceMethod();
            interface2.InterfaceMethod();


            // Making an interface method default
            Console.WriteLine("**  Explicitly call From same Interfaces methods - implemented differently **");
            ((Interface1)classFromInterfaces2).InterfaceMethod();
            ((Interface2)classFromInterfaces2).InterfaceMethod();


            // Call the default interface method
            Console.WriteLine("**  Explicitly call From same Interfaces methods - default method **");
            ClassFromInterfaces3 classFromInterfaces3 = new ClassFromInterfaces3();
            classFromInterfaces3.InterfaceMethod(); // default implementation is called
            ((Interface2)classFromInterfaces3).InterfaceMethod();

            // Abstract class
            Console.WriteLine("**  Call the class methods using the Abstract class **");
            CustomerClassAbstract1 customerClassAbstract1 = new CustomerClassAbstract1();
            customerClassAbstract1.Print();

            CustomerClassAbstract1 customerAbstract2 = new CustomerClassAbstract1();
            customerAbstract2.Print();

            CustomerClassAbstract2 customerAbstract3 = new CustomerClassAbstract2();
            customerAbstract3.Print();

            // Multiple class inheritance using interfaces
            Console.WriteLine("**  Multiple class inheritance using interfaces **");
            MutlipleInheritanceClassAB mutlipleInheritanceClassAB = new MutlipleInheritanceClassAB();
            mutlipleInheritanceClassAB.AMethod();
            mutlipleInheritanceClassAB.BMethod();
        }

        #region Part 16 and Part 17 Method and Method parameters
        public void evenNumbers()
        {
            int start = 0;
            while (start <= 5)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public static void oddNumbers()
        {
            int start = 0;
            while (start <= 5)
            {
                Console.WriteLine(start);
                start = start + 1;
            }
        }

        public int add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static void SimpleMethod(int j)
        {
            j = 101;
        }

        public static void SimpleMethodRef(ref int j)
        {
            j = 101;
        }

        // out methods must be set
        public static void Calculate(int firstNumber, int secondNumber, out int Sum, out int Product)
        {
            Sum = firstNumber + secondNumber;
            Product = firstNumber * secondNumber;

        }

        public static void paramsMethod(int[] numbers)
        {
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        public static void paramsMethod2(params int[] numbers) // params array has to be the last one in the list of parameters
        {
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        // public static void paramsMethod3(params int[] numbers, int j) // params array has to be the last one in the list of parameters
        public static void paramsMethod3(int j, params int[] numbers) // parameters
        {
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        #endregion

    }

}

#region Part 18 Namespaces
namespace ProjectA.TeamA
{
    class ClassA
    {
        public static void Print()
        {
            Console.WriteLine("This is Team A Print method");
        }
    }
}

namespace ProjectA.TeamB
{
    class ClassA
    {
        public static void Print()
        {
            Console.WriteLine("This is Team B Print method");
        }
    }
}
#endregion

#region Part 19 Class
public class Customer
{
    string firstName;
    string lastName;

    //public Customer()
    //{

    //}
    public Customer() : this("No First name provided", "No last name provided") // set the default values of the constructor
    {

    }
    public Customer(string FirstName, string LastName) // constructor
    {
        // this refers to the instance(object) of the class Customer
        this.firstName = FirstName;
        this.lastName = LastName;
    }

    // Behavior - do something on the class
    public void PrintFullName()
    {
        Console.WriteLine("Full name = {0}", this.firstName + " " + this.lastName);
    }

    ~Customer()
    {
        // clean up code
    }


}
#endregion

#region Part 20 Static class
public class Circle
{
    float pi = 3.14F;
    int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public float CalculateArea()
    {
        return this.pi * this.radius * this.radius;
    }


}

public class CircleStatic
{
    static float pi = 3.14F;
    int radius;

    static CircleStatic() // static method can access only static variables
    {
        Console.WriteLine("Static Constructor Called");
        CircleStatic.pi = 3.14f;
        // We cannot access radius here
    }
    public CircleStatic(int radius)
    {
        Console.WriteLine("Instance Constructor Called");
        this.radius = radius;
    }

    public float CalculateArea()
    {
        return CircleStatic.pi * this.radius * this.radius;
    }


}


#endregion

#region Part 21 Inheritance
public class Employee
{
    public string firstName;
    public string lastName;
    public string email;

    public void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float yearlySalary;
}
public class PartTimeEmployee : Employee
{
    public float hourlyRate;
}


// multilevel inheritance
public class A : PartTimeEmployee
{
    public float partTimeA;
}



public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent class constructor called");
    }
    public ParentClass(string message)
    {
        Console.WriteLine("Parent class constructor called");
    }
}
public class ChildClass : ParentClass
{
    //public ChildClass()
    //{
    //    Console.WriteLine("Child class constructor called");
    //}

    public ChildClass() : base("Derived class controlling parent class")
    {
        Console.WriteLine("Child class constructor called");
    }
}



#endregion


#region Part 22 Method Hiding
public class Employee22
{
    public string firstName;
    public string lastName;
    public string email;

    public void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}

public class FullTimeEmployee22 : Employee22
{
    public float yearlySalary;
}
public class PartTimeEmployee22 : Employee22
{
    public float hourlyRate;
    public new void PrintFullName() // hides the base method
    {
        Console.WriteLine(firstName + " " + lastName + " PartTimeEmployee22");
    }
}


// multilevel inheritance
public class A22 : PartTimeEmployee22
{
    public float partTimeA;
}

#endregion


#region Part 23 Polymorphism
public class Employee23
{
    public string firstName;
    public string lastName;
    public string email;

    public virtual void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName + " Employee23");
    }
}

public class FullTimeEmployee23 : Employee23
{
    public float yearlySalary;
    public override void PrintFullName() // overrides the base method
    {
        Console.WriteLine(firstName + " " + lastName + " FullTimeEmployee23");
    }
}
public class PartTimeEmployee23 : Employee23
{
    public float hourlyRate;
    public override void PrintFullName() // overrides the base method
    {
        Console.WriteLine(firstName + " " + lastName + " PartTimeEmployee23");
    }
}

public class TemporaryEmployee23 : Employee23
{
    public float hourlyRate;
    // here the derived class does not override the base class, then the base class one is called when we call the derived method
    //public override void PrintFullName() // overrides the base method
    //{
    //    Console.WriteLine(firstName + " " + lastName + " TemporaryEmployee23");
    //}
}

#endregion


#region 24 Method overriding vs Method Hiding
public class BaseClass24
{
    public virtual void Print()
    {
        Console.WriteLine("Base class print method");
    }
}

public class DerivedClass24override : BaseClass24
{
    public override void Print()
    {
        Console.WriteLine("Child class print method - using override");
    }
}

public class DerivedClass24new : BaseClass24
{
    public override void Print()
    {
        Console.WriteLine("Base class print method - using new");
    }
}




#endregion

#region Part 25 Method overloading

public class MethodOverloading
{

    public static void Add(int fn, int sn)
    {
        Console.WriteLine("Sum = {0}", fn + sn);
    }

    public static void Add(float fn, float sn)
    {
        Console.WriteLine("Sum = {0}", fn + sn);
    }
    public static void Add(int fn, int sn, out int sum)
    {
        //Console.WriteLine("Sum = {0}", fn + sn);
        sum = fn + sn;
    }

}


#endregion

#region Part 25 Why Properties
public class Student
{
    public int ID;
    public string Name;
    public int passMark = 35;

    private int id;

    public int GetPassMark()
    {
        return this.passMark;
    }
    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be null or empty");
        }
        this.Name = name;
    }
    public string getName()
    {
        return string.IsNullOrEmpty(this.Name) ? "No Name" : this.Name;
    }

    public void setId(int id)
    {
        if (id < 0)
        {
            throw new Exception("Student Id should be greater than zero");
        }
        this.id = id;
    }
    public int getId()
    {
        return id;
    }
}


#endregion


#region Part 26 Properties
public class StudentProp
{
    private int id;
    private string name;
    private int passMark = 35;

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Name cannot be null or empty");
            }
            this.id = value;
        }
        get
        {
            return this.id;
        }
    }
    public int GetPassMark
    {
        get
        {
            return this.passMark;
        }
    }
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this.name = value;
        }
        get
        {
            return string.IsNullOrEmpty(name) ? "No name" : this.name;
        }
    }
}
#endregion

#region Part 28 Structs

public struct CustomerStruct
{
    private int id;
    private string name;

    public string Name 
    {
        get { return name; }
        set { name = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }
    public CustomerStruct(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this.id, this.name);
    }

}


#endregion

#region Part 30 Interfaces
interface ICustomer
{
   void Print();
}

interface I2
{
    void I2Method();
}

interface ICustomer2
{
    void Print2();
}

// A class can inherit multiple interfaces at the same time
// One interface inherits another interface, then the class needs to implements the methods in both the interfaces
public class CustomerInterface : ICustomer, I2, ICustomer2
{
    public void Print()
    {
        Console.WriteLine("Interface Public");
    }
    public void I2Method()
    {
        Console.WriteLine("I2 method");
    }
    public void Print2()
    {
        Console.WriteLine("Interface - Print2 class");
    }
}

#endregion

#region Part 31 Explicit Interface

interface Interface1
{
    void InterfaceMethod();
}
interface Interface2
{
    void InterfaceMethod();
}

public class ClassFromInterfaces1 : Interface1, Interface2
{
    // Visual studio things that the methods of the both the interfaces are implemented
    public void InterfaceMethod()
    {
        Console.WriteLine("Interface1 Method");
    }
    }

public class ClassFromInterfaces2 : Interface1, Interface2
{
    
    void Interface1.InterfaceMethod()
    {
        Console.WriteLine("Interface1 Method");
    }

    void Interface2.InterfaceMethod()
    {
        Console.WriteLine("Interface2 Method");
    }

}

public class ClassFromInterfaces3 : Interface1, Interface2
{

    // Default method , which invokes the Interface1 method
    public void InterfaceMethod()
    {
        Console.WriteLine("Interface1 Method");
    }

    void Interface2.InterfaceMethod()
    {
        Console.WriteLine("Interface2 Method");
    }

}

#endregion


#region Part 32 Abstract class
public abstract class CustomerAbstract1
{
    public abstract void Print();
}
public class CustomerClassAbstract1 : CustomerAbstract1
{
    public override void Print()
    {
        Console.WriteLine("Print Method");
    }
}


public abstract class CustomerAbstract2
{
    public void Print()
    {
        Console.WriteLine("Method definition in abstract class");
    }
}
public class CustomerClassAbstract2 : CustomerAbstract2
{
    //public override void Print()
    //{
    //    Console.WriteLine("Print Method");
    //}
}
#endregion



#region Part 33 Difference between Interface and Abstract

public abstract class CustomerAbstract3
{
    // method can be implemented
    public void Print()
    {
        Console.WriteLine("Print in CustomerAbstract3");
    }
}

public interface ICustomer4
{
    // Method only declared
    void Print();
}

#endregion


#region Part 34 Problems of multiple class inheritance

class MutlipleInheritanceClassA
{
    public virtual void Print()
    {
        Console.WriteLine("A Implementation");
    }
}

class MutlipleInheritanceClassB
{
    public virtual void Print()
    {
        Console.WriteLine("B Implementation");
    }
}
class MutlipleInheritanceClassC : MutlipleInheritanceClassA
{
    public override void Print()
    {
        Console.WriteLine("C Implementation");
    }
}

//class MutlipleInheritanceClassD : MutlipleInheritanceClassB, MutlipleInheritanceClassC
//{
//    public override void Print()
//    {
//        Console.WriteLine("C Implementation");
//    }
//}

#endregion

#region Part 35 Problems of multiple class inheritance - using interfaces

interface InterfaceA
{
    void AMethod();
}
class MutlipleInheritanceInterfaceClassA : InterfaceA
{
    public void AMethod()
    {
        Console.WriteLine("A Implementation");
    }
}

interface InterfaceB
{
    void BMethod();
}
class MutlipleInheritanceInterfaceClassB : InterfaceB
{
    public void BMethod()
    {
        Console.WriteLine("B Implementation");
    }
}
class MutlipleInheritanceClassAB : InterfaceA, InterfaceB
{
    MutlipleInheritanceInterfaceClassA mutlipleInheritanceInterfaceClassA = new MutlipleInheritanceInterfaceClassA();
    MutlipleInheritanceInterfaceClassB mutlipleInheritanceInterfaceClassB = new MutlipleInheritanceInterfaceClassB();

    public void AMethod()
    {
        mutlipleInheritanceInterfaceClassA.AMethod();
    }
    public void BMethod()
    {
        mutlipleInheritanceInterfaceClassB.BMethod();
    }
}

//class MutlipleInheritanceClassD : MutlipleInheritanceClassB, MutlipleInheritanceClassC
//{
//    public override void Print()
//    {
//        Console.WriteLine("C Implementation");
//    }
//}

#endregion