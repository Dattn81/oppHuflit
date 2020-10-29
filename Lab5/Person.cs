using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Person
    {
        public string name { get; set; }
        public string email { get; set; }
        public Person()
        {
            this.name = "No Name";
            this.email = "No Email";
        }
        public Person(string name ,string email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
