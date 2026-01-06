using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        string[] jokes = GetLinesFromFile(".\\resources\\jokes.txt"); // Use double backslashes since single backlashes are escape characters.
        string[] compliments = GetLinesFromFile(".\\resources\\compliments.txt");
        string[] randomFacts = GetLinesFromFile(".\\resources\\random_facts.txt");

        // for (int i = 0; i < jokes.Length; ++i) // Reads out all jokes.
        // {
        //     Console.WriteLine(jokes[i]);
        // }
    
    /*
    Making an app that lets a user choose between a joke, a compliment, or a random fact.
    */

    bool isRunning = true;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to Rob's amusement app!");
            Console.WriteLine("To hear a joke, press 1");
            Console.WriteLine("To hear a compliment, press 2");
            Console.WriteLine("To hear a random fact, press 3");
            Console.WriteLine("To exit the program, press 4");
            
            int userInput = Int32.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Random random = new Random();
                int randomIndex = random.Next(jokes.Length);

                Console.WriteLine(jokes[randomIndex]);
            }
            else if (userInput == 2)
            {
                Random random = new Random();
                int randomIndex = random.Next(compliments.Length);

                Console.WriteLine(compliments[randomIndex]);
                
            } else if (userInput == 3)
            {
                Console.WriteLine("Did you know that...");
                Thread.Sleep(500);
                Random random = new Random();
                int randomIndex = random.Next(randomFacts.Length);

                Console.WriteLine(randomFacts[randomIndex]);
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Goodbye");
                Thread.Sleep(3000);
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again");
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        } while (isRunning == true);
    }
    public static string[] GetLinesFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        return lines;
    }
}