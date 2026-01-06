// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
    PrintHello();
    Console.WriteLine(TwoSum());
    Console.WriteLine(LongerStringOrBoth("Yeet", "Rizz"));
    CallHelloByTwoSum(2, 2);
    }
    public static void PrintHello()
    {
        Console.WriteLine("Hello");
    }
    public static int TwoSum(int num1 = 0, int num2 = 0)
    {
        int result = num1 + num2;
        return result;
    }
    public static string LongerStringOrBoth(string str1, string str2)
    {
        int length1 = str1.Length;
        int length2 = str2.Length;
        if (length1 > length2)
        {
            return str1;
        }
        else if (length1 < length2)
        {
            return str2;
        }
        else
            return str1 + str2;
        //Alternatively:
        /*
        if(a.Length == b.Length) return a+b;
        return a.Length > b.Length ? a : b;
        */
    }
    public static void CallHelloByTwoSum(int num1, int num2)
    {
        int number = TwoSum(num1, num2);
        for (int i = 0; i < number; i++)
        {
            PrintHello();
        }
    }
}