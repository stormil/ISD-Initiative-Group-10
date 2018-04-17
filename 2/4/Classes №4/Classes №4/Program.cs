using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point("A",1,2);
            Point point2 = new Point("B", -1, 8);
            Point point3 = new Point("C", 3, -5);

            Figure figure = new Figure(point1, point2, point3);

            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
