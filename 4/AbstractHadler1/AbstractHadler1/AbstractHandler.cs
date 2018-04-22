using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHadler1
{
    abstract class AbstractHandler
    {
        public string Name { set; get; }

        public abstract void Open(String path);
        public abstract void Create(String path);
        public abstract void Change(String text);
        public abstract void Save();
    }
}
