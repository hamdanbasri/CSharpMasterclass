namespace DateTimeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1992, 7, 10);
            Console.WriteLine($"My birthday is {dateTime}");

            //Write today on screen
            Console.WriteLine(DateTime.Today);
            //Write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"Tomorrow will be: {tomorrow}");
            Console.WriteLine($"Today is {DateTime.Today.DayOfWeek}");
            Console.WriteLine(GetFirstDayOfYear(1999));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine($"Days in Feb 2000 {days}");
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine($"Days in Feb 2001 {days}");

            DateTime now = DateTime.Now;
            Console.WriteLine($"It is {now.Hour} o'clock and {now.Minute} minutes and {now.Second} seconds.");

            Console.WriteLine($"Write a date in this format yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"Days passsed since {daysPassed.Days}");
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

                Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
