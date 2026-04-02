namespace DependecyInjectionApp_MultiInheritance
{
    public interface IPrintable
    {
        public void Print();
    }

    public interface IScannable
    {
        public void Scan();
    }

    public class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void Print() 
        {
            Console.WriteLine("Printing Document");
        }
        public void Scan() 
        {
            Console.WriteLine("Scanning document");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiFunctionPrinter printer = new MultiFunctionPrinter();
            printer.Print();
            printer.Scan();

            Console.ReadKey();
        }
    }
}
