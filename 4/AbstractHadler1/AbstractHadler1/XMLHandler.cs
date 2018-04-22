using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractHadler1
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XML-file changed");
        }

        public override void Create()
        {
            Console.WriteLine("XML-file created");
        }

        public override void Open()
        {
            Console.WriteLine("XML-file opened");
        }

        public override void Save()
        {
            Console.WriteLine("XML-file saved");
        }
    }
}
