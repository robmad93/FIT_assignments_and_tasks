// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Diagnostics.Metrics;

class Program
{
    public static void Main(string[] args)
    {
    // Run code below to create an array of 10 names and print them to the console.
    // string[] names = new string[10];
    // var namesList = new List<string> {"John", "Abe", "Martin", "Julian", "Martina", "Louise", "Alice", "Tom", "Anita", "Deirdre"};
    // for (int index = 0; index < names.Length; index++)
    //     {
    //         names[index] = namesList[index];
    //         Console.WriteLine(names[index]);
    //     }

    // Run code below to create an array of 10 test scores and print them to the console, each with a percentage symbol.
    // int[] testScores = new int[10];
    // var testScoreValues = new List<int> {55, 85, 90, 78, 47, 68, 80, 71, 56, 92};
    // for (int index = 0; index < testScores.Length; index++)
    //     {
    //         testScores[index] = testScoreValues[index];
    //         Console.WriteLine($"{testScores[index]}%");
    //     }
    
    // Run code below to create an array of 10 doubles to hold prices of items (in dollars) and print them to the console.
    // double[] itemPrices = new double[10];
    // var itemPriceValues = new List<double> {45.50D, 85.90D, 90.75D, 78.00D, 47.50D, 68.99D, 80.50D, 71.60D, 56.00D, 92.99D};
    // for (int index = 0; index < itemPrices.Length; index++)
    //     {
    //         itemPrices[index] = itemPriceValues[index];
    //         Console.WriteLine($"${itemPrices[index]}");
    //     }
    // Run code below to create predetermined array, then print each value using a for loop.
    // string[] schoolSubjects = {"English", "Maths", "Biology", "Chemistry", "Physics", "German", "French", "Art", "Technical graphics", "History", "Music"};
    // for (int i = 0; i < schoolSubjects.Length; i++)
    // {
    //     Console.WriteLine(schoolSubjects[i]);
    // }
    
    // Run code below to ask user to fill in names to an array of a set size.
    string[] namesArray = new string[5];
    int numberCounter = 0;
    Console.WriteLine("Please enter a name:");
    while (numberCounter < 5)
        {
            string entry = Console.ReadLine();
            namesArray[numberCounter] = entry;
            numberCounter++;
            if (numberCounter == 5)
            {
                continue;
            }
            else
            Console.WriteLine("Please enter another name:");
        }
    Thread.Sleep(1000);
    Console.WriteLine("Here are the names you entered:");
    for (int i = 0; i < namesArray.Length; i++)
        {
            Console.WriteLine(namesArray[i]);
        }
    }

}