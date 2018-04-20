using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3._2
{
    class ClassRoom
    {
        private List<Pupil> listOfPupils;
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            listOfPupils.Add(pupil1);
            listOfPupils.Add(pupil2);
            listOfPupils.Add(pupil3);
            listOfPupils.Add(pupil4);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            listOfPupils.Add(pupil1);
            listOfPupils.Add(pupil2);
            listOfPupils.Add(pupil3);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            listOfPupils.Add(pupil1);
            listOfPupils.Add(pupil2);
        }
        public void PrintInformation()
        {
            foreach(Pupil p in listOfPupils) {
                p.Read();
                p.Relax();
                p.Study();
                p.Write();
            }
        }
    }
}
