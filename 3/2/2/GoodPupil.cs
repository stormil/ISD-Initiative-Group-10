using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil study normal");
        }
        public override void Read()
        {
            Console.WriteLine("Good pupil read normal");
        }
        public override void Write()
        {
            Console.WriteLine("Good pupil write normal");
        }
        public override void Relax()
        {
            Console.WriteLine("Good pupil relax normal");
        }
    }
}
