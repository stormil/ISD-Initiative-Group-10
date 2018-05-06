using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class MyFile
    {
        private string Path;
        public void AddNameOfFile()
        {
            Path = @"D:\";
            Console.WriteLine("Input name of file: ");
            string temp = Console.ReadLine();
            Path += temp + ".txt";
        }
        public void WriteToFile()
        {
            using (StreamWriter myWriter = new StreamWriter(Path))
            {
                Console.WriteLine("Input your text:");
                string text = Console.ReadLine();
                myWriter.WriteLine(text);
            }
        }
        public void ReadText()
        {
            using (StreamReader myReader = new StreamReader(Path))
            {
                Console.WriteLine("Inputed Text:");
                Console.Write(myReader.ReadToEnd());
            }
        }
    }
}
