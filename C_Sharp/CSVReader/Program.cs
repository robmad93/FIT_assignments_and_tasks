class Program
{
    
    public static void Main(string[] args)
    {
        string[] linesFromFile = GetLinesFromFile("./resources/pokemon-info.csv");

        Pokemon[] pokemons = ConvertToPokeArray(linesFromFile);

        Random random = new Random();

        do
        {
            Pokemon randomPoke = pokemons[random.Next(pokemons.Length)];
            Console.WriteLine($"Number {randomPoke.PokedexNumber} is {randomPoke.Name}");
        
            Console.ReadLine();

        }while(true); // infinite loop, dont do this irl
    }

    public static Pokemon[] ConvertToPokeArray(string[] pokeInfo)
    {
        Pokemon[] pokes = new Pokemon[pokeInfo.Length - 1];

        for(int i = 1; i < pokeInfo.Length; ++i)
        {
            string[] pokeDetails = pokeInfo[i].Split(",");
            Pokemon newPoke = new Pokemon();
            newPoke.PokedexNumber = Int32.Parse(pokeDetails[0]);
            newPoke.Name = pokeDetails[1];
            newPoke.PrimaryType = pokeDetails[2];
            newPoke.SecondaryType = pokeDetails[3];
            newPoke.HP = Int32.Parse(pokeDetails[4]);
            newPoke.Attack = Int32.Parse(pokeDetails[5]);
            newPoke.Defense = Int32.Parse(pokeDetails[6]);
            newPoke.SpecAttack = Int32.Parse(pokeDetails[7]);
            newPoke.SpecDefense = Int32.Parse(pokeDetails[8]);
            newPoke.Speed = Int32.Parse(pokeDetails[9]);

            pokes[i - 1] = newPoke;
        }
        return pokes;
    }

    public static string[] GetLinesFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        return lines;
    }

    /*public static void Main(string[] args)
    {
        Console.Clear();
        string[] jokes = GetLinesFromFile(".\\resources\\jokes.txt");

        bool isRunning = true;
        do
        {
            Console.Clear();
            System.Console.WriteLine("Welcome to my hilarious joke app.");
            System.Console.WriteLine("1) Hear a funny joke");
            System.Console.WriteLine("2) Exit the program");

            int userInput = Int32.Parse(Console.ReadLine());

            if(1 == userInput)
            {
                Random random = new Random();
                int randomIndex = random.Next(jokes.Length);

                System.Console.WriteLine(jokes[randomIndex]);
            }else if(2 == userInput)
            {
                System.Console.WriteLine("Okay goodbye!");
                isRunning = false;
            }
            else
            {
                System.Console.WriteLine("Invalid input. Please try again");
            }
            System.Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }while(isRunning);
    }*/
}