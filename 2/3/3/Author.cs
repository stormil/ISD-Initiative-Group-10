using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Author
    {
        private string writer;

        public Author(string writer)
        {
            this.writer = writer;
        }

        public string Writer { get => writer; set => writer = value; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Author: " + writer);
        }
    }
}
