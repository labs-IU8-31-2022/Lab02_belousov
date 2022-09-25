namespace Lab02_csharp;

public class BadPupil : Pupil
{
    public override void Study() { Console.WriteLine("Pupil studies bad"); }

    public override void Read() { Console.Write("Pupil read bad\n"); }

    public override void Write() { Console.Write("Pupil writes bad\n"); }

    public override void Relax() { Console.Write("Pupil relax bad\n"); }
}