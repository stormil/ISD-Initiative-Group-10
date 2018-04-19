using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    class Ship : Vehicle
    {
        private int capacity;
        private int port;

        public int Capacity { get => capacity; set => capacity = value; }
        public int Port { get => port; set => port = value; }

        public Ship(int x, int y, int price, int speed, int year, int capacity, int port)
        : base(x, y, price, speed, year)
        {
            this.capacity = capacity;
            this.port = port;
        }

        public override string ToString()
        {
            return "Корабль находится в точке с координатами " + X + " " + Y + ". Цена составляет " + Price + ". Его максимальная скорость составляет " + Speed + ". Выпущен он в " + Year + "году." + " Максимальное количество пассажиров составляет : " + capacity + ". Порт приписки: " + port + ".";
        }

    }
}
