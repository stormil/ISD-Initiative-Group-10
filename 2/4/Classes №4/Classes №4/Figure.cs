using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes__4
{
    class Figure
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;
        private Point e;

        public Figure(Point A, Point B, Point C)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = null;
            this.e = null;
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
            this.e = null;
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
            this.e = E;
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(((A.X - B.X) * (A.X - B.X)) + ((A.Y - B.Y) * (A.Y - B.Y)));
        }

        public void PerimeterCalculator()
        {
            double Perimeter = LengthSide(a, b) + LengthSide(b, c);
            if (d == null)
            {
                Perimeter += LengthSide(a, c);
                Console.WriteLine("Периметр равен: " + Perimeter);
                Console.WriteLine("Фигура - треугольник");
            }
            else
            if (e == null)
            {
                Perimeter = Perimeter + LengthSide(c, d) + LengthSide(d, a);
                Console.WriteLine("Периметр равен: " + Perimeter);
                Console.WriteLine("Фигура - четырёхугольник");
            }
            else
            {
                Perimeter = Perimeter + LengthSide(c, d) + LengthSide(d, e) + LengthSide(e, a);
                Console.WriteLine("Периметр равен: " + Perimeter);
                Console.WriteLine("Фигура - пятиугольник");
            }
        }

    }
}
