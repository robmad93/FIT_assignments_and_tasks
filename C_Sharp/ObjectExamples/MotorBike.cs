// How to create a constructor in C#.
public class MotorBike
{
    public string Make;
    public string Model;
    public string Colour;
    public string LicenceNumber;
    public double EngineCapacity;
    public MotorBike(string Make, string Model, string Colour, string LicenceNumber, double EngineCapacity)
    {
        this.Make = Make;
        this.Model = Model;
        this.Colour = Colour;
        this.LicenceNumber = LicenceNumber;
        this.EngineCapacity = EngineCapacity;
    }
    
}