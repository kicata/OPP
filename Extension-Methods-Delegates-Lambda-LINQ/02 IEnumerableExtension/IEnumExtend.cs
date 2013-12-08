using System;
using System.Collections.Generic;
using System.Linq;
//Implement a set of extension methods for IEnumerable<T> that implement the following group
//functions: sum, product, min, max, average.


namespace IEnumerableExtension
{
   public static class IEnumExtend
    {
       public static T Sum<T>(this IEnumerable<T> inputCollection)where T:IComparable
       {
           dynamic sum = 0;
           foreach (var item in inputCollection)
           {
               sum += item; 
           }
           return sum;

       }
       public static T Product<T>(this IEnumerable<T> inputCollection)where T:IComparable
       {
           dynamic product = 1;
           foreach (var item in inputCollection)
           {
               product *= item;
           }
           return product;

       }
       public static T Min<T>(this IEnumerable<T> inputCollection) where T : IComparable
       {
           dynamic min = int.MaxValue;
           foreach (var item in inputCollection)
           {
               if (item<min)
               {
                   min = item;
               }
           }
           return min;
       }
       public static T Max<T>(this IEnumerable<T> inputCollection) where T:IComparable
       {
           dynamic max = int.MinValue;
           foreach (var item in inputCollection)
           {
               if (item > max)
               {
                   max = item;
               }
           }
           return max;
       }
       public static T Average<T>(this IEnumerable<T> inputCollection)where T:IComparable
       {
           dynamic sum = 0;
           dynamic countItems = 0;
           foreach (var item in inputCollection)
           {
               sum += item;
               countItems++;

           }
           return sum / countItems;

       }

       
    }
}
