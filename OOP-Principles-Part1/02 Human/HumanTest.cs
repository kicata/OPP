using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
//Define abstract class Human with first name and last name. Define new class Student which is derived from Human
//and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay
//and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties
//for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy()
//extension method). Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace Human
{
    class HumanTest
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            List<Student> studentList = new List<Student>(){new Student("Ivan", "Petkov", 5.60),
                                                          new Student("Petkan", "Lolov", 5.20),
                                                          new Student("Metkan", "Rolov", 5.30),
                                                          new Student("Ketkan", "Tolov", 4.20),
                                                          new Student("Wetkan", "Solov", 5.78),
                                                          new Student("Letkan", "Kolov", 3.20),
                                                          new Student("Betkan", "Molov", 5.20),
                                                          new Student("Getkan", "Eolov", 4.25),
                                                          new Student("Zetkan", "Relov", 6.00),
                                                          new Student("Detkan", "Golov", 5.00),
                                                          };    
                                                          
            List<Worker> workerList = new List<Worker>(){   new Worker("Zmuca", "Areseshova", 48.00, 8, 5),
                                                            new Worker("Gmuca", "Peshova", 48.00, 8, 5),
                                                            new Worker("Pruca", "Peshova", 125.00, 8, 5),
                                                            new Worker("Muca", "Peshova", 150.00, 8, 5),
                                                            new Worker("Kuca", "Peshova", 68.00, 8, 5),
                                                            new Worker("Parcuca", "Peshova", 789.00, 8, 5),
                                                            new Worker("Maq", "Peshova", 753.00, 8, 5),
                                                            new Worker("Maria", "Peshova", 100.00, 8, 5),
                                                            new Worker("Minka", "Peshova", 200.00, 8, 5),
                                                            new Worker("Stinka", "Peshova", 250.00, 8, 5),
                                                            new Worker("Gena", "Trikova", 48.00, 8, 5),
                                                            new Worker("Zmuca", "Peshova", 48.00, 8, 5)
                                                        };
            //students by grade        
            foreach (var item in studentList.OrderBy(s => s.Grade))
            {
                //Console.WriteLine(item.FirstName + " " + item.LastName + " grade: " + item.Grade);
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            //workers by moneyPerHour
            foreach (var item in workerList.OrderBy(w => w.MoneyPerHour(w.WeekSalary,w.WorkHoursPerDay, w.WorkDaysPerWeek)))
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " moneyPerHour: {0:N} lv/hour", item.MoneyPerHour(item.WeekSalary, item.WorkHoursPerDay, item.WorkDaysPerWeek));
            }
            Console.WriteLine();
            //merge two list
            List<Human> humanList = workerList.Concat<Human>(studentList).ToList<Human>();
            foreach (var human in humanList.OrderBy(h => h.FirstName).ThenBy(h => h.LastName))
            {
                Console.WriteLine(human.FirstName + " " + human.LastName );
            }
        }

    }
}
