namespace Lab02_csharp;
using Lab02_csharp;
public class ExcellentPupil : Pupil
{
    public override void Study() { Console.WriteLine("Pupil studies excellent"); }

    public override void Read() { Console.Write("Pupil read excellent\n"); }

    public override void Write() { Console.Write("Pupil writes excellent\n"); }

    public override void Relax() { Console.Write("Pupil relax excellent\n"); }
}