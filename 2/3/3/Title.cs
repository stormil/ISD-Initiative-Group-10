using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Title
    {
        private string name;

        public Title(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Title: " + name);
        }
    }
}
