using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class MyClass
    {
        public string charge;
    }
    struct MyStruct
    {
        public string charge;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MyClass myClass = new MyClass
            {
                charge = "не изменено"
            };
            MyStruct myStruct = new MyStruct
            {
                charge = "не изменено"
            };
            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine("Класс: " + myClass.charge);
            Console.WriteLine("Структура: " + myStruct.charge);
            Console.ReadKey();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.charge = "изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.charge = "изменено";
        }

    }
}
