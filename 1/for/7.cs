using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class GoosesAndRabbit
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int goose, rabbit;
            for (rabbit = 0; rabbit <= 16; rabbit++)
            {
                goose = 32 - 2 * rabbit;
                Console.WriteLine("Гуси:" + goose.ToString() + " Кролики: " + rabbit.ToString());
            }
            Console.ReadKey();
        }
    }
}
