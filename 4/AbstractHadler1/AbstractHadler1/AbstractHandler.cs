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

        protected string text;

        public abstract void Open(string path);
        public abstract void Create(string path);
        public abstract void Change();
        public abstract void Save(string path);
    }
}
