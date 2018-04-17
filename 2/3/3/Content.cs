using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Content
    {
        private string contentOfSomething;

        public Content(string contentOfSomething)
        {
            this.contentOfSomething = contentOfSomething;
        }

        public string ContentOfSomething { get => contentOfSomething; set => contentOfSomething = value; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Content:" + contentOfSomething);
        }
    }
}
