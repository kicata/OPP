using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListT
{
    class TestGenericListClass
    {
        static void Main()
        {
            GenericList<int> testList = new GenericList<int>(5);
            testList.Add(5);
            testList.Add(45);
            testList.Add(18);
            testList.Add(66);
            testList.Add(22);
            testList.Add(6);
            testList.Add(2);
            testList.Add(9);
            testList.Add(10);

            Console.WriteLine("tstList.Count ->{0}",testList.Count);
            Console.WriteLine(testList.ToString());

            testList.RemoveAt(3);
            Console.WriteLine("After removing an element:");
            Console.WriteLine("tstList.Count ->{0}", testList.Count);
            Console.WriteLine(testList.ToString());

            testList.InsertAt(3, 66);
            Console.WriteLine("After inserting an element:");
            Console.WriteLine("tstList.Count ->{0}", testList.Count);
            Console.WriteLine(testList.ToString());
            Console.WriteLine();
            Console.WriteLine("searching for element:");
            int position=testList.FindByValue(66);
            Console.WriteLine("The element is on position {0}", position);
            position = testList.Min();
            Console.WriteLine("The Min Element in list is {0}",position);
            position = testList.Max();
            Console.WriteLine("The Max Element in list is {0}",position);

        }
    }
}
