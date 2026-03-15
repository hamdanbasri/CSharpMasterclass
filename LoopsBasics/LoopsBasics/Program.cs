Console.WriteLine("Enter go or stay");

string userChoice = Console.ReadLine();

while(userChoice == "go")
{
    Console.WriteLine("Go for a mile");
    Console.WriteLine("Wanna keep going? Enter go.");
    userChoice = Console.ReadLine();
}
Console.WriteLine("Finally you are staying!");

Console.ReadKey();