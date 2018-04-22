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
            Console.WriteLine("Work of the player");
            IPlayable player = new Player();
            player.Play();
            player.Pause();
            player.Stop();

            Console.WriteLine("Work of the recorder:");
            IRecodable recorder = (IRecodable)player;
            recorder.Record();
            recorder.Pause();
            recorder.Stop();

            Console.ReadKey();
        }
    }
}
