using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number. 
//Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises.
//Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
//encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.


namespace School
{
    class School
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", 15);
            Student student2 = new Student("Petkan", 17);
            Student student3 = new Student("Dragan", 19);

            Class osmiB = new Class("osmi B");
            osmiB.SetOfStudents.Add(student1);
            osmiB.SetOfStudents.Add(student2);
            osmiB.SetOfStudents.Add(student3);

            Teacher teacher1 = new Teacher("Anatoli");
            Teacher teacher2 = new Teacher("Cvetkan");

            osmiB.SetOfTeachers.Add(teacher1);
            osmiB.SetOfTeachers.Add(teacher2);

            Discipline math = new Discipline("Math", 5, 4);
            Discipline history = new Discipline("History", 9, 8);
            Discipline geography = new Discipline("Geography", 4, 9);
            Discipline science = new Discipline("Science", 5, 4);

            teacher1.SetOfDisciplines.Add(math);
            teacher1.SetOfDisciplines.Add(history);

            teacher2.SetOfDisciplines.Add(geography);
            teacher2.SetOfDisciplines.Add(science);

            
            Console.WriteLine("The class {0} has those students : \n",osmiB.UnicTxtInd);
            Console.WriteLine(osmiB.StudentToString());
            Console.WriteLine("Some teachers:");
            Console.WriteLine(osmiB.TeacherToString());

            teacher1.AddComment("This is some optional comment");
            string comment=teacher1.ShowComment();
            Console.WriteLine(comment);

        }
    }
}
