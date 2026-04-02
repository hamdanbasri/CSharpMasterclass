namespace EnumsApp
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
    enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dev };

    internal class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fri;
            Day su = Day.Sun;

            Day a = Day.Fri;

            Console.WriteLine(fr == a);
            Console.WriteLine((int)Months.Feb);

            Console.ReadKey();
        }
    }
}
