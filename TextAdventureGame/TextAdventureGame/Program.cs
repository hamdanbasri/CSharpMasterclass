Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your character's name: ");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your character type (Warrior, Wizard, Archer)");
string characterType = Console.ReadLine();

Console.WriteLine($"You {playerName}, the {characterType} find yourself at the edge of the forest");
Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");

string choice1 = Console.ReadLine();
bool gameContinues = true;
int treasureCollected = 0;

if(choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely enter the forest");
}
else
{
    Console.WriteLine("You decide to camp out and wait for daylight");
}

while(gameContinues)
{
    Console.WriteLine("You came to a fork in the road. Go left or right?");
    string direction = Console.ReadLine();

    if(direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasure chest!");
        treasureCollected++;
        Console.WriteLine($"You have found a total of {treasureCollected} treasure.");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encounter a wild beast!");
        Console.WriteLine("Fight or flee? (fight/flee)");
        string fightChoice = Console.ReadLine();

        if(fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);

            if(luck > 5)
            {
                Console.WriteLine("You defeated the beast!");
                if(luck > 8)
                {
                    Console.WriteLine("The wild beast dropped a treasure.");
                    treasureCollected++;
                    Console.WriteLine($"You have found a total of {treasureCollected} treasure.");
                }
            }
            else
            {
                Console.WriteLine("The wild beast uses it's sharp tusk to impale you.");
                Console.WriteLine("You are bleeding out with no one to help.");
                Console.WriteLine("The wild beast has consumed you. Game Over!");
                gameContinues = false;
            }
        }
        else
        {
            Console.WriteLine("You decided to flee");
            Console.WriteLine("The townfolk is not happy with your actions");
            Console.WriteLine("You have been stripped of your title and banished from the village.");
            gameContinues = false;
        }
    }
}

    Console.ReadKey();
