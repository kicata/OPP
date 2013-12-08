using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Discipline:IComment
    {
        private string name;
        private int numOfLectures;
        private int numOfExercises;
        private string optionalComment;

        public int NumOfExercises
        {
            get { return numOfExercises; }
            set 
            {
                numOfExercises = value;
                if (numOfExercises<0)
                {
                    throw new ArgumentException("Number of exercises must be positive");
                }
                 
            }
        }
        
        public int NumOfLectures
        {
            get { return numOfLectures; }
            set 
            {
                numOfLectures = value; 
                if (numOfLectures<=0)
                {
                    throw new ArgumentException("Number of lectures must be positive");
                }
                 
            }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Discipline(string name, int numOfLectures, int numOfExercises )
        {
            this.Name=name;
            this.NumOfLectures = numOfLectures;
            this.NumOfExercises = numOfExercises;
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
