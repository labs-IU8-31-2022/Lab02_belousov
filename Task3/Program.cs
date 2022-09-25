using System.IO;
using Task3;

class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        Console.WriteLine("Введите путь: ");
        string path = Console.ReadLine();
        Console.WriteLine("Введите ключ: ");
        string key = Console.ReadLine();
        DocumentWorker current = new DocumentWorker(path);
        if (key == "pro" || key == "PRO" || key == "Pro")
        {
            current = (ProDocumentWorker) new ProDocumentWorker(path);
        } else if (key == "EXPERT" || key == "Expert" || key == "expert")
        {
            current = (ExpertDocumentWorker) new ExpertDocumentWorker(path);
        }

        while (flag)
        {
            Console.WriteLine("1 - Открыть документ; 2 - отредактировать; 3 - сохранить; 0 - выйти");
            int num = Convert.ToInt16(Console.ReadLine());
            switch (num)
            {
                case 1:
                {
                    current.OpenDocument();
                    break;
                }
                case 2:
                {
                    current.EditDocument();
                    break;
                }
                case 3:
                {
                    current.SaveDocument();
                    break;
                }
                case 0:
                {
                    flag = false;
                    break;
                }
                default:
                {
                    Console.WriteLine("Не является командой");
                    break;
                }
            }   
        }
    }
}