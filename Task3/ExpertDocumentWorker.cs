namespace Task3;

public class ExpertDocumentWorker : ProDocumentWorker
{
    public ExpertDocumentWorker(string path) : base(path) {}
    public override void OpenDocument()
    {
        base.OpenDocument();
        Console.WriteLine("У вас EXPERT-версия");
    }

    public override void EditDocument()
    {
        base.EditDocument();
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Работа над изменением формата только ведётся, ждите обновлений)");
    }
}