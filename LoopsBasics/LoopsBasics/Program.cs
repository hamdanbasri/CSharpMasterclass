Console.WriteLine("Enter go or stay");

string userChoice = Console.ReadLine();

while(userChoice == "go")
{
    Console.WriteLine("Go for a mile");
    Console.WriteLine("Wanna keep going? Enter go.");
    userChoice = Console.ReadLine();
}
Console.WriteLine("Finally you are staying!");

Console.WriteLine("Guess the number between 1 - 100");

Random random = new Random();
int guessedNumber = 0;
int secretNumber = random.Next(1, 101);
int counter = 0;

Console.WriteLine($"Debug purpose: The secret number is: {secretNumber}");

while(guessedNumber != secretNumber)
{
    guessedNumber = int.Parse(Console.ReadLine());
    counter++;

    if(guessedNumber < secretNumber)
    {
        Console.WriteLine("Too low, try again");
    }
    else if(guessedNumber > secretNumber)
    {
        Console.WriteLine("Too high, try again");
    }
    else
    {
        Console.WriteLine($"You got it right, the number is: {secretNumber}, it took you {counter} tries.");
    }
}


Console.ReadKey();