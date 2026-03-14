Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

    if (firstNumber == 2 && secondNumber == 2)
    {
        Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is: " + (firstNumber + secondNumber) + "\n");
    }
    else
    {
        Console.WriteLine("Please enter a number");
    }



// CONVERSION HELPERS
string numberString = "123";
int numTest = 456;
int result = int.Parse(numberString);
//String formatting
Console.WriteLine("The number is {0} the bool is {1}", numberString, numTest);

string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine($"myBool is {myBool}");
Console.WriteLine("Testing \"special\" escape characters");


int month = 3;
string monthName;

switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2: 
        monthName = "February";
        break;
    case 3: 
        monthName = "March";
        break;
    default:
        monthName = "Unknown";
        break;
}

Console.WriteLine($"The month is {monthName}");
Console.ReadKey();
