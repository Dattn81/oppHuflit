using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
    {
        String maSV;
        String hoTen;
        int namSinh;
        String diaChi;
        public Student() { }
        public Student( String maSV, String hoTen){
            this.maSV = maSV;
            this.hoTen = hoTen;
        }
        public Student(String maSV, String hoTen, int namSinh, String diaChi){
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
        }
        public String getmaSV(){
            return maSV;
        }
        public void setmaSV(String maSV){
            this.maSV = maSV;
        }
        public String gethoTen()
        {
            return hoTen;
        }
        public void sethoTen(String hoTen)
        {
            this.hoTen = hoTen;
        }
        public int getnamSinh()
        {
            return namSinh;
        }
        public void setnamSinh(int namSinh)
        {
            this.namSinh = namSinh;
        }
        public String getdiaChi()
        {
            return diaChi;
        }
        public void sediaChi(String diaChi)
        {
            this.diaChi = diaChi;
        }
        public void tinhTuoi()
        {
            DateTime d = DateTime.Now;
            int tuoi = d.Year - namSinh;
            Console.WriteLine("tuoi cua sinh vien : " + tuoi);
        }


    }
}
