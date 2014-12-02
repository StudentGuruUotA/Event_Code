using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCS
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static List<Person> GetPersons()
        {
            return new List<Person>()
           {
              new Person()
            { Age = 30, Name = "Dimitris" },
              new Person()
            { Age = 21, Name = "Giannis" },
             new Person()
            { Age = 43, Name = "Kostas" },
             new Person()
            { Age = 12, Name = "Takis" }
           };
        }

    }
}
