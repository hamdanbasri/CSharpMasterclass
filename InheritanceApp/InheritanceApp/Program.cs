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

    // Base Class || Parent Class || Super Class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating..");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
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
