using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes__4
{
    class Point
    {
        private int _x;
        private int _y;
        private string _name;

        public Point(string name, int x, int y)
        {
            _x = x;
            _y = y;
            _name = name;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public string Name
        {
            get { return _name; }
        }


    }
}
