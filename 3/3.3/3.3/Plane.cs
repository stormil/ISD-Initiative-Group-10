using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    class Plane : Vehicle
    {
        private int height;
        private int capacity;

        public int Height { get => height; set => height = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public Plane(int x, int y, int price, int speed, int year, int height, int capacity)
        : base(x, y, price, speed, year)
        {
            this.height = height;
            this.capacity = capacity;
        }

        public override string ToString()
        {
            return "Самолет находится в точке с координатами " + X + " " + Y + ". Цена составляет " + Price + ". Его максимальная скорость составляет " + Speed + ". Выпущен он в " + Year + "году. " + "Максимальное количество пассажиров составляет : " + capacity + ". Высота: " + height + ".";
        }


    }
}
