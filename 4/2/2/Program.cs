using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            player.Play();
            IRecodable recorder = (IRecodable)player;
            recorder.Record();
            Console.ReadKey();
        }
    }
}
