using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondProgram
{
    class Calculation
    {
        public static Person getMax(List<Person> list, String attribute)
        {
            Person person;
            if (attribute.Equals("age"))
            {
                person = list.OrderBy(x => x.Age).LastOrDefault();

            }
            else if (attribute.Equals("height"))
            {
                person = list.OrderBy(x => x.Height).LastOrDefault();
            }
            else
            {
                person = list.OrderBy(x => x.Weight).LastOrDefault();
            }
            return person;
        }
        public static Person getMin(List<Person> list, String attribute)
        {
            Person person;
            if (attribute.Equals("age"))
            {
                person = list.OrderBy(x => x.Age).FirstOrDefault();
            }
            else if (attribute.Equals("height"))
            {
                person = list.OrderBy(x => x.Height).FirstOrDefault();
            }
            else
            {
                person = list.OrderBy(x => x.Weight).FirstOrDefault();
            }
            return person;
        }
        
    }
}
