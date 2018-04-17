using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();

            user1.Login = "Navin_lor";
            user1.Name = "Ivan";
            user1.Surname = "Korol";
            user1.Age = 19;

            Console.WriteLine(user1);

            Console.ReadKey();
        }
    }
}
