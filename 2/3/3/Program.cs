using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Fight Club", "Chuck Palahniuk", 
                "The men in Fight Club are sick of being treated as second-class citizens. " +
                "They want a fighting chance at success. " +
                "They want health care. They want to not be treated like slaves." );
            book.WriteBook();
            
            Console.ReadKey();
        }
    }
}
