using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Rectangle:Shape
    {
        public Rectangle(double height, double weight) : base(height, weight)
        {
        }
        public double getArea()
        {
            return  weight * height;
        }
    }
}
