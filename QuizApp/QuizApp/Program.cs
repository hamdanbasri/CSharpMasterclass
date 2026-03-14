// See https://aka.ms/new-console-template for more information
string question1 = "What is the capital of Malaysia?";
string answer1 = "Kuala Lumpur";

string question2 = "What is 2 + 2?";
int answer2 = 4;

string question3 = "What do you get when you mix yellow and blue?";
string answer3 = "Green";

int score = 0;

Random random = new Random();
int randomNumber = random.Next(0, 10);

Console.WriteLine($"The random number is: {randomNumber}");
Console.WriteLine("Guess a number: ");
string inputString = Console.ReadLine();
int num1 = 0;

bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    if (num1 == randomNumber)
    {
        Console.WriteLine("You got it!");
    }
}

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();

if(userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine($"Wrong the correct answer is: {answer1}");
}

    Console.WriteLine(question2);
int userAnswer2 = int.Parse(Console.ReadLine());
//int.TryParse(Console.ReadLine(), out score);

if (userAnswer2 == answer2)
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine($"Wrong the correct answer is: {answer2}");
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();

if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine($"Wrong the correct answer is: {answer3}");
}

Console.WriteLine($"Your score is: {score}");
Console.ReadKey();