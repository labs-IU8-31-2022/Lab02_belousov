using Task2;
class Program
{
    static void Main(string[] args)
    {
        Plane pl = new Plane(200000, 2010, 1000, 5000);
        Car car = new Car(20000, 2015, 250, "BMW");
        Ship sh = new Ship(300000, 2007, 60, 600, "Sevastopol'");
        pl.TotalInfo();
        car.TotalInfo();
        sh.TotalInfo();
    }
}