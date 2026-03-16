namespace CalculateAverageTemperature
{
    internal class Program
    {
        static int days = 5;
        static double[] temperature = new double[days];

        static void Main(string[] args)
        {
            PrintAverage(temperature);
        }

        public static void PrintAverage(double[] temperatures)
        {
            Console.WriteLine($"The average temperature is: {CalculateAverage(temperatures)}");
        }

        public static double CalculateAverage(double[] temperatures)
        {
            double tempAddedValue = 0;
            Random random = new Random();

            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = random.Next(-10, 40);
                tempAddedValue += temperatures[i];
            }

            return tempAddedValue / temperatures.Length;
        }
    }
}