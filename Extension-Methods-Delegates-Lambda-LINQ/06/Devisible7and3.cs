using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _06
{
    class Devisible7and3
    {
        static void Main()
        {
            int[] array = {21,3,7,89,123,441,789,147};

            //extension and lambda
            AllDevisableTo3And7(array);
            Console.WriteLine();

            //LINQ
            Console.WriteLine("This is the same result using Linq :");
            var allDevisable=from number in array
                             where number%3==0 && number%7==0
                             select number;

            foreach (var number in allDevisable)
            {
                Console.Write(number + " ");
            }
            
        }
        public static void AllDevisableTo3And7(int[] array)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);

            }
            List<int> allDevisable = list.FindAll(x => (x % 3) == 0 && (x % 7) == 0);
            Console.WriteLine("the numbers devisable to 3 and 7 at the same time are:");
            foreach (var number in allDevisable)
            {
                Console.Write(number +" ");
            }
           
        }
    }
}
