using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil Vlad = new ExcelentPupil();
            Pupil Egor = new ExcelentPupil();
            Pupil Borya = new GoodPupil();
            Pupil Korol = new BadPupil();
            ClassRoom FriendsClass = new ClassRoom(Vlad, Egor, Borya, Korol);
            FriendsClass.PrintInformation();
            Console.ReadKey();
        }
    }
}
