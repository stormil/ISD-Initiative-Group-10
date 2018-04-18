using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string key;
            Console.WriteLine("Введите ключ доступа:");
            key = Console.ReadLine();

            DocumentWorker documentWorker;
            if (key=="exp")
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

            Console.WriteLine("Что вы хотите сделать с докуметом?");
            Console.WriteLine("1 - открыть \n2 - отредактировать \n3 - сохранить");

            int action = Convert.ToInt32(Console.ReadLine());
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
            }

            Console.ReadKey();
        }
    }
}
