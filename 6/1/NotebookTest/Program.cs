using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("Classic", "Buromax", (decimal)15.09);
            Notebook notebook2 = new Notebook("Airplanes", "ZiBi", (decimal)46.48);

            notebook1.PrintInfomation();
            notebook2.PrintInfomation();

            Console.ReadKey();

        }
    }
}
