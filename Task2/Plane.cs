namespace Task2;

public class Plane : Vehicle
{
    private uint FlightAltitude;

    public Plane(uint price, uint year, uint speed, uint altitude) : base(price, year, speed) 
    { FlightAltitude = altitude; }

    public override void TotalInfo()
    {
        base.TotalInfo();
        Console.WriteLine($" Flight altitude of PLANE is {FlightAltitude}");
        Console.WriteLine(" =============");
    }
}