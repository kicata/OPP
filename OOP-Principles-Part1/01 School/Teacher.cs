using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher:People,IComment
    {
        private string optionalComment;
        private List<Discipline> setOfDisciplines=new List<Discipline>();

        public List<Discipline> SetOfDisciplines
        {
            get { return this.setOfDisciplines; }
        }

        public Teacher(string name):base(name)
        {

        }
        public string Disciplines()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Discipline discipline in setOfDisciplines)
            {
                sb.Append(discipline.Name + ",\n Number of lectures: " + discipline.NumOfLectures
                    + ",\n Number of exercises " + discipline.NumOfExercises + Environment.NewLine);
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
