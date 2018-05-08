using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateAndDeleteFolders
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter directory in which you want to create folders: ");
            string path = Console.ReadLine();
            string folderName = "Folder_";

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Directory.CreateDirectory(@path + folderName + i.ToString());
                }

                Console.WriteLine("The Folders were created!");

                Console.ReadKey();

                for (int i = 0; i < 100; i++)
                {
                    Directory.Delete(@path + folderName + i.ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR! Exeption: " + e.Message);
            }
            Console.ReadKey();

        }
    }
}
