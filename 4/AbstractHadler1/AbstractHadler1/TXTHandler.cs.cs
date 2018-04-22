using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AbstractHadler1
{
    class TXTHandler : AbstractHandler
    {
       

        public override void Change(string path)
        {
            Console.WriteLine($"File before changing: \n {text}");
            text = text.ToUpper();
            Console.WriteLine($"File after changing: \n {text}");
        }

        public override void Create(string path)
        {
            File.Create(path);
        }

        public override void Open(string path) 
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception e)
            {
                e.ToString();
            }
            Console.WriteLine("File is opened.");
        }

        public override void Save()
        {
            StreamWriter writer = new StreamWriter(path);
        }
    }
}
