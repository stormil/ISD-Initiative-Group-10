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
            string filePath = FileSearcher.SearchFile("upcast.txt", @"D:/NOW/");
            if (filePath != null)
            {
                FileEditor fileReader = new FileEditor();
                fileReader.TryReadToForm(filePath);
                FileCompressor.Compress(filePath, filePath + "_Compressed");
            }

            Console.ReadKey();
        }
    }
}
