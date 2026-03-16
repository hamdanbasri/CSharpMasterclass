namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = {"Sunny", "Rainy", "Cloud", "Snowy"};
            string[] weatherConditions = new string[days];

            Console.WriteLine(days);

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
                Console.WriteLine($"The weather is, {temperature[i]} degrees. Today is {weatherConditions[i]}");              
            }

            Console.WriteLine($"\nThe average temperature is: {CalculateAverageTemperature(temperature)}\n");
            Console.WriteLine($"The min temperature is: {temperature.Min()}");
            Console.WriteLine($"The max temperature is: {temperature.Max()}\n");
            Console.WriteLine($"Most common condition is: {MostCommonCondition(weatherConditions)}");
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if(conditions[j] == conditions[i])
                    { 
                        tempCount++; 
                    }

                    
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i]; 
                }
            }

            return mostCommon;
        }

        static double CalculateAverageTemperature(int[] temperature)
        {
            double tempAddedValue = 0;
            double tempAverage = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                tempAddedValue += temperature[i];
            }
            tempAverage = tempAddedValue / temperature.Length;
            return tempAverage;
        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach (int temp in temperature)
            {
                if(temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }
    }
}
