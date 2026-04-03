namespace DelegatesAndEvents
{

    // 1. Declaration
    public delegate void LogHandler(string message);
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"Console Log: {message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"File Log: {message}");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to console");

            logHandler = logger.LogToFile;
            logHandler("Log some stuff");

            // UNDERSTANDING GENERICS
            int[] intArray = { 1, 2, 3, 4, 5 };
            string[] stringArray = { "One", "Two", "Three", "Four", "Five" };

            PrintArray(intArray);
            PrintArray(stringArray);


            Console.ReadKey();
        }

        // UNDERSTANDING GENERICS
        public static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }

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
