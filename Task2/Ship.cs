namespace Task2;

public class Ship : Vehicle
{
    private string NameOfPort;
    private uint NumOfPas;

    public Ship(uint price, uint year, uint speed, uint numofpas, string port) : base(price, year, speed)
    {
        NumOfPas = numofpas;
        NameOfPort = port;
    }

    public override void TotalInfo()
    {
        base.TotalInfo();
        Console.WriteLine($" Number of passengers of SHIP: {NumOfPas} \n Name of port: {NameOfPort}");
        Console.WriteLine(" =============");
    }
}