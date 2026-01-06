// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!"); 
class Program
{
    public static void Main(string[] args)
    {
        Car myCar1 = new Car(); // Create car object and fill in details.
        myCar1.Make = "Toyota";
        myCar1.Model = "Corolla Luna Sport";
        myCar1.Colour = "Red";
        myCar1.LicenceNumber = "222-CE-202";
        myCar1.EngineCapacity = 1.8;

        // Car[] myCarCollection = new Car[3]; // Create an array of three Car objects.
        // myCarCollection[0] = myCar1; // Add myCar1 object to myCarCollection array at index 0.
        // for (int i = 1; i < myCarCollection.Length; i++)
        // {
        //     myCarCollection[i] = AskUser(); // Get user to add details of cars and add these car objects to the array.
        // }

        // PrintOutCarDetails.PrintOutDetails(myCarCollection);
        MotorBike[] myMotorbikeCollection = new MotorBike[3]; // Create MotorBike array with capacity for three MotorBike objects.
        MotorBike myBike = new MotorBike("Honda", "CBR500R", "Red", "231-CE-314", 471); // Create myBike MotorBike object, using class constructor.
        Console.WriteLine(myBike.Make);
        Console.WriteLine(myBike.Model);
        Console.WriteLine(myBike.Colour);
        Console.WriteLine(myBike.LicenceNumber);
        Console.WriteLine(myBike.EngineCapacity);
        myMotorbikeCollection[0] = myBike;
        for (int i = 1; i < myMotorbikeCollection.Length; i++)
        {
            myMotorbikeCollection[i] = AskUserForMotorBike(); // Get user to add details of motorbikes and add these motorbike objects to the array.
        }
        Console.WriteLine(myMotorbikeCollection[1].Make);
        Console.WriteLine(myMotorbikeCollection[1].Model);
        Console.WriteLine(myMotorbikeCollection[1].Colour);
        Console.WriteLine(myMotorbikeCollection[1].LicenceNumber);
        Console.WriteLine(myMotorbikeCollection[1].EngineCapacity);
        
    }
    public static Car AskUserForCar()
    {
        Car car = new Car();
        Console.WriteLine("Please enter your make:");
        car.Make = Console.ReadLine();
        Console.WriteLine("Please enter your model:");
        car.Model = Console.ReadLine();
        Console.WriteLine("Please enter your colour:");
        car.Colour = Console.ReadLine();
        Console.WriteLine("Please enter your license number:");
        car.LicenceNumber = Console.ReadLine();
        Console.WriteLine("Please enter your engine capacity:");
        car.EngineCapacity = Convert.ToDouble(Console.ReadLine());
        return car;
    }
    public static MotorBike AskUserForMotorBike()
    {
        Console.WriteLine("Please enter your make:");
        string Make = Console.ReadLine();
        Console.WriteLine("Please enter your model:");
        string Model = Console.ReadLine();
        Console.WriteLine("Please enter your colour:");
        string Colour = Console.ReadLine();
        Console.WriteLine("Please enter your licence number:");
        string LicenceNumber = Console.ReadLine();
        Console.WriteLine("Please enter your engine capacity:");
        double EngineCapacity = Convert.ToDouble(Console.ReadLine());
        MotorBike motorbike = new MotorBike(Make, Model, Colour, LicenceNumber, EngineCapacity);
        return motorbike;
    }
}