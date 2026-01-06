// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Dynamic;

class Program
{
    public static void Main(string[] args)
    {
    string monsterName = SetMonsterName();
    string monsterType = RandomType();
    string enemyType = RandomType();
    double monsterStrength = DetermineStrengthMultiplier(monsterType, enemyType);
    double enemyStrength = DetermineStrengthMultiplier(monsterType, enemyType);
    int monsterHealth = SetHealthValue(); // Enter two numbers to change the range from which to randomly set health value instead of using default values.
    int enemyHealth = SetHealthValue();
    int monsterBaseAttack = SetBaseAttack(); // Enter two numbers to change the range from which to randomly set base attack value instead of using default values.
    int enemyBaseAttack = SetBaseAttack();
    BattleAnnouncement();
    IntroduceYourMonster(monsterName, monsterType, monsterHealth, monsterBaseAttack);
    IntroduceEnemy(enemyType, enemyHealth, enemyBaseAttack);
    Battle(monsterName, monsterType, monsterHealth, monsterBaseAttack, monsterStrength, enemyType, enemyHealth, enemyBaseAttack, enemyStrength);
    }
    public static string RandomType()
    {
        Random randomGenerator = new Random();
        var types = new List<string>{"fire", "water", "grass", "ice", "electricity", "rock", "ground", "fighting", "psychic", "ghost"};
        int index = randomGenerator.Next(types.Count);
        var type = types[index];
        return type;
        // Console.Write(type); // Test to see what type is randomly generated.
    }

    public static string SetMonsterName()
    {
        Console.WriteLine("Please enter your monster's name:");
        string monsterName = Console.ReadLine();
        return monsterName;
    }
    public static double DetermineStrengthMultiplier(string monsterType, string enemyType)
    {
        if (monsterType == "fire" & enemyType == "grass" | monsterType == "fire" & enemyType == "ice"| 
        monsterType == "water" & enemyType == "fire" | monsterType == "water" & monsterType == "rock"
        | monsterType == "water" & enemyType == "ground" | monsterType == "grass" & monsterType == "water"
        | monsterType == "grass" & enemyType == "ground") // IMPORTANT: Fill in the other values later.
        {
            double strengthMultiplier = 2.0;
            return strengthMultiplier;
        }
        else if (monsterType == "fire" & enemyType == "rock") // IMPORTANT: Fill in the other values later.
        {
            double strengthMultiplier = 0.5;
            return strengthMultiplier;
        }
        else
        {
            double strengthMultiplier = 1.0;
            return strengthMultiplier;
        }
    }
    public static int SetHealthValue(int minRange = 500, int maxRange = 1000)
    {
        Random randomGenerator = new Random();
        int healthValue = randomGenerator.Next(minRange, maxRange);
        return healthValue;
    }
    public static int SetBaseAttack(int minRange = 10, int maxRange = 50)
    {
        Random randomGenerator = new Random();
        int baseAttack = randomGenerator.Next(minRange, maxRange);
        return baseAttack;
    }
    public static void BattleAnnouncement()
    {
        Console.WriteLine("Let's battle!");
        Thread.Sleep(500);
    }
    public static void IntroduceYourMonster(string name, string type, int health, int attack)
    {

        Console.WriteLine($"Your monster, affectionately named {name}, is a {type} type monster. {name} has {health} health points and a base attack of {attack}.");
        Thread.Sleep(500);
        Console.WriteLine($"{name} is primed and ready for battle!");
    }
    public static void IntroduceEnemy(string type, int health, int attack)
    {
        Console.WriteLine($"Your opponent is a {type} type enemy. It has {health} health points and a base attack of {attack}");
        Thread.Sleep(500);
        Console.WriteLine("Prepare to fight!");
    }
    public static string Battle(string monsterName, string monsterType, int monsterHealth, int monsterBaseAttack, double monsterStrength, 
    string enemyType, int enemyHealth, int enemyBaseAttack, double enemyStrength)
    {
        double monsterDamageOutput = monsterBaseAttack * monsterStrength;
        double enemyDamageOutput = enemyBaseAttack * enemyStrength;
        while (monsterHealth >= 0)
        {
            
        }
    }
}   