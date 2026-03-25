namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null;
            int myAge = 34;

            if(age.HasValue)
            {
                Console.WriteLine($"Age is {age.Value}");
                int sum = age.Value + myAge;
            }
            else
            {
                Console.WriteLine("Age is not specified");
            }

                Console.ReadKey();
        }
    }
}
