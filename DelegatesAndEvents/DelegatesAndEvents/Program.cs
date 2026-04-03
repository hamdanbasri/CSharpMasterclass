namespace DelegatesAndEvents
{
    public delegate int Comparison<T> (T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public String Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++) 
            {
                for(int j  = i+1; j < people.Length; j++)
                {
                    if(comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Dennis", Age = 26 },
                new Person { Name = "Charlie", Age = 35 }
            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);

            Console.WriteLine("Comparing People By Age:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age} ");
            }

            sorter.Sort(people, CompareByName);

            Console.WriteLine("\nComparing People By Name:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age} ");
            }

            Console.ReadKey();
        }

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    //// 1. Declaration
    //public delegate void LogHandler(string message);
    //public class Logger
    //{
    //    public void LogToConsole(string message)
    //    {
    //        Console.WriteLine($"Console Log: {message}");
    //    }

    //    public void LogToFile(string message)
    //    {
    //        Console.WriteLine($"File Log: {message}");
    //    }
    //}

    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Logger logger = new Logger();
    //        LogHandler logHandler = logger.LogToConsole;
    //        logHandler("Logging to console");

    //        logHandler = logger.LogToFile;
    //        logHandler("Log some stuff");

    //        // UNDERSTANDING GENERICS
    //        int[] intArray = { 1, 2, 3, 4, 5 };
    //        string[] stringArray = { "One", "Two", "Three", "Four", "Five" };

    //        PrintArray(intArray);
    //        PrintArray(stringArray);


    //        Console.ReadKey();
    //    }

    //    // UNDERSTANDING GENERICS
    //    public static void PrintArray(int[] array)
    //    {
    //        foreach (int item in array)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    public static void PrintStringArray(string[] array)
    //    {
    //        foreach (string item in array)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    public static void PrintArray<T>(T[] array)
    //    {
    //        foreach (T item in array)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //internal class Program
    //{
        //// 1. Declaration
        //public delegate void Notify(string message);
        //public delegate void LogHandler(string message);

        //static void Main(string[] args)
        //{
        //    // 2. Instantiation
        //    Notify notifyDelegate = ShowMessage;

        //    // 3. Invocation
        //    notifyDelegate("Hello, Delegates!");


        //    Console.ReadKey();
        //}

        //static void ShowMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}
    //}
}
