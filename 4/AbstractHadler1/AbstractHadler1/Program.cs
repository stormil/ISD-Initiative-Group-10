using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHadler1
{
    class Program
    {
        static void Main(string[] args)
        {
            TXTHandler txtFile = new TXTHandler();
            DOCHandler docFile = new DOCHandler();
            XMLHandler xmlFile = new XMLHandler();
            txtFile.Create();
            txtFile.Open();
            txtFile.Change();
            txtFile.Save();
            docFile.Create();
            docFile.Open();
            docFile.Change();
            docFile.Save();
            xmlFile.Create();
            xmlFile.Open();
            xmlFile.Change();
            xmlFile.Save();
            Console.ReadKey();
        }
    }
}
