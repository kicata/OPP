
//Define a class BitArray64 to hold 64 bit values inside an ulong value. 
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class BitArray64 : IEnumerable<int>
    {
        //Field
        private ulong number;
        //Property
        public ulong Number
        {
            get { return number; }
            set { number = value; }
        }
        //Constructor
        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        //Methods and implementation
        //foreach
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Call the generic version of the method
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this[i];
            }
        }
        //indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }

                return (int)((this.number >> index) & 1);
            }
        }
        //Equals
        public override bool Equals(object obj)
        {
            BitArray64 bitArray = obj as BitArray64;
            if ((object)bitArray == null)
            {
                return false;
            }
            if (!Object.Equals(this.number, bitArray.number))
            {
                return false;
            }
            return true;
        }
        //=_!=
        public static bool operator ==(BitArray64 a, BitArray64 b)
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
            return a.Number == b.Number;
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !(a == b);
        }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder(64);
            for (int i = 63; i >= 0; i--)
            {
                sb.Append(this[i]);
            }
            return sb.ToString();
        }
    }
}
