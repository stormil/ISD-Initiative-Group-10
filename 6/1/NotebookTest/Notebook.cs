using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookTest
{
    struct Notebook
    {
        private string model;
        private string producer;
        private decimal price;

        public Notebook(string initModel, string initProducer, decimal initPrice)
        {
            model = initModel;
            producer = initProducer;
            price = initPrice;
        }

        public override string ToString()
        {
            return $"Model: {model}\npPoducer: {producer}\nPrice: {price}\n";
        }

        public void PrintInfomation()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
