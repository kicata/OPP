using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
//by first name and last name in descending order. Rewrite the same with LINQ.

namespace SortStudentsWithLambdaAndLINQ
{
    class Program
    {
        static void Main()
        {
            //with LINQ
            List<Student> groupOFStudents = new List<Student>();
            groupOFStudents.Add(new Student("Pencho", "Manchov", 17));
            groupOFStudents.Add(new Student("Zybo", "Zybov", 25));
            groupOFStudents.Add(new Student("Anatolii", "Stancov", 19));
            groupOFStudents.Add(new Student("Minka", "ManDova", 23));
            groupOFStudents.Add(new Student("Pepa", "MaLinova", 18));
            groupOFStudents.Add(new Student("Pisna ", "Minainterfeisa", 24));
            groupOFStudents.Add(new Student("Tosho", "Banchov", 21));

            //LINQ Descending
            var studentsDesscORD = from student in groupOFStudents
                                     orderby student.FirstName descending
                                     select student;

            Console.WriteLine("The List of students sorted with LINQ descending first name:");
            Console.WriteLine();

            foreach (var student in studentsDesscORD)
            {
                Console.WriteLine("{0} {1} age- {2}", student.FirstName, student.LastName, student.Age);
            }
            Console.WriteLine();
            //LINQ Assending
            var studentsAsORD = from student in groupOFStudents
                           orderby student.FirstName 
                           select student;

            Console.WriteLine("The List of students sorted with LINQ Assending first name:");
            Console.WriteLine();

            foreach (var student in studentsAsORD)
            {
                Console.WriteLine("{0} {1} age- {2}", student.FirstName, student.LastName, student.Age);
            }
            Console.WriteLine();
            //Lambda
            Console.WriteLine("The List of students sorted with Lambda in Assending first name:");
            Console.WriteLine();
            var newStudentList = groupOFStudents.OrderBy(x =>x.FirstName).ThenByDescending(x=>x.LastName);
            foreach (var student in newStudentList)
            {
                Console.WriteLine("{0} {1} age- {2}",student.FirstName, student.LastName, student.Age);
            }

            Console.WriteLine();
            Console.WriteLine("The List of students sorted with Lambda in Ascending Last name:");
            Console.WriteLine();
            var newStudentListDesc = groupOFStudents.OrderBy(x => x.LastName);
            foreach (var student in newStudentListDesc)
            {
                Console.WriteLine("{0} {1} age- {2}", student.FirstName, student.LastName, student.Age);
            }


        }
    }
}
