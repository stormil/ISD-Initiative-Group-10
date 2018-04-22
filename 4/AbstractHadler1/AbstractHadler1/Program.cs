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

            txtFile.Open("D:\\1\\txtFile.txt");
            txtFile.Change("");
            Console.ReadKey();




        }
    }
}
