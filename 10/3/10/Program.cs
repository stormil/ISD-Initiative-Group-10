using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - demonstrate work of the program on ready file \n2 - input your own filename and search area");
            int userChoice;
            while ((!int.TryParse(Console.ReadLine(), out userChoice)) || (userChoice >= 3) || (userChoice <= 0))
            {
                Console.WriteLine("Wrong index. Try again");
            }
            string fileName, areaOfSearch;
            if (userChoice == 1)
            {
                fileName = "lorem.txt";
                areaOfSearch = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            }
            else
            {
                Console.WriteLine("Input filename");
                fileName = Console.ReadLine();
                Console.WriteLine("Input area of search:");
                areaOfSearch = Console.ReadLine();
            }
            var filePath = FileSearcher.SearchFile(fileName, areaOfSearch);
            if (filePath != null)
            {
                var fileReader = new FileEditor();
                fileReader.TryReadToForm(filePath);
                FileCompressor.Compress(filePath, filePath + ".gz");
            }

            Console.ReadKey();
        }
    }
}
