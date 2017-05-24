using System;
using System.Collections.Generic;

namespace Ses7Queue
{
    class MainClass
    {
        public static void GetCoffee(Person p){
            Console.WriteLine("{0} gets coffee", p.FirstName);
        }
        public static void Main(string[] args)
        {
            Queue<Person> queueOfPeople = new Queue<Person>();
            queueOfPeople.Enqueue(new Person("Homer", "Simpson", 47));
            queueOfPeople.Enqueue(new Person("Maggie", "Simpson", 45));
            queueOfPeople.Enqueue(new Person("Lisa", "Simpson", 9));
            //Peek() see which is the first (not removing the element)
            Console.WriteLine("{0} is first in line", queueOfPeople.Peek());
            //Dequeue() returns the first in line and remove it from the queue
            GetCoffee(queueOfPeople.Dequeue());
            GetCoffee(queueOfPeople.Dequeue());
            GetCoffee(queueOfPeople.Dequeue());
            //Try to dequeue when the queue is empty lead to exception
            try
            {
                //Queue is empty exception
                GetCoffee(queueOfPeople.Dequeue());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
