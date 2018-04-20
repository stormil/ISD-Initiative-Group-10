using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3._2
{
    class ClassRoom
    {
        private List<Pupil> listofpupils;
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            listofpupils.Add(pupil1);
            listofpupils.Add(pupil2);
            listofpupils.Add(pupil3);
            listofpupils.Add(pupil4);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            listofpupils.Add(pupil1);
            listofpupils.Add(pupil2);
            listofpupils.Add(pupil3);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            listofpupils.Add(pupil1);
            listofpupils.Add(pupil2);
        }
        public void printinformation()
        {
            for(int i = 0; i < listofpupils; i++)
        }
    }
}
