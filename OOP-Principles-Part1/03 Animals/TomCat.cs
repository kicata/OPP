using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class TomCat : Cat,ISound
    {
        public TomCat(string name, int age, SexEnum sex)
            : base(name, age, sex)
        {
            if (sex != SexEnum.Male)
            {
                throw new ArgumentException("Tom must be female");
            }
        }
        public void SayHello()
        {
            Console.WriteLine("TomCat {0} say WTF!!!", this.Name);
        }
    }
}
