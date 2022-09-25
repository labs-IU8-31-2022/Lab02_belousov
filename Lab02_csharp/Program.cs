using Lab02_csharp;

class Program
{
    static void Main(string[] args)
    {
        
        ExcellentPupil p1 = new();
        GoodPupil p2 = new();
        BadPupil p3 = new();
        ClassRoom cr = new(p1, p2, p3);
        cr.TotalInfo();
    }
}