using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3
{
    class Customer
    {
        public string guestCode { get; set; }
        public string identityCard { get; set; }
        public string address { get; set; }
        public ArrayList account = new ArrayList();
        public Customer()
        {
            this.guestCode = "No Guest Code";
            this.identityCard = "No Identity Card";
            this.address = "No Address";
        }
        public Customer(string guestCode, string identityCard, string address)
        {
            this.guestCode = guestCode;
            this.identityCard = identityCard;
            this.address = address;
        }
        public Customer(string guestCode, string identityCard, string address,ArrayList account)
        {
            this.guestCode = guestCode;
            this.identityCard = identityCard;
            this.address = address;
            this.account = account;
        }
        public void Input()
        {
            Console.WriteLine("Ma khach: ");
            this.guestCode = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Chung minh nhan dan: ");
            this.identityCard = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Dia chi ");
            this.address = Convert.ToString(Console.ReadLine());
            int i = 1;
            String tiep = "";
            while (true) {
                Console.WriteLine("Nhap tai khoan {0}: " + i);
                Account a = new Account();
                a.Input();
                this.account.Add(a);
                Console.WriteLine("Khach hang con tai khoan khong: (Y/N) ");
                // tiep la tiep tuc 
                tiep = Convert.ToString(Console.ReadLine());
                if (tiep.Trim().ToUpper() == "N") break;
                i++;

            }
        }
        public void Output() {
            Console.WriteLine("Ma so khach hang: {0}", this.guestCode);
            Console.WriteLine("So chung minh thu: {0}", this.identityCard);
            Console.WriteLine("Dia chi: {0}", this.address);
            int count = 1;
            foreach(Account a in this.account){
                Console.WriteLine("Tai khoan thu{0}:" , count);
                a.Output();
                count++;
            }
        }
        public void AddAccount(Account account)
        {
            this.account.Add(account);
            Console.WriteLine("Da them vao danh sach");
        }
        public Account SearchAccount(string account)
        {
            foreach(Account acc in this.account)
            {
                if (acc.accountNumber == account)
                    return acc;
            }
            return null;
        }
    }
}
