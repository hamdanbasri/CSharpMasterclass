namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("i7", "BMW", true);

             //Console.WriteLine("Please enter the brand name:");

            // SETTING BRAND (REFER TO CAR.CS, THE LINE BELOW IS HOW WE ACCESS PROTECTED PROPERTIES SET.
            //audi.Brand = Console.ReadLine();

            // GETTING BRAND (REFER TO CAR.CS, THE LINE BELOW IS HOW WE ACCESS PROTECTED PROPERTIES GET.
            Console.WriteLine($"Brand is: {audi.Brand}");
            Console.WriteLine($"Brand is: {bmw.Brand}");

            Console.ReadKey();
        }
    }
}
