namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            //myDog.MakeSound();

            Cat myCat = new Cat();
            //myCat.MakeSound();

            Employee joe = new Employee("Joe", 36, "Sales Rep", 1234);
            joe.DisplayEmployeeInfo();

            Manager carl = new Manager("Carl", 40, "Manager", 5678, 20);
            //carl.DisplayManagerInfo();
            carl.BecomeOlder(5);
            carl.DisplayPersonInfo();

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        //Base class constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        /// <summary>Makes our object older.</summary>
        /// <param name="years">The parameters that indicates the amount of years the object should age.</param>
        /// <returns>Returns new age after aging.</returns>
        public int BecomeOlder(int years)
        {
            Age += years;
            return Age;
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }

        // Derived class constructor
        public Employee(string name, int age, string jobTitle, int employeeID) 
            : base(name, age) // Calling the base class constructor
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee constructor called");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo(); // Call method from base class
            Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize) 
            : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }
        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo(); // Call method from base class
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }

    // Base Class || Parent Class || Super Class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived Class || Child Class || Sub Class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Barking...");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meowing...");
        }
    }

    class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Going Nuts");
        }
    }
}
