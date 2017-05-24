using System;
using System.Collections.Generic;

namespace Ses7List
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declare and initialize
            List<Person> people = new List<Person>(){
                new Person{FirstName="Homer", LastName = "Simpson", Age=47},
                new Person{FirstName="Merge", LastName = "Simpson", Age=45},
                new Person{FirstName="Lisa", LastName = "Simpson", Age=9},
                new Person{FirstName="Bart", LastName = "Simpson", Age=8}
            };
            Console.WriteLine("Items in the list {0}", people.Count);
            //loop through it
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
            //Add another person
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            //Display size again
            Console.WriteLine("Items in the list {0}", people.Count);
            //convert to array
            Person[] arrayOfPeople = people.ToArray();
            //Loop through it
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine("First name: {0}", arrayOfPeople[i].FirstName);
            }
            Console.Read();
        }
    }
}
