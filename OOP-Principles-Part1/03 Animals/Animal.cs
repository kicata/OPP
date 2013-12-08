using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public enum SexEnum
    {
        Male, Female
    }
    public abstract class Animal
    {

        private int age;
        private string name;
        private SexEnum sex;

        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
        }
        public SexEnum Sex
        {
            get { return this.sex; }
            private set { this.sex = value; }
        }

        public int Age
        {
            get
            {
                return age;
            }
            protected set
            {
                if (age<=0)
                {
                    throw new ArgumentException("Age must be > 0 ");
                }
                age = value;
            }
        }
        public Animal(string name, int age, SexEnum sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;

        }
        public static decimal GetAverageAge(IEnumerable<Animal> source)
        {
            decimal sum = 0;
            long count = 0L;
            foreach (Animal animal in source)
            {
                sum += animal.Age;
                count++;
            }
            return sum / count;
        }
    }
}
