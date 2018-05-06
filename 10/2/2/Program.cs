using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{

    class Program
    {
        static void Main(string[] args)
        {
            string path;
            AddNameOfFile(out path);
            Console.WriteLine(path);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter myWriter = new StreamWriter(path))
            {
                Console.WriteLine("Input your text:");
                string text = Console.ReadLine();
                myWriter.WriteLine(text);
            }

            using (StreamReader myReader = new StreamReader(path))
            {
                Console.WriteLine("Inputed Text:");
                Console.Write(myReader.ReadToEnd());
            }
            Console.ReadKey();
        }
        static void AddNameOfFile(out string path)
        {
            path = @"D:\";
            Console.WriteLine("Input name of file: ");
            string temp = Console.ReadLine(); 
            path += temp + ".txt";
        }
    }

}
