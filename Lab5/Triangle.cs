using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Triangle:Shape
    {
        public Triangle(double height, double weight):base(height,weight)
        {
        }
        public double getArea()
        {
            return .5 * weight * height;
        }
    }
}
