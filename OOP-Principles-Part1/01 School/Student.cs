using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School

{
    public class Student:People
    {
       
        private int unNumberInClass;

        public int UnNumberInClass
        {
            get { return unNumberInClass; }
            set { unNumberInClass = value; }
        }

        public Student(string name, int unNumberInClass):base(name)
        {
           
            this.UnNumberInClass = unNumberInClass;
        }
    }
}
