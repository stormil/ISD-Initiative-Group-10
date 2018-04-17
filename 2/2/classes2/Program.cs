using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Sides of rectangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.Write("Area of your rectangle: ");
            Console.Write(rectangle.Area + "\n");
            Console.Write("Perimeter of your rectangle: ");
            Console.Write(rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}
