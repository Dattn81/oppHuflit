using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Circle
    {
        double r;
        public Circle()
        {
            r = 1;
        }
        public double getR()
        {
            return r;
        }
        public void setR(double r)
        {
            this.r = r;
        }
        public void inPut()
        {
            Console.WriteLine("Nhap hinh tron: ");
            Console.WriteLine("Nhap ban kinh r: ");
            r = int.Parse(Console.ReadLine());
        }
        public void outPut()
        {
            Console.WriteLine("Ban kinh vua nhap la: " + r);
        }
        public void dientichHinhTron()
        {
            double s = 3.14 * r * r;
            Console.WriteLine("Dien tich la " + s);
        }
        public void chuviHinhTron()
        {
            double c = 2 * 3.14 * r;
            Console.WriteLine("Chu vi la: " + c);
        }
    }
}
