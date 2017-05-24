using System;
using System.Collections;
using System.Collections.Generic;

namespace Ses7SortedSet
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SortPeopleByAge comparer = new SortPeopleByAge();
            SortedSet<Person> setOfPeople = new SortedSet<Person>(comparer) { 
                new Person{FirstName="Hommer", LastName="Simpson", Age=47},
                new Person{FirstName="Maggie", LastName="Simpson", Age=45},
                new Person{FirstName="Lisa", LastName="Simpson", Age=9},
                new Person{FirstName="Mart", LastName="Simpson", Age=8}
            };
            //Loop through them
            foreach (var item in setOfPeople)
            {
                Console.WriteLine(item);
            }
            //Add two more
            setOfPeople.Add(new Person("Soka", "Jones", 1));
            setOfPeople.Add(new Person("Mikko", "Jones", 12));
            foreach (var item in setOfPeople)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
