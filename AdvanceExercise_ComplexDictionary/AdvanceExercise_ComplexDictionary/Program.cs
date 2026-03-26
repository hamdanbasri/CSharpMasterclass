namespace AdvanceExercise_ComplexDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> myDictionary = new Dictionary<string, List<int>>();

            myDictionary.Add("a", new List<int> { 1,2,3});

            if (myDictionary.ContainsKey("a"))
            {
                // 3. Loop through the integers inside that specific list
                foreach (int number in myDictionary["a"])
                {
                    // Write the number followed by a space on the same line
                    Console.Write(number + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
