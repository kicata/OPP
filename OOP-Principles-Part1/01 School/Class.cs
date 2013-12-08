using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class:IComment
    {
        private string optionalComment;
        private string unicTxtInd;
        private List<Teacher> setOfTeachers=new List<Teacher>();
        private List<Student> setOfStudents=new List<Student>();
        

        public string UnicTxtInd
        {
            get { return unicTxtInd; }
            set { unicTxtInd = value; }
        }
        public List<Teacher> SetOfTeachers
        {
            get { return this.setOfTeachers; }
        }

        public List<Student> SetOfStudents
        {
            get { return this.setOfStudents; }
        }

        public Class()
        {
            this.UnicTxtInd = unicTxtInd;
        }

        public Class(string unicTxtInd)
        {
            this.UnicTxtInd = unicTxtInd;
        }
        //methods
        public string StudentToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var student in setOfStudents)
            {
                sb.Append( student.Name +" num in class - "+student.UnNumberInClass+Environment.NewLine);
            }
            return sb.ToString();
        }
        public string TeacherToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var teacher in setOfTeachers)
            {
                sb.Append("teacher " + teacher.Name +" teach those discipline: \n"+ teacher.Disciplines());
                sb.Append(Environment.NewLine);

            }
            return sb.ToString();
        }
        //methods from interface
        public void AddComment(string comment)
        {
            this.optionalComment = comment;
        }
        public string ShowComment()
        {
            return this.optionalComment;
        }

        


        
    }
}
