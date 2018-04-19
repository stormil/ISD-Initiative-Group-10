using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    class Car : Vehicle
    {
        public Car(int x, int y, int price, int speed, int year)
        : base(x, y, price, speed, year)
        {

        }

        public override string ToString()
        {
            return "Машина находится в точке с координатами " + X + " " + Y + " Цена составляет " + Price + " Её максимальная скорость составляет " + Speed + "Выпущена она в " + Year + "году";  
        }


    }
}
