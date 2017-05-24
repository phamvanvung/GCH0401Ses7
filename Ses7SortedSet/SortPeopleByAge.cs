using System;
using System.Collections.Generic;

namespace Ses7SortedSet
{
    public class SortPeopleByAge : IComparer<Person>
    {
        public SortPeopleByAge()
        {
        }

        public int Compare(Person x, Person y)
        {
            if(x.Age < y.Age){
                return -1;
            }else if(x.Age == y.Age){
                return 0;
            }else{
                return 1;
            }
        }
    }
}
