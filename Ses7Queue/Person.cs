using System;
namespace Ses7Queue
{
    public class Person
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public int Age{get;set;}
        public Person()
        {
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}, {2}", FirstName, LastName, Age);
        }
    }
}
