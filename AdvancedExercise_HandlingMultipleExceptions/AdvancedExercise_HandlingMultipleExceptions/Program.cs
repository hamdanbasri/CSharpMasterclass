using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace AdvancedExercise_HandlingMultipleExceptions
{
    //Create a simple C# program that demonstrates handling multiple types of exceptions. The program should:
    //Declare a method HandleMultipleExceptions which:
    //Takes a string and an int as parameters, in that order.
    //Contains a local int[] variable with predefined elements, for example, int[] numbers = { 1, 2, 3 };.
    //Contains a try block where you:
    //Attempt to parse an integer from the string parameter that could throw a FormatException.
    //Access an element in the array by the integer parameter as an index that could throw an IndexOutOfRangeException.
    //Catch and handle both FormatException and IndexOutOfRangeException.
    //Print specific messages for each exception type.
    //Alert!
    //The result of execution should be:
    //If a FormatException occurs: "Invalid format."
    //If an IndexOutOfRangeException occurs: "Index out of range."
    //If no exception occurs: the accessed array element.
    //Example output for no exception: "2"
    //Example output for FormatException: "Invalid format."
    //Example output for IndexOutOfRangeException: "Index out of range."
    internal class Program
    {
        static void Main(string[] args)
        {
            Debug.Write("Main method is running");
            HandleMultipleExceptions("bla", 5);
            Console.ReadKey();
        }

        public static void HandleMultipleExceptions(string myString, int myInt)
        {
            int[] numbers = { 1, 2, 3 };

            try
            {
                int parsedValue = int.Parse(myString);
                Console.WriteLine($"{numbers[myInt]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range."+ ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}
