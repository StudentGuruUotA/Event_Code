using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace SecondProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, age;
            float height, weight;
            String name, surname;
            List<Person> list = new List<Person>();
            Console.Write("Δώσε τον αριθμό των ατόμων προς εισαγωγή : ");
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("\nΣτοιχεία " + (i+1) + " ατόμου ");
                Console.Write("Δώσε όνομα : ");
                name = Console.ReadLine();
                Console.Write("Δώσε επώνυμο : ");
                surname = Console.ReadLine();
                Console.Write("Δώσε ηλικία : ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Δώσε ύψος : ");
                height = float.Parse(Console.ReadLine());
                Console.Write("Δώσε βάρος : ");
                weight = float.Parse(Console.ReadLine());
                list.Add(new Person(name, surname, age, height, weight));
            }
            Console.WriteLine();
            Console.WriteLine("Το άτομο με τη μεγαλύτερη ηλικία είναι\n" +(Calculation.getMax(list, "age").toString()));
            Console.WriteLine("Το άτομο με τη μικρότερη ηλικία είναι\n" + Calculation.getMin(list, "age").toString());
            Console.WriteLine("Το άτομο με τη μεγαλύτερo ύψος είναι\n" + Calculation.getMax(list, "height").toString());
            Console.WriteLine("Το άτομο με τη μικρότερο βάρος είναι\n" + Calculation.getMin(list, "weight").toString());
            Console.ReadLine();

            
            
        }
    }
}
