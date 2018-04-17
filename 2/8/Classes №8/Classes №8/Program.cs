using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes__8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(125, "Борис", "Варус");
            invoice1.Article = "Чебурек";
            invoice1.Quantity = 50;
            Console.WriteLine("Стоимость вашего товара с НДС равна: " + invoice1.CalculatePrice(true));
            Console.WriteLine("Стоимость вашего товара без НДС равна: " + invoice1.CalculatePrice(false));
            Console.ReadKey();
        }
    }
}
