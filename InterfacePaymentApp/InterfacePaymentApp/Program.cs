namespace InterfacePaymentApp
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of the amount: {amount}");
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of the amount: {amount}");
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount) 
        { 
            _processor.ProcessPayment(amount);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger 
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\Projects\CSharpMasterclass\InterfacePaymentApp\InterfacePaymentApp\bin\Debug\net8.0\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, message);
        }
    }

    public class DatabaseLogger : ILogger 
    {
        public void Log(string message) 
        {
            Console.WriteLine($"Logging to database: {message}");
        }
    }

    public class Application
    {
        public readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work Started\n");
            // DO ALL THE WORK
            _logger.Log("Work Completed");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            //IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            //PaymentService paymentService = new PaymentService(creditCardProcessor);
            //paymentService.ProcessOrderPayment(100.0m);

            //IPaymentProcessor payPalProcessor = new PayPalProcessor();
            //paymentService = new PaymentService(payPalProcessor);
            //paymentService.ProcessOrderPayment(200.0m);

            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger dbLogger = new DatabaseLogger();
            app = new Application(dbLogger);
            app.DoWork();
            
            Console.ReadKey();
        }
    }
}
