using System.Numerics;

class Program //Class name is always the same as file name and is in Pascal case.
{
    public static void Main(string[] args) // Main method tells program where to start. Only one main method can be defined. Always right your code within the main method.
    {
        // Console.WriteLine("Hello!");
        // IfExample();
        // ForExample();
        // NumberGuessingGame();
        GenAlphaTriggerWarning();
    }

    // public static void IfExample()
    // {
    //     // This is my code for practicing an if...
    //     Console.WriteLine("This is how if's work...");
    //     /*  bool isSunny = true;
    //     if (isSunny)
    //     {
    //         Console.WriteLine("It is sunny! Let's go outside!");
    //     }
    //     isSunny = false;
    //     if (!isSunny)
    //     {
    //         Console.WriteLine("Wait, now it is no longer sunny. Let's chill indoors.");
    //     } */
    //     Console.WriteLine("Please enter your grade. Options: A, B, C");
    //     /* char userScore = Console.ReadKey().KeyChar; // Alternative method. */
    //     // string userScore = Console.ReadLine();
    //     /* char grade = char.Parse(Console.ReadLine());
    //     char grade2 = Char.ToUpper(grade);
    //     if (grade2 == 'A')
    //     {
    //         Console.WriteLine("\nYour score is between 85-100%");
    //     }
    //     else if (grade2 == 'B')
    //     {
    //         Console.WriteLine("\nYour score is between 75-85%");
    //     }
    //     else if (grade2 == 'C')
    //     {
    //         Console.WriteLine("\nYour score is between 65-75%");
    //     }
    //     else
    //     {
    //         Console.WriteLine("\nInput invalid. Please refresh the program and try again.");
    //     }
    // } */
    public static void ForExample()
    {
        // This is my code for practicing for loops...
        Console.WriteLine("This is how for loops work...");
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("It needs to be a positive integer above 0. Please restart the program.");
            Environment.Exit(0); // Will exit the program. Remember: Cannot use 'break' in an 'if' statement.
        }
        else
        {
        string numberstring = number.ToString();
        Console.WriteLine($"Ah, {name}! I like it so much, I will repeat it {numberstring} times!");
        Thread.Sleep(3 * 1000);
        for (int i = 1; i <= number; i++) // Change the condition to whatever number of times you want the name repeated.
        {
            Console.WriteLine(i + ". " + name);
        }
    }
    }
    public static void NumberGuessingGame()
    {
        int numberOfLives = 5;
        // random number generator
        Random randomGenerator = new Random();
        int numberToGuess = randomGenerator.Next(1, 11); // Generate number between 1 and 10.
        string numberToGuessString = numberToGuess.ToString();
        // Console.WriteLine(numberToGuess); // Uncomment this line to view the target number.
        Console.WriteLine("Enter your guess:");
        int userGuess = Int32.Parse(Console.ReadLine());
        for (; numberOfLives > 0; --numberOfLives)
        {
        if (userGuess < numberToGuess)
        {
            if (numberOfLives == 1)
            {
                Console.WriteLine($"You are out of lives! The answer was {numberToGuessString}");
                break;
            }
            else
            {
                Console.WriteLine("Your number is too low. Try again.");
            }
        }
        else if (userGuess > numberToGuess)
        {
            if (numberOfLives == 1)
            {
                Console.WriteLine($"You are out of lives! The answer was {numberToGuessString}");
                break;
            }
            else
            {
                Console.WriteLine("Your number is too high. Try again");
            }
        }
        else if (userGuess == numberToGuess)
        {
            string livesRemaining = numberOfLives.ToString();
            Console.WriteLine($"You got it! Number of lives remaining: {livesRemaining}");
            break;
        }
        }
    }
    public static void GenAlphaTriggerWarning()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Rizz");
            for (int j = 3; j > 0; j--)
            {
                Console.WriteLine("Edge");
            }
            Console.WriteLine("Skibidi");
        }
    }
    
}
