using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog:Animal,ISound
    {
        public Frog(string name, int age, SexEnum sex):base(name,age,sex)
        {
           
        }
        public void SayHello()
        {
            Console.WriteLine("Frog {0} say QUACK", this.Name);
        }
    }
}
