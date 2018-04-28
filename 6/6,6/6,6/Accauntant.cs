using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6
{
    enum Post : int {  CEO=8,  secretary=10, cleaner=12 }

    class Accauntant
    {              
        public bool AskForBonus (Post worker, int hours)
        {
            if (hours>(int)worker)
            {
                Console.WriteLine("Вы получите премию ");
                return true;
            }
            else
            {
                Console.WriteLine("Вы не получите премию");
                return false;
            }
        }
    }
}
