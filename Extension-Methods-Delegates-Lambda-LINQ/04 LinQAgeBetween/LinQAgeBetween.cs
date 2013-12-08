using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace LinQAgeBetween
{
    class LinQAgeBetween
    {

        static void Main()
        {
            List<Student> groupOFStudents = new List<Student>();
            groupOFStudents.Add(new Student("Pencho", "Manchov", 17));
            groupOFStudents.Add(new Student("Zybo", "Zybov", 25));
            groupOFStudents.Add(new Student("Anatolii", "Stancov", 19));
            groupOFStudents.Add(new Student("Minka", "ManDova", 23));
            groupOFStudents.Add(new Student("Pepa", "MaLinova", 18));
            groupOFStudents.Add(new Student("Pisna ", "Minainterfeisa", 24));
            groupOFStudents.Add(new Student("Tosho", "Banchov", 21));

            var studentsBtw18And24 = from student in groupOFStudents
                                     where student.Age >= 18 && student.Age <= 24
                                     orderby student.Age
                                     select student;

            Console.WriteLine("The List of students with age between 18-24:");

            foreach (var student in studentsBtw18And24)
            {
                Console.WriteLine("{0} {1} age- {2}",student.FirstName,student.LastName,student.Age);
            }

        }
    }
}
