using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        //Fields
        private string name;
        private byte age;
        //Properties
        public byte Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //Construstor
        public Person(string name, byte? age)
        {
            this.Name = name;

            if (age.HasValue)
            {
                this.Age = age.Value;
            }
        }
        public Person(string name)
            : this(name, null)
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + this.Name);
            sb.Append("\t");
            if (age == null || age == 0)
            {
                sb.Append("Age: Not Specified");
            }
            else
            {
                sb.Append("Age: " + this.Age + " years");
            }

            return sb.ToString();
        }

    }
}
