using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtension
{
   public class testExtendIEnum
    {
       public  static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Max: {0}", array.Max<int>());
            Console.WriteLine("Min: {0}", array.Min<int>());
            Console.WriteLine("Sum: {0}", array.Sum<int>());
            Console.WriteLine("Product: {0}", array.Product<int>());
            Console.WriteLine("Average: {0}", array.Average<int>());
        }
    }
}
