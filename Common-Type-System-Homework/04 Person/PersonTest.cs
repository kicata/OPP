using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{ //Create a class Person with two fields – name and age. Age can be left unspecified 
    //(may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
    //Write a program to test this functionality.

    class PersonTest
    {
        static void Main()
        {

            Person pers1 = new Person("Pencho", 25);
            Person pers2 = new Person("Gancho", 28);
            Person pers3 = new Person("Mancho", 52);
            Person pers4 = new Person("Neli");
            List<Person> persons = new List<Person>();
            persons.Add(pers1);
            persons.Add(pers2);
            persons.Add(pers3);
            persons.Add(pers4);
            foreach (var item in persons)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
