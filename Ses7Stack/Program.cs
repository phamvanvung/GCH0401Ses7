using System;
using System.Collections.Generic;

namespace Ses7Stack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person("Homer", "Simpson", 47));
            stackOfPeople.Push(new Person("Maggie", "Simpson", 45));
            stackOfPeople.Push(new Person("Lisa", "Simpson", 9));
            //Peek see what is on top, but do not remove
            Console.WriteLine("First one {0}", stackOfPeople.Peek().ToString());
            //Pop take (and remove) the first one from the stack
            Console.WriteLine("First one {0}", stackOfPeople.Pop().ToString());
            //Keep doing these
            Console.WriteLine("First one {0}", stackOfPeople.Peek().ToString());
            Console.WriteLine("First one {0}", stackOfPeople.Pop().ToString());
            Console.WriteLine("First one {0}", stackOfPeople.Peek().ToString());
            Console.WriteLine("First one {0}", stackOfPeople.Pop().ToString());
            //Try there is no element 
            try
            {
				Console.WriteLine("First one {0}", stackOfPeople.Peek());
				Console.WriteLine("First one {0}", stackOfPeople.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
