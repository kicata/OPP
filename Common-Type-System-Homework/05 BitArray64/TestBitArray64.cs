using System;
using System.Collections.Generic;
using System.Linq;
//Define a class BitArray64 to hold 64 bit values inside an ulong value. 
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.


namespace BitArray64
{
    class TestBitArray64
    {
        static void Main()
        {//Print some number in binary representation just to compare with it
            int num = 9578;
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(64, '0'));
            //Making the BitArray64 with the same number but from ulong type
            ulong number = 9587;
            BitArray64 bits = new BitArray64(number);
            //Test foreach
            foreach (var bit in bits)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            //Making new BitArray64 and compare it with the old one
            BitArray64 bits2 = new BitArray64((ulong)8766);
            Console.WriteLine(bits.Equals(bits2));
            Console.WriteLine(bits == bits2);
            Console.WriteLine(bits != bits2);
            Console.WriteLine("-----------------------------------------------------------------");
            //Test ToString() method
            Console.WriteLine(bits);
            //Test overriten operator[]
            Console.WriteLine(bits[0]);

        }
    }
}
