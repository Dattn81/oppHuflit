using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Book
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public int giaSach;
        public int giaGiam;
        public int GiaSach { 
            get { return giaSach; }
            set
            {
                this.giaSach = value;
                if (giaSach <= 0)
                    this.giaSach = 1;
            }
       }
        public int GiaGiam
        {
            get { return GiaGiam; }
            set
            {
                this.GiaGiam = value;
                if (GiaGiam <= 0)
                    this.GiaGiam = 1;
            }
        }
        public Book(string maSach, string tenSach, int giaSach, int giaGiam)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.giaSach = giaSach;
            this.giaGiam = giaGiam;
        }
        public void giaSachFinal()
        {
            double n = giaSach - giaGiam;
            Console.WriteLine("Gia sach sau khi giam: " + n);
        }
    }
}
