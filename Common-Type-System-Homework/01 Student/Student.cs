using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address,
//mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. 
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

namespace Student
{
    public enum University
    {
        TechnicalUniversity, EconomicUniversity, BaseUniversity, Unspecified
    }
    public enum Faculty
    {
        Technical, Historical, IT, Geography, Unspecified
    }
    public enum Speciality
    {
        History, IT, Science, Economic, Geology, Law, Unspecified
    }

    public class Student : ICloneable, IComparable<Student>
    {
        //Fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssN;
        private string permAdress;
        private string mobPhone;
        private string email;

        private University university;
        private Faculty faculty;
        private Speciality speciality;
        private byte course;

        //Properties
        public byte Course
        {
            get { return course; }
            set { course = value; }
        }
        public Speciality Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }

        public University University
        {
            get { return university; }
            set { university = value; }
        }

        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string MobPhone
        {
            get { return mobPhone; }
            set { mobPhone = value; }
        }

        public string PermAdress
        {
            get { return permAdress; }
            set { permAdress = value; }
        }

        public string SSN
        {
            get { return ssN; }
            set { ssN = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        //Constructors
        public Student(string firstName, string middleName, string lastName, string ssN, string permAdress, string mobPhone, string email,
                    University university, Faculty faculty, Speciality speciality, byte course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssN;
            this.PermAdress = permAdress;
            this.MobPhone = mobPhone;
            this.Email = email;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
            this.Course = course;

        }
        public Student(string firstName, string middleName, string lastName, string ssN)
            : this(firstName, middleName, lastName, ssN, null, null, null, University.Unspecified, Faculty.Unspecified, Speciality.Unspecified, 0)
        {

        }
        //methods
        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }
            // If parameter cannot be cast to Student return false.
            Student student = obj as Student;
            if ((System.Object)student == null)
            {
                return false;
            }
            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            // Return true if the fields match:
            return true;
        }
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("********************\n");
            sb.Append("First Name: " + this.FirstName);
            sb.Append(Environment.NewLine);
            sb.Append("Middle Name: " + this.MiddleName);
            sb.Append(Environment.NewLine);
            sb.Append("Last Name: " + this.LastName);
            sb.Append(Environment.NewLine);
            sb.Append("SSN: " + this.SSN);
            sb.Append(Environment.NewLine);
            sb.Append("********************\n");
 	         return sb.ToString();
        }
        public static bool operator ==(Student a, Student b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.SSN == b.SSN && a.FirstName==b.FirstName && a.LastName == b.LastName;
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }
        //implementing ICloneble
        object ICloneable.Clone() // Implicit interface implementation
        {
            return this.Clone();
        }
   
        public Student Clone() // Deep cloning (public method)
        {
            Student original = this;
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermAdress,
                this.MobPhone, this.Email,this.University,this.Faculty,this.Speciality,this.Course);
            return result;
        }
        public Student ShallowCopy()
        {
            return this;
        }
        public Student MemberwiseCopy()
        {
            return (Student)this.MemberwiseClone();
        }
        //implementing IComparable<Student>

        public int CompareTo(Student otherStudent)
        {
            // If other is not a valid object reference, this instance is greater. 
         int result;
         

          if (otherStudent == null)
          {
               throw new ArgumentException("This object is not a Student.");
          }
          else
          {
              string studentFullName = this.FirstName + this.MiddleName + this.LastName;
              string otherStudentFullName = otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName;
              result = studentFullName.CompareTo(otherStudentFullName);
              if (result==0)
              {
                 result = this.SSN.CompareTo(otherStudent.SSN); 
              }
              return result;
          }

        }
    }   
}
