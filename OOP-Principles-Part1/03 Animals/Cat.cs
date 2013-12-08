﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat:Animal,ISound
    {
        public Cat(string name, int age, SexEnum sex):base(name,age,sex)
        {
            
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Cat {0} say MAYYY", this.Name);
        }
    }
}
