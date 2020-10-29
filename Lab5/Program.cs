using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //b123
            Student sv1 = new Student("18dh110216","Nguyen Thanh Dat","datdz@gmail.com");
            Console.WriteLine("Mssv: "+sv1.studentCode +" Name: " + sv1.name +  " Email: "+sv1.email);
            
            //b4
            Triangle tamgiac1 = new Triangle(2, 3);
            Console.WriteLine("S triangle is: " + tamgiac1.getArea());
            Rectangle chunhat1 = new Rectangle(2, 3);
            Console.WriteLine("S rectangle is: "+chunhat1.getArea());



            //b5
            SoftWare sw1 = new SoftWare("word", 12, "7.7");
            sw1.outPut();
            HardWare hw1 = new HardWare("Moniter", 100,24);
            hw1.outPut();

        }
    }
}
