using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes__4
{
    class Point
    {
        private int x;
        private int y;
        private string name;

        public Point(string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }


    }
}
