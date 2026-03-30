using System.Diagnostics;

namespace TryCatchException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Debug.Write("Main method is running");

            try
            {
                Console.WriteLine("Please enter a number:");
                int num1 = int.Parse(Console.ReadLine());
                //int num1 = 0;
                int num2 = 2;
                result = num2 / num1;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Dont divide by zero {ex.Message}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Please enter a number not a letter: {ex.Message}");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Number Too High");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Debug.WriteLine(ex.ToString());
            }finally
            {
                Console.WriteLine("This always executes");
            }

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Enter Your Age: ");
            GetUserAge(Console.ReadLine());

            Console.ReadKey();
        }

        static int GetUserAge(string input)
        {
            int age;
            if(!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");
            }
            if(age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120");
            }
            return age;
        }
    }
}
