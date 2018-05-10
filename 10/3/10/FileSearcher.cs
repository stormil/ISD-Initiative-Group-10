using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class FileSearcher
    {
        private static string[] SearchByFullName(string name, string searchArea)
        {
            string[] allFiles = null;
            try
            {
                allFiles = Directory.GetFiles(searchArea, "*" + name, SearchOption.AllDirectories);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while searching: " + e.Message);
            }
            return allFiles;
        }

        public static string SearchFile(string name, string searchArea)
        {
            var results = SearchByFullName(name, searchArea);
            if (results == null)
            {
                return null;
            }
            if (results.Length == 0)
            {
                Console.WriteLine("We have not found such file");
                return null;
            }
            else 
            {
                string filePath;
                if (results.Length == 1)
                {
                    filePath = results[0];
                }
                else
                {
                    Console.WriteLine("We found " + results.Length + " files. Chose your file:");
                    for (int i = 0; i < results.Length; i++)
                    {
                        Console.WriteLine(i + " - " + results[i]);
                    }
                    var userIndex = 0;
                    while ((!int.TryParse(Console.ReadLine(), out userIndex)) || (userIndex >= results.Length) || (userIndex < 0))
                    {
                        Console.WriteLine("Wrong index. Try again");
                    }
                    filePath = results[userIndex];
                }
                return filePath;
            }
        }
    }
}
