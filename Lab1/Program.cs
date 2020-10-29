using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai1

            //Account taikhoan1 = new Account("123456",88888888);
            //Console.WriteLine("Ma so tai khoan :" + taikhoan1.getmasoTK());
            //Console.WriteLine("So tien :" + taikhoan1.getsoTien());
            //taikhoan1.setsoTien(500);
            //Console.WriteLine("So tien sau cap nhat" + taikhoan1.getsoTien());


            //Bai2

            //Book book1 = new Book("B1234", "Mindset", 7000, 700);
            //Console.WriteLine("Ma so sach: " +book1.getmaSach());
            //Console.WriteLine("Ten sach: "+book1.gettenSach());
            //Console.WriteLine("Gia sach: "+book1.getgiaSach());
            //Console.WriteLine("Giam gia: "+book1.getgiamGia());
            //book1.TinhTien();

            //Bai3
            //Student sv1 = new Student("TH151234", " Nguyen Van A ", 1997, "123 Nguyen Trai, P10, Q5, TP.HCM");
            //Console.WriteLine("Ma sinh vien : " + sv1.getmaSV());
            //Console.WriteLine("Ho ten: " + sv1.gethoTen());
            //Console.WriteLine("Nam sinh: " + sv1.getnamSinh());
            //Console.WriteLine("Dia chi: " + sv1.getdiaChi());
            //sv1.tinhTuoi();

            //Bai4
            Circle hinhtron = new Circle();
            hinhtron.inPut();
            hinhtron.outPut();
            hinhtron.chuviHinhTron();
            hinhtron.dientichHinhTron();

            Console.ReadLine();
        }
    }
}
