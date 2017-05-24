using System;
using System.Collections.Generic;

namespace Ses7Dictionary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Hommer", new Person("Hommer", "Simpson", 47));
            peopleA.Add("Maggie", new Person("Maggie", "Simpson", 45));
            Console.WriteLine(peopleA["Hommer"]);
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>(){
                {"Hommer", new Person{FirstName="Hommer", LastName= "Simpson", Age=47}},
                {"Maggie", new Person{FirstName="Maggie", LastName= "Simpson", Age=45}}
            };
            Console.WriteLine(peopleB["Maggie"]);
        }
    }
}
