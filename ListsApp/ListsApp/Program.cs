using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring a list and initialize
            List<string> colors = new List<string>();
            List<int> numbers = new List<int> {10,5,15,3,9,25,18};
            numbers.Sort();

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nList with higher number than 10");

            //This will return a list of numbers that are 10 and higher
            List<int> highEqualTen = numbers.FindAll(x => x >= 10);
            foreach (int number in highEqualTen)
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
    }
}
