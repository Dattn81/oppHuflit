using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 2

            //Book book1 = new Book("B1234", "Mindset", 7000, 700);
            //book1.giaSachFinal();

            //Bai 5

            Circle ht1 = new Circle(-1);
            Circle ht2 = new Circle(2);
            Console.WriteLine("Dien tich hinh tron1: " + ht1.dientich());
            Console.WriteLine("Chu vi hinh tron1: " + ht1.chuvi());
            Console.WriteLine("Dien tich hinh tron2: " + ht2.dientich());
            Console.WriteLine("Chu vi hinh tron2: " + ht2.chuvi());

            //Bai7
            //Console.Write("Nhap vao trai banh n=");
            //int n = int.Parse(Console.ReadLine());
            //Ball[] ht = new Ball[n];
            //for(int i = 0; i < n; i++)
            //{
            //    ht[i] = new Ball();
            //}
            //Console.Write("Trai banh dau tien ");
            //ht[0].inPut();
            //for(int i = 0; i <n; i++)
            //{
            //    ht[i].outPut();
            //}
            //ht[0].Throw();
            //ht[1].Throw();
            //ht[0].Pop();
            //ht[0].Throw();
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write("So lan nem banh {0} la {1}", i + 1, ht[i].timeofthrow);

            //}
            Console.ReadKey();
        }
    }
}
