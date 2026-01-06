public class PrintOutCarDetails
{
    public static void PrintOutDetails(Car[] cars)
    {
        for (int i = 0; i < cars.Length; ++i)
        {
            Console.WriteLine(cars[i].Make);
            Console.WriteLine(cars[i].Model);
            Console.WriteLine(cars[i].Colour);
            Console.WriteLine(cars[i].LicenceNumber);
            Console.WriteLine(cars[i].EngineCapacity);
        }
    }
}