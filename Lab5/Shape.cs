using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Shape
    {
        public double height { get; set; }
        public double weight { get; set; }
        public Shape()
        {

        }
        public Shape(double height, double weight){
            this.height = height;
            this.weight = weight;
        }

    }
}
