using System;
using System.Linq;

namespace ExeptionClass
{
     public class InvalidRangeException<T>:ApplicationException
    {
         //fields
        private T start;
        private T end;      
         //properties
        public T Start
        {
            get { return start; }
            set { start = value; }
        }
        public T End
        {
            get { return end; }
            set { end = value; }
        }
        
        //constructor
         public InvalidRangeException(string msg,T start,T end):base(msg)
         {
             this.Start = start;
             this.End = end;
         }

         public InvalidRangeException(string msg, Exception innerEx, T start, T end)
             : base(msg, innerEx)
         {
             this.Start = start;
             this.End = end;
         }

    }
}
