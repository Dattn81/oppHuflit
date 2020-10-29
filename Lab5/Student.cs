using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Student:Person
    {
        public string studentCode { get; set; }
        
        public Student()
        {

        }
        public Student(string studentCode,string name,string email) : base(name,email)
        {
            this.studentCode = studentCode;
        }
    }
}
