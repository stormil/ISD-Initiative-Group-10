using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent pupil study diligently");
        }
        public override void Read()
        {
            Console.WriteLine("Excelent pupil read attentively");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent pupil write legibly");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent pupil relax rarely");
        }
    }
}
