using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Book
    {
        String maSach;
        String tenSach;
        double giaSach;
        double giamGia;
        public Book()
        {

        }
        public Book(String maSach, String tenSach)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
        }
        public Book(String maSach, String tenSach, double giaSach, double giamGia)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.giaSach = giaSach;
            this.giamGia = giamGia;
        }
        public String getmaSach()
        {
            return maSach;
        }
        public void setmaSach(String maSach)
        {
            this.maSach = maSach;
        }

        public String gettenSach()
        {
            return tenSach;
        }
        public void settenSach(String tenSach)
        {
            this.tenSach = tenSach;
        }

        public double getgiaSach()
        {
            return giaSach;
        }
        public void setgiaSach(double giaSach)
        {
            this.giaSach = giaSach;
        }

        public double getgiamGia()
        {
            return giamGia;
        }
        public void setgiamGia(double giamGia)
        {
            this.giamGia = giamGia;
        }
        public void TinhTien()
        {
            double tongTien = this.giaSach - this.giamGia;
            Console.WriteLine("Gia ban cua sach: " + tongTien);
        }
    }
}
