using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class SoftWare:Product
    {
        string version { get; set; }
        public SoftWare(string name,double price, string version) : base(name, price)
        {
            this.version = version;
        }
        public void outPut()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Version: " + version);
        }
    }
}
