using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите свою дату рождения (гггг.мм.дд) " );
            string birthday = Console.ReadLine();
            CountToBirthday guy = new CountToBirthday(birthday);
            Console.WriteLine(guy.ToString());

            Console.ReadKey();
        }
    }
}
