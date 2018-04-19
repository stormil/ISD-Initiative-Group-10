using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine(
                "1 - открыть документ\n" +
                "2 - отредактировать документ \n" +
                "3 - сохранить документ \n" +
                "4 - показать меню \n" +
                "5 - выйти"
                );
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string key;
            Console.WriteLine("Введите ключ доступа:");
            key = Console.ReadLine();

            DocumentWorker documentWorker;
            if (key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            else if (key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else
            {
                documentWorker = new DocumentWorker();
            }

            ShowMenu();

            int action = 0;
            do
            {
                Console.WriteLine("Что вы хотите сделать?");

                action = int.TryParse(Console.ReadLine(), out action) ? action : 0;

                switch (action)
                {
                    case 1:
                        documentWorker.OpenDocument();
                        break;
                    case 2:
                        documentWorker.EditDocument();
                        break;
                    case 3:
                        documentWorker.SaveDocument();
                        break;
                    case 4:
                        ShowMenu();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
            while (action != 5);
        }
    }
}
