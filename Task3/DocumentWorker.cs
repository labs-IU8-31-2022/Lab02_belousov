namespace Task3;
using System;
using System.IO;
public class DocumentWorker
{
    protected FileInfo _File;
    protected string Path;// = @"/Users/theblindpew/RiderProjects/Lab02_csharp/Task3/File.txt";

    public DocumentWorker(string path)
    {
        Path = path;
        _File = new FileInfo(Path);
    }

    public virtual void OpenDocument()
    {
        if (!_File.Exists)
        {
            _File.Create();
        }
        string line;
        using (StreamReader sr = new StreamReader(Path))
        {
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        Console.WriteLine($"Документ {_File.Name} открыт (редактирование и сохранение доступно в PRO-версии и EXPERT-версии)");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Извините, редактирование доступно только в PRO-версии и EXPERT-версии");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Извините, сохранение доступно только в PRO-версии и EXPERT-версии");
    }
}