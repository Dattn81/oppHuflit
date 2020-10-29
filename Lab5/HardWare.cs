using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class HardWare:Product
    {
        double weight { get; set; }
        public HardWare(string name, double price, double weight) : base(name, price)
        {
            this.weight = weight;
        }
        public void outPut()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Price: "+price);
            Console.WriteLine("Weight: "+weight);
        }
    }
}
