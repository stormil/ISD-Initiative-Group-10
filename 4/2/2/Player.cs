using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Player: IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Playing music");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause music");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop music");
        }

        public void Record()
        {
            Console.WriteLine("Recording");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause recording");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop recording");
        }
    }
}
