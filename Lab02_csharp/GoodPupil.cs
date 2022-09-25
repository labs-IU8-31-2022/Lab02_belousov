namespace Lab02_csharp;

public class GoodPupil : Pupil
{   
    public override void Study() { Console.WriteLine("Pupil studies good"); }

    public override void Read() { Console.Write("Pupil read good\n"); }

    public override void Write() { Console.Write("Pupil writes good\n"); }

    public override void Relax() { Console.Write("Pupil relax good\n"); }
}