using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//01. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address,
//mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. 
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//02. Add implementations of the ICloneable interface. The Clone() method should deeply
//copy all object's fields into a new object of type Student.
//03. Implement the  IComparable<Student> interface to compare students by names
//(as first criteria, in lexicographic order) and by social security number 
//(as second criteria, in increasing order).


namespace Student
{
    class StudentTest
    {
        static void Main()
        {
            //01
            Student st1 = new Student("Ivan", "Petkov", "Ivanov", "0123456789");
            Student st2 = new Student("Petkan", "Petkov", "Slivanov", "9874561230");
            Student st3 = new Student("Mariq", "Marova", "Mareva", "1230456789");
            Student st4 = new Student("Mariq", "Marova", "Mareva", "0230456789");
            Console.WriteLine("This is 01 exercise:");
            Console.WriteLine(st1.ToString());
            Console.WriteLine(st2.ToString());
            Console.WriteLine("Are those two Equal ?");
            Console.WriteLine(Equals(st1,st2));
            Console.WriteLine();
            //02
            Console.WriteLine("This is 02 exercise:");
            Student cloneSt1 = st1.Clone();
            Console.WriteLine("This is the clone of st1 Say Hi :");
            Console.WriteLine(cloneSt1.ToString());
            Console.Write("Are they really identical ? --> {0}",Equals(st1,cloneSt1));
            cloneSt1.FirstName = "Pencho";
            Console.WriteLine();
            Console.WriteLine("After change first name ? -> {0}",Equals(st1,cloneSt1));
            Console.WriteLine();
            //03
            Console.WriteLine("This is 03 exercise:");
            List<Student> studentList = new List<Student>();
            studentList.Add(st1);
            studentList.Add(st2);
            studentList.Add(st3);
            studentList.Add(st4);
            Console.WriteLine("Before Sorting");
            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }
            studentList.Sort();
            Console.WriteLine("And this is after ");
            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }
            //
        }
    }
}
