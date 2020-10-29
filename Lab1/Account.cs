using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Account
    {
        String masoTK;
        double soTien;
        public Account()
        {

        }
        public Account(String masoTK ,double soTien)
        {
            this.masoTK = masoTK;
            this.soTien = soTien;
        }
        public String getmasoTK()
        {
            return masoTK;
        }
        public void setmasoTK(String masoTK) 
        {
            this.masoTK = masoTK;
        }
        public double getsoTien()
        {
            return soTien;
        }
        public void setsoTien(double soTien)
        {
            this.soTien = soTien;
        }

    }
}
