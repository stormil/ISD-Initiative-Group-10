using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    class FileEditor
    {
        TextForm textForm = new TextForm();

        private void ReadToForm(string fileName)
        {

            using (var fileStream = new FileStream(fileName, FileMode.Open))
            using (var streamReader = new StreamReader(fileStream))
            {
                var s = streamReader.ReadLine();
                while (s != null)
                {
                    textForm.textBox.AppendText(s);
                    textForm.textBox.AppendText(Environment.NewLine);
                    s = streamReader.ReadLine();
                }
                Application.EnableVisualStyles();
                Application.Run(textForm);
            }
        }

        public void TryReadToForm(string fileName)
        {
            try
            {
                ReadToForm(fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while searching: " + e.Message);
            }
        }
    }
}
