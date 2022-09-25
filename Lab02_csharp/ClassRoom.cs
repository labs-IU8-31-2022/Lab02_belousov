namespace Lab02_csharp;

public class ClassRoom
{
    private List<Pupil>? Pupils;
    public ClassRoom(params Pupil[] pupils)
    {
        Pupils = new List<Pupil>();
        foreach (var p in pupils)
        {
            Pupils.Add(p);
        }
    }

    public void TotalInfo()
    {
        foreach (var p in Pupils)
        {
            p.Study();
            p.Read();
            p.Write();
            p.Relax();
            Console.WriteLine("================\n");
        }
    }
}