Console.WriteLine("Enter the first number:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Choose an operation: +, -, *, /");
string operation = Console.ReadLine();

int calculation;
if (number2 != 0)
{
    if (operation == "+")
    {
        calculation = (number1 + number2);
        Console.WriteLine($"Result: {calculation}");
    }
    else if (operation == "-")
    {
        calculation = (number1 - number2);
        Console.WriteLine($"Result: {calculation}");
    }
    else if (operation == "*")
    {
        calculation = (number1 * number2);
        Console.WriteLine($"Result: {calculation}");
    }
    else if (operation == "/")
    {
        calculation = (number1 / number2);
        Console.WriteLine($"Result: {calculation}");
    }
    else
    {
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
    }
}
else
{
    Console.WriteLine("Error: Division by zero is not allowed.");
}

Console.ReadKey();