using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Account
    {
        public string accountNumber { get; set; }
        public int balance { get; set; }
        public Account()
        {
            this.accountNumber = "No Account";
            this.balance = 0;
        }
        public Account(string accountNumber, int balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        public void Input()
        {
            Console.WriteLine("Ma so tai khoan: ");
            this.accountNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("so du  tai khoan: ");
            this.balance = Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Ma so tai khoan: " + this.accountNumber);
            Console.WriteLine("So du tai khoan: " + this.balance);
        }
    }
}
