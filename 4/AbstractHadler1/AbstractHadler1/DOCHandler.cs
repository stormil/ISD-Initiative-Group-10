using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHadler1
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Doc-file changed");
        }

        public override void Create()
        {
            Console.WriteLine("Doc-file created");
        }

        public override void Open()
        {
            Console.WriteLine("Doc-file opened");
        }

        public override void Save()
        {
            Console.WriteLine("Doc-file saved");
        }
    }
}
