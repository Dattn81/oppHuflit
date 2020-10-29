using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Ball
    {
        public int radius { get; set; }
        public int timeofthrow { get; set; }
        public Color mausac { get; set; }
        public Ball()
        {
            this.radius = 1;
            this.timeofthrow = 0;
            this.mausac = new Color();
        }
        public Ball(int radius, int timtofthow, Color mausac)
        {
            this.radius = radius;
            this.timeofthrow = timeofthrow;
            this.mausac = mausac;
        }
        public void Pop()
        {
            this.radius = 0;
        }
        public void Throw()
        {
            this.timeofthrow += 1;
        }
        public void inPut()
        {
            Console.WriteLine("Nhap bk ");
            this.radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so lan nem");
            this.timeofthrow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau do");
            this.mausac.red = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau xanh la ");
            this.mausac.green = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau xanh duong");
            this.mausac.blue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap do trong suot");
            this.mausac.alpha = Convert.ToInt32(Console.ReadLine());
        }
        public void outPut()
        {
            Console.WriteLine("Radius = {0}", this.radius);
            Console.WriteLine("Timeofthrow = {0}", this.timeofthrow);
            Console.WriteLine("Mausac: red {0} , green {1} ,blue {2} ,alpha {3}",
            this.mausac.red, this.mausac.green, this.mausac.blue, this.mausac.alpha);
        }

    }
}
