using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Input();

            Console.WriteLine("Thong tin da nhap: ");
            c.Output();
            Console.WriteLine("Nhap tai khoan can them: ");
            Account test1 = new Account();
            test1.Input();
            c.AddAccount(test1);
            c.Output();
            Console.WriteLine("Nhap tai khoan can tim: ");
            string s = Console.ReadLine();
            Account test= c.SearchAccount(s);
            if (test == null)
            {
                Console.WriteLine("Khong tim thay");
            }
            else
                test.Output();

            Console.ReadKey();
        }
    }
}
