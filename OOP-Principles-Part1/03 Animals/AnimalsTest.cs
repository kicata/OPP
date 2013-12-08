using System;
using System.Collections.Generic;
using System.Linq;

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only 
//female and tomcats can be only male. Each animal produces a specific sound. 
//Create arrays of different kinds of animals and calculate the average age of each kind of animal 
//using a static method (you may use LINQ).

namespace Animals
{
    class AnimaTest
    {
        static void Main()
        {
            List<ISound> animalList = new List<ISound>();
            animalList.Add( new Dog("Karaman", 2, SexEnum.Male));
            animalList.Add(new Dog("Sharo", 4, SexEnum.Male));
            animalList.Add(new Dog("Jina", 6, SexEnum.Female));
            animalList.Add(new Frog("Quak", 1, SexEnum.Male));
            animalList.Add(new Frog("Quackka", 2, SexEnum.Female));
            animalList.Add(new Kitten("Rumana", 3, SexEnum.Female));
            animalList.Add(new Kitten("Jipsi", 1, SexEnum.Female));
            animalList.Add(new TomCat("Garfild", 7, SexEnum.Male));
            animalList.Add(new TomCat("Belcho", 8, SexEnum.Male));

            //Make sound
            foreach (var animal in animalList)
            {
                animal.SayHello(); 
            }

            //Average Age of different animals
            List<Animal> animalTypeList = new List<Animal>();
            animalTypeList.Add(new Dog("Karaman", 2, SexEnum.Male));
            animalTypeList.Add(new Dog("Sharo", 4, SexEnum.Male));
            animalTypeList.Add(new Dog("Jina", 6, SexEnum.Female));
            animalTypeList.Add(new Frog("Quak", 1, SexEnum.Male));
            animalTypeList.Add(new Frog("Quackka", 2, SexEnum.Female));
            animalTypeList.Add(new Kitten("Rumana", 3, SexEnum.Female));
            animalTypeList.Add(new Kitten("Jipsi", 1, SexEnum.Female));
            animalTypeList.Add(new TomCat("Garfild", 7, SexEnum.Male));
            animalTypeList.Add(new TomCat("Belcho", 8, SexEnum.Male));

            Console.WriteLine("Average Dog age: ");
            var averageDogAge =
                (from animal in animalTypeList
                 where animal.GetType() == typeof(Dog)
                 select animal.Age).Average();

            Console.WriteLine(averageDogAge);

            Console.WriteLine("Average Frog age: ");
            var averageFrogAge =
                (from animal in animalTypeList
                 where animal.GetType() == typeof(Frog)
                 select animal.Age).Average();

            Console.WriteLine(averageFrogAge);

            Console.WriteLine("Average Cat-Kitten age: ");
            var averageCatAge =
                (from animal in animalTypeList
                 where animal.GetType() == typeof(Kitten)
                 select animal.Age).Average();

            Console.WriteLine(averageCatAge);
            Console.WriteLine("Average Cat-TomCat age: ");
            var averageCatTomCatAge =
                (from animal in animalTypeList
                 where animal.GetType() == typeof(TomCat)
                 select animal.Age).Average();

            Console.WriteLine(averageCatTomCatAge);

        }
    }
}
