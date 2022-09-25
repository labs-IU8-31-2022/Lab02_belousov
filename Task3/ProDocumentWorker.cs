namespace Task3;
using System;
using System.IO;

public class ProDocumentWorker : DocumentWorker
{
    public ProDocumentWorker(string path) : base(path) {}
    public override void OpenDocument()
    {
        base.OpenDocument();
        Console.WriteLine("У вас PRO-версия");
    }

    public override void EditDocument()
    {
        Console.WriteLine("Введите новое содержимое: \n");
        string NewData = Console.ReadLine();
        File.WriteAllText(this.Path, NewData);
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Файл сохранён в старом формате(сохранение в md доступно в EXPERT-версии)");
    }
}