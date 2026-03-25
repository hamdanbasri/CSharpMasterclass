using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListsApp
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Apple", Price =  1.99},
                new Product { Name = "Banana", Price =  0.70},
                new Product { Name = "Cherries", Price =  3.99}
            };

            products.Add(new Product { Name = "Berries", Price = 2.99 });

            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();

            Console.WriteLine("Products cheaper than $1");

            foreach (Product p in cheapProducts) { 
                Console.WriteLine($"Product name: {p.Name} Price: {p.Price}"); 
            }

            Console.WriteLine("\nAvailable Products: ");

            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} Price: {product.Price}");
            }

            int large = 20;
            //Declaring a list and initialize
            List<string> colors = new List<string>();
            List<int> numbers = new List<int> {10,5,15,3,9,25,18};
            numbers.Sort();

            Console.WriteLine("\n");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            bool hasLargeNumbers = numbers.Any(x => x > large);

            if(hasLargeNumbers)
            {
                Console.WriteLine("There are large numbers above " + large);
            }
            else
            {
                Console.WriteLine("No large numbers above " + large);
            }

                Console.WriteLine("\nList with higher number than 10");

            Predicate<int> isGreaterThanTen = x => x >= 10;

            //This will return a list of numbers that are 10 and higher
            List<int> highTen = numbers.FindAll(isGreaterThanTen);
            foreach (int number in highTen)
            {
                Console.WriteLine(number);
            }

            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Program myProgram = new Program();
            myProgram.PrintNumbers();

            Console.ReadKey();
        }

        public void PrintNumbers()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            string result = string.Join(" ", numbers);
            Console.Write(result);

        }

        public static bool IsGreaterThanTen(int x)
        {
            return x > 10;
        }
    }
}
