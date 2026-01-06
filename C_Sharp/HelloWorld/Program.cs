// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

/* Console.WriteLine("Yeet");

int AnInteger = 1;
char ACharacter = 'c';
long ALong = 123456789;
short AShort = 1234;
decimal ADecimal = 4.4m;
double ADouble = 10.0101;
bool ABool = true;
float AFloat = 1.0f;
byte AByte = 7;
*/

/* Console.WriteLine("Enter two numbers: ");
int FirstNumber = Int32.Parse(Console.ReadLine());
int SecondNumber = Int32.Parse(Console.ReadLine());
Console.WriteLine($"The sum of your two numbers is {FirstNumber + SecondNumber}");
*/

/* string[] Food = { "Pizza", "Sushi", "Hamburger", "Tacos" };
string Total = "";
for (int i = 0; i < 4; i++)
{
    Total += Food[i] + " ";
}
Console.WriteLine($"What is your favourite dish? Here are some suggestions: {Total}");
string FavouriteDish = Console.ReadLine();
Console.WriteLine($"Your favourite dish is {FavouriteDish}");
*/

/*
Console.WriteLine("Let's create your character. What's your name?");
string Name = Console.ReadLine();
string[] Class = { "Wizard", "Warrior", "Barbarian", "Warlock", "Thief", "Assassin" };
string Total = "";
for (int i = 0; i < 6; i++)
{
    Total += Class[i] + " ";
}
Console.WriteLine($"Hi, {Name}. What class do you select? Options: {Total}");
string ClassOption = Console.ReadLine();
if (Class.Contains(ClassOption))
{
    Console.WriteLine($"You have selected {ClassOption}");
}
else
{
    Console.WriteLine("That is an invalid answer. Please try again.");
}
string[] Weapon = { "Club", "Sword", "Staff", "Dagger", "Axe", "Bow", "Spear" };
string Weapons = "";
for (int i = 0; i < 7; i++)
{
    Weapons += Weapon[i] + " ";
}
Console.WriteLine($"{Name} the {ClassOption}, please select your weapon. Options: {Weapons}");
string WeaponOption = Console.ReadLine();
if (Weapon.Contains(WeaponOption))
{
    Console.WriteLine($"You have selected {WeaponOption}");
}
else
{
    Console.WriteLine("That is an invalid answer. Please try again.");
}
*/

int x = 5; // Declares variable x, which is an integer value of 5
int y = 10; // Declares variable y, which is an integer value of 10
bool z = !true; // Declares variable z, which is the inverse of true i.e., false

Console.WriteLine(x < y); // Returns result of evaluating whether x is less than y. Outputs true.
Console.WriteLine(x > y); // Returns result of evaluating whether x is greater than y. Outputs false.
Console.WriteLine(x == y); // Returns result of evaluating whether x is equal to y. Outputs false.
Console.WriteLine(x != y); // Returns result of evaluating whether x is not equal to y. Outputs true.
Console.WriteLine(x <= y); // Returns result of evaluating whether x is less than or equal to y. Outputs true.
Console.WriteLine(x >= y); // Returns result of evaluating whether x is greater than or equal to y. Outputs false.
Console.WriteLine(z); // Returns z. Outputs false.

Console.WriteLine("Welcome, player! Please enter your name:");
string playerName = Console.ReadLine();
Console.WriteLine($"Hello, {playerName}! I will try to guess your age. Please enter your age here (don't worry, I won't look!):");
int playerAge = Int32.Parse(Console.ReadLine());
int[] arr = Enumerable.Range(1, 200).ToArray();
for (int i = 0; i < arr.Length; i +=1)
{
    if (i != playerAge)
    {
        Console.WriteLine($"It's {i}. Wait, no. That's not it.");
    }
    else
    {
        Console.WriteLine($"I know! It's {i}!");
        break;
    }
}