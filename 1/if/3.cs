using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Month
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Convering console to russian
            Console.WriteLine("Введите номер месяца:");
            int month = Convert.ToInt32(Console.ReadLine());
            string answer = WhatSeason(month);
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        public static string WhatSeason(int month)
        {
            string answer;
            if ((month == 1) || (month == 2) || (month == 12))
            {
                answer = "Зима";
            }
            else if ((month >= 3) && (month <= 5))
            {
                answer = "Весна";
            }
            else if ((month >= 6) && (month <= 8))
            {
                answer = "Лето";
            }
            else if ((month >= 9) && (month <= 11))
            {
                answer = "Осень";
            }
            else
            {
                answer = "На этой планете такого месяца нет";
            }
            return answer;
        }
    }
}
