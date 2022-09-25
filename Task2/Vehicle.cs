namespace Task2;

public class Vehicle
{
    private uint Price;
    private uint Year;
    private uint Speed;

    public Vehicle(uint price, uint year, uint speed)
    {
        Price = price;
        Year = year;
        Speed = speed;
    }

    public virtual void TotalInfo()
    {
        Console.WriteLine($" Price of vehicle: {Price}\n Year of release: {Year}\n Max Speed is: {Speed}");
    }
}