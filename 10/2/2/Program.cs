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
            MyFile myfile = new MyFile();
            bool flag = true;
            int n;
            while (flag)
            {
                Console.WriteLine("Input 1 if you want to add Name of File");
                Console.WriteLine("Input 2 if you want to write in file");
                Console.WriteLine("Input 3 if you want to read file");
                Console.WriteLine("Push any other key if you want quit menu");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            myfile.AddNameOfFile();
                            break;
                        }
                    case 2:
                        {
                            myfile.WriteToFile();
                            break;
                        }
                    case 3:
                        {
                            myfile.ReadText();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Uncorrect");
                            Console.WriteLine("If you want to exit menu press 1, else press 0");
                            int answer = Convert.ToInt32(Console.ReadLine());
                            switch (answer)
                            {
                                case 1:
                                    {
                                        flag = false;
                                        break;
                                    }
                                case 0:
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        flag = false;
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
       
    }

}
