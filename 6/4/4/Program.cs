using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your birthday in format: yyyy-mm-dd");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            {
                DateTime now = DateTime.Today;
                if ((now - birthday).Days < 0) // check on birthday of unexiting human
                {
                    throw new ArgumentException();
                }

                DateTime nextBirthday = new DateTime(now.Year, birthday.Month, birthday.Day);
                TimeSpan interval = nextBirthday - now;
                if (interval.Days <= 0)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                    interval = nextBirthday - now;
                }
                Console.WriteLine(interval.Days);
            }
            else
            {
                throw new ArgumentException();
            }
            Console.ReadKey();
        }
    }
}
