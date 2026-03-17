namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car audi = new Car("A3", "Audi", false);
            //Car bmw = new Car("i7", "BMW", true);

            //Console.WriteLine("Please enter the brand name:");

            // SETTING BRAND (REFER TO CAR.CS, THE LINE BELOW IS HOW WE ACCESS PROTECTED PROPERTIES SET.
            //audi.Brand = Console.ReadLine();

            // GETTING BRAND (REFER TO CAR.CS, THE LINE BELOW IS HOW WE ACCESS PROTECTED PROPERTIES GET.
            //Console.WriteLine($"Brand is: {audi.Brand}");
            //Console.WriteLine($"Brand is: {bmw.Brand}");

            //Customer earl = new Customer("Earl");
            //Customer frank = new Customer("Frank", "Main Street 1", "0123456789");

            //Console.WriteLine($"The customers name is: {earl.Name}");

            // Default Customer with no Arguments given
            //Customer defaultCustomer = new Customer();
            //Console.WriteLine($"\nDetails about customer: {defaultCustomer.Name}");

            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();

            Car myBmw = new Car("i7", "BMW", true);
            myBmw.Drive();

            Customer myCustomer = new Customer();
            myCustomer.SetDetails("Abu", "7891 Street", "0987654321");
            Console.WriteLine($"My customer is: {myCustomer.Name} and he livies in {myCustomer.Address}");
            myCustomer.GetDetails();

            Console.WriteLine(AddNum(25, 15));
            // THIS IS CALLED NAMED PARAMETERS
            Console.WriteLine(AddNum(firsNum: 25, secondNum: 15));
            Console.WriteLine(AddNum(firsNum: 25, 25));
            Console.WriteLine(AddNum(25, secondNum: 15));

            Rectangle r1 = new Rectangle();
            r1.Width = 10;
            r1.Height = 10;
            Console.WriteLine($"Area of rectangle {r1.Area}");
            DoubleValue(10);

            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3", "Audi", false);

            Console.WriteLine($"The total number of cars is: {Car.numberOfCars}");

            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");

            customer1.GetDetails(); 
            customer2.GetDetails();

            Console.ReadKey();


        }

        static int AddNum(int firsNum, int secondNum) => firsNum + secondNum;

        public static int DoubleValue(int number)
        {
            number = number * 2;
            Console.WriteLine(number);
            return number;
        }
    }
}
