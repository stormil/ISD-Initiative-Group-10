using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> mydictionary = new Dictionary<int, string>();
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
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Text");
                            string text = Console.ReadLine();
                            mydictionary.Add(number, text);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Index");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine(mydictionary[x]);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Emount of Numbers is: " + mydictionary.Count);
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