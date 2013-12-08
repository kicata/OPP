using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat,ISound
    {

        public Kitten(string name, int age, SexEnum sex)
            : base(name, age, sex)
        {
            if (sex != SexEnum.Female)
            {
                throw new ArgumentException("Kittens must be female");
            }
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Kitten {0} say Purrrr", this.Name);
        }
    }
}
