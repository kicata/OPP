using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog:Animal,ISound
    {
        public Dog(string name, int age, SexEnum sex):base(name,age,sex)
        {
            
        }
        public void SayHello()
        {
            Console.WriteLine("Dog {0} say BaYYY",this.Name);
        }
    }
}
