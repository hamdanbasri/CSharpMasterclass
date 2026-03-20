using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring a list and initialize
            List<string> colors = new List<string>();

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
