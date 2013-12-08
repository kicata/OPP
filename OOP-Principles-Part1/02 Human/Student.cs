using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Student:Human
    {
        private double grade;
        private List<Student> studentList = new List<Student>();

        public List<Student> StudentList
        {
            get { return this.studentList; }
        }
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        

        public Student( string firstName, string lastName, double grade):base(firstName,lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Grade = grade;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var student in studentList)
            {
                sb.Append(student.FirstName + " " + student.LastName + " grade: " + student.Grade + Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
