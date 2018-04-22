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

        public abstract void Open(string path);
        public abstract void Create(string path);
        public abstract void Change(string text);
        public abstract void Save();
    }
}
