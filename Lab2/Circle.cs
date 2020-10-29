using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Circle
    {
        private double R;
        public  double r
        {
            get { return this.R; }
            set
            {
                this.R = value;
                if (this.R < 0) this.R = 0;
            }
        }
        public Circle(double r)
        {
            this.r = r;
        }
       
        public Circle() : this(0){}
        public double dientich()
        {
            return Math.PI * Math.Pow(this.r, 2);
        }
        public double chuvi()
        {
            return 2 * Math.PI * this.r;
        }
    }
}
