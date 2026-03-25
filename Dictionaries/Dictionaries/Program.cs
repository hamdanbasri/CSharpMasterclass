namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key value pair
            // Declaring and initializing a dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            // Adding Items to a Dictionary
            employees.Add(101, "John Doe");
            employees.Add(102, "Paul Smith");

            // Access Items in a Dictionary
            string name = employees[101];
            Console.WriteLine(name);

            // Update Value in Dictionary
            employees[102] = "Jane Smith";


            employees.Remove(102);
            Console.ReadKey();
        }
    }
}
