using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public abstract class People
    {
       private string name;
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
             
        public People(string name)
        {
            
            this.name = name;
        }
    }
}
