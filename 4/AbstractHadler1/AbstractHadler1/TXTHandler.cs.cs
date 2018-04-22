using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractHadler1
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Txt-file changed");
        }

        public override void Create()
        {
            Console.WriteLine("Txt-file created");
        }

        public override void Open()
        {
            Console.WriteLine("Txt-file opened");
        }

        public override void Save()
        {
            Console.WriteLine("Txt-file saved");
        }
    }
}
