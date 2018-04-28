using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            accauntant.AskForBonus(Post.CEO, hours:2);
            Console.WriteLine("Директор поработал и получит зарплату");
            accauntant.AskForBonus(Post.CEO, hours: 10);
            Console.WriteLine("Директор молодец хорошо поработал");
            accauntant.AskForBonus(Post.secretary, hours: 2);
            Console.WriteLine("Секретарь поработал и получит свою зарплату");
            accauntant.AskForBonus(Post.secretary, hours: 12);
            Console.WriteLine("Секретарь молодец хорошо поработал");
            accauntant.AskForBonus(Post.cleaner, hours: 3);
            Console.WriteLine("Уборщик поработал и получит свою зарплату");
            accauntant.AskForBonus(Post.cleaner, hours: 13);
            Console.WriteLine("Уборщик молодец хорошо поработал");
            Console.ReadKey();
        }
    }
}
