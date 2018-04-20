using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil study not so good");
        }
        public override void Read()
        {
            Console.WriteLine("Bad pupil read inattentively");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent pupil write inattentively too");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent pupil relax often");
        }
    }
}
