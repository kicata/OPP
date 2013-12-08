using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLastName
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student()
        { 
        }
        public Student(string name, string lastName)
        {
            this.FirstName = name;
            this.LastName = lastName;
        }

    }
}
