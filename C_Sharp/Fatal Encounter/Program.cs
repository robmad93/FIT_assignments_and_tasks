using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
    string[] linesFromFile = GetLinesFromFile("./resources/Warrior_roster.csv");
    Warrior[] warriors = ConvertToWarriorArray(linesFromFile);

    bool playAgain = true;

    while (playAgain)
    {
    Console.Clear();
    string teamNameOne = StartGame();
    Warrior[] teamOne = RandomTeamGenerator(warriors, teamNameOne);
    Console.WriteLine("");
    Warrior[] teamTwo = RandomTeamGenerator(warriors, "the enemy team");    

    Console.WriteLine(@"  _______ _    _ ______   ____       _______ _______ _      ______   ____  ______ _____ _____ _   _  _____ 
 |__   __| |  | |  ____| |  _ \   /\|__   __|__   __| |    |  ____| |  _ \|  ____/ ____|_   _| \ | |/ ____|
    | |  | |__| | |__    | |_) | /  \  | |     | |  | |    | |__    | |_) | |__ | |  __  | | |  \| | (___  
    | |  |  __  |  __|   |  _ < / /\ \ | |     | |  | |    |  __|   |  _ <|  __|| | |_ | | | | . ` |\___ \ 
    | |  | |  | | |____  | |_) / ____ \| |     | |  | |____| |____  | |_) | |___| |__| |_| |_| |\  |____) |
    |_|  |_|  |_|______| |____/_/    \_\_|     |_|  |______|______| |____/|______\_____|_____|_| \_|_____/ 
                                                                                                           
                                                                                                           ");
    int indexOne = 0;
    int indexTwo = 0;

    Warrior currentOne = teamOne[indexOne];
    Warrior currentTwo = teamTwo[indexTwo];

    Console.WriteLine($"{currentOne.Name} from {teamNameOne} faces {currentTwo.Name} from team two!");

        while (indexOne < teamOne.Length && indexTwo < teamTwo.Length)
        {
            // Fight until one faints
            while (currentOne.Health > 0 && currentTwo.Health > 0)
            {
                InitiateAttack(new Warrior[] { currentOne, currentTwo });
            }

            // Determine who fainted
            if (currentOne.Health <= 0)
            {
                Console.WriteLine($"\n{currentTwo.Name} wins this duel!");

                indexOne++; // next fighter from team one
                if (indexOne >= teamOne.Length) 
                break;

                currentOne = teamOne[indexOne];
                Console.WriteLine($"\n{currentOne.Name} enters the battlefield!");
            }
            else
            {
                Console.WriteLine($"\n{currentOne.Name} wins this duel!");

                indexTwo++; // next fighter from team two
                if (indexTwo >= teamTwo.Length) 
                break;

                currentTwo = teamTwo[indexTwo];
                Console.WriteLine($"\n{currentTwo.Name} enters the battlefield!");
            }
        }
        Console.WriteLine(@"                       ___   _              __     ___         __  __                     
                      / _ \ /_\    /\/\    /__\   /___\/\   /\/__\/__\                    
 _____ _____ _____   / /_\///_\\  /    \  /_\    //  //\ \ / /_\ / \//  _____ _____ _____ 
|_____|_____|_____| / /_\\/  _  \/ /\/\ \//__   / \_//  \ V //__/ _  \ |_____|_____|_____|
                    \____/\_/ \_/\/    \/\__/   \___/    \_/\__/\/ \_/                    
                                                                                          ");

        if (indexOne >= teamOne.Length && indexTwo >= teamTwo.Length)
        {
            Console.WriteLine("Both teams have fallen... it is a draw!");
        }
        else if (indexOne >= teamOne.Length)
        {
            Console.WriteLine("The enemy team is victorious!");
        }
        else
        {
            Console.WriteLine($"{teamNameOne} is victorious!");
        }
        Console.WriteLine("\nWould you like to play again? (y/n)");
        string response = Console.ReadLine().Trim().ToLower();

        if (response != "y" && response != "yes")
        {
            playAgain = false;
            Console.WriteLine("Thanks for playing!");
        }
    }
    }
    public static void InitiateAttack(Warrior[] fighters)
    {
        int attacker = new Random().Next(2); // 0 or 1
        if(attacker == 0)
        {
            SimulateAttack(fighters[0], fighters[1]);
        }
        else
        {
            SimulateAttack(fighters[1], fighters[0]);
        }
    }
    public static void SimulateAttack(Warrior attacker, Warrior defender)
    {
        defender.TakeAttack(attacker);
    } 

    public static string StartGame()
    {
    Console.WriteLine("Welcome to FATAL ENCOUNTER!");
    Console.WriteLine("Please enter either 1 (Start game) or 2 (Quit game)");
    int userInput = Int32.Parse(Console.ReadLine());
    while (userInput != 1 && userInput != 2)
        {
        Console.WriteLine("Invalid input. Please enter either 1 (Start game) or 2 (Quit game)");
        userInput = Int32.Parse(Console.ReadLine());
        }
    if (userInput == 1)
        {
            Console.WriteLine("Please enter a name for your team of brave warriors:");
            string teamName = Console.ReadLine();
            return teamName;
        }
    else
        {
            Console.WriteLine("Thanks for playing. Until next time, warrior.");
            Environment.Exit(0);
            return "";
        }
    }
    public static Warrior[] ConvertToWarriorArray(string[] warriorInfo)
    {
        Warrior[] warriors = new Warrior[warriorInfo.Length - 1];

        for (int i = 1; i < warriorInfo.Length; ++i)
        {
            string[] warriorDetails = warriorInfo[i].Split(",");
            Warrior newWarrior = new Warrior();
            newWarrior.Name = warriorDetails[0];
            newWarrior.Type = warriorDetails[1];
            newWarrior.InitWeakness();
            newWarrior.Attack = Int32.Parse(warriorDetails[2]);
            newWarrior.Health = Int32.Parse(warriorDetails[3]);
            newWarrior.Defense = Int32.Parse(warriorDetails[4]);
            newWarrior.Speed = Int32.Parse(warriorDetails[5]);

            warriors[i - 1] = newWarrior;
        }
        return warriors;    
        
    }
    public static string[] GetLinesFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        return lines;
    }
    public static Warrior[] RandomTeamGenerator(Warrior[] warriors, string teamName)
    {
        Warrior[] teamArray = new Warrior[5];
        Random random = new Random();

        for (int i = 0; i < teamArray.Length; ++i)
        {
            Warrior randomWarrior = warriors[random.Next(warriors.Length)];
            teamArray[i] = randomWarrior;

            Console.WriteLine($"Added {randomWarrior.Name} the {randomWarrior.Type} to {teamName}!");
        }
        return teamArray;
    }
}
// Get the user to select either to start a game or quit the program

// Get the user to input a team name
// Get the user to choose either select their team members themselves or have them randomly generated
// If randomly generated
// 	Get random warriors from CSV file
// Else if selecting members themselves
// 	Prompt user to select warrior type
// 	Provide a list of characters of that warrior type
// 	Get user to select the character and add to the team array object
// 	(Give user option to rename character to their liking)
// 	Repeat until all 5 members have been selected
// Get computer to generate a random team of 5 characters
// Get console to output introduction to battle messages
// Get console to introduce first two fighters
// Get the two fighters to fight
// While the two fighters are still alive
// 	The console outputs updates on fighter statistics
// The victor is retained, and fights the next opponent
// Reset victor HP
// While the two fighters are still alive
// 	The console outputs updates on fighter statistics
// Once only one team remains
// 	Console outputs closing messages
// 	Console outputs victorious team
// 	Console outputs most prolific fighter 
// 	Console outputs number of team victories and whether the team is on a streak of victories
