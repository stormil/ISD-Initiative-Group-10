using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    class Vehicle
    {
        private int x;
        private int y;
        private int price;
        private int speed;
        private int year;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Price { get => price; set => price = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Year { get => year; set => year = value; }

        public Vehicle(int x, int y, int price, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }


    }
}

