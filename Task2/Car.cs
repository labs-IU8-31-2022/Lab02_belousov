namespace Task2;

public class Car : Vehicle
{
    private string Brand;
    public Car(uint price, uint year, uint speed, string brand) : base(price, year, speed) { Brand = brand; }
    public override void TotalInfo()
    {
        base.TotalInfo();
        Console.WriteLine($" Brand of CAR: {Brand}");
        Console.WriteLine(" =============");
    }
}