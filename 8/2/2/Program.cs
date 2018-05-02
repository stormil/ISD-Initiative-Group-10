using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            MyList<int> my = new MyList<int>();
            my.Add(x);
            Console.WriteLine(my[1]);
            Console.ReadKey();
        }
    }
}
