namespace Constructor_Inheritance_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee("John Doe", 123);
            john.DisplayEmployeeInfo();

            Console.ReadKey();
        }
    }

    public class Person
    {
        // TODO: Declare a constructor that takes a name and prints a message
        public string Name { get; private set; }

        //Base class constructor
        public Person(string name)
        {
            Name = name;
            Console.WriteLine($"Person constructor: {Name}");
        }
    }

    public class Employee : Person
    {
        // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
        public new string Name { get; private set; }
        public int EmployeeID { get; private set; }

        // Derived class constructor
        public Employee(string name, int employeeID)
            : base(name) // Calling the base class constructor
        {
            Name = name;
            EmployeeID = employeeID;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee constructor: {Name}, ID: {EmployeeID}");
        }
    }
}
