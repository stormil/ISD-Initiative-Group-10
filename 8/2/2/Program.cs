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
            MyList<int> my = new MyList<int>();
            int n;
            bool flag = true;
            while (flag == true)
            {
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Number");
                            int x = int.Parse(Console.ReadLine());
                            my.Add(x);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Index");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine(my[x]);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Emount of Numbers is: " + my.Count);
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
