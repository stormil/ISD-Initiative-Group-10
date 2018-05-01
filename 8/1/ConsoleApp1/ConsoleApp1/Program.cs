using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class MyFactory<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyFactory<float> myFactory1 = new MyFactory<float>
            {
                 
            };
            MyFactory<int> myFactory2 = new MyFactory<int>
            {

            };
            MyFactory<double> myFactory3 = new MyFactory<double>
            {

            };

            Console.ReadKey();
        }
    }
}
