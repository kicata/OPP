using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. 
//Use LINQ query operators.

namespace FirstBeforeLastName
{
    class FirstBeforeLastName
    {
        public static void FirstBeforeLast(Student[] arr)
        {
            var firstBeforLast = from student in arr
                                 where student.FirstName.CompareTo(student.LastName) == -1
                                 orderby student.FirstName 
                                 select student;
            foreach (var student in firstBeforLast)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

        }
        static void Main()
        {
            Student[] group ={new Student("Pencho","Traikov"),
                             new Student("Mancho","Aikov"),
                             new Student("Adam","Zlatkov"),
                             new Student("Ibro","Elolov")
                            };
            //foreach (var student in group)
            //{
            //    Console.WriteLine("Name: {0} \nLast Name: {1}",student.FirstName,student.LastName);
            //}
            FirstBeforeLastName.FirstBeforeLast(group);
        }
    }
}
