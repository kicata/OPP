using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQAgeBetween
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student()
        {
        }
        public Student(string name, string lastName, int age)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Age = age;
        }

    }
}
