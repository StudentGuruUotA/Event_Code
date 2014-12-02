using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProgram
{
    internal class Person
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public Person(String name, String surname, int age, float height, float weight)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }
        public String toString()
        {
            return "Όνομα : " + Name + "\nΕπίθετο : " + Surname + "\nΗλικία : " + Age + "\nΎψος : " + Height +
                   "\nΒάρος : " + Weight + "\n";
        }
    }
}