using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCS
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.CarSpeedLimitReached
                += Car_CarSpeedLimitReached;
            for (int i = 0; i < 13; i++)
            {
                car.Accelerate();
                Console.WriteLine(car.Speed);
            }

            Console.ReadLine();
        }

        private static void
            Car_CarSpeedLimitReached(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Delegates()
        {
            MyDelegate mydel =
                new MyDelegate(Sum);
            int z = mydel(1, 2);
            Console.WriteLine(z);
            mydel += Subtract;
            z = mydel(3, 4);
            Console.WriteLine(z);
        }

        delegate int MyDelegate(int x, int y);

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }


        static void LINQ()
        {
            List<Person> persons = Person.GetPersons();
            //IEnumerable<Person> personsAgeUnder25 =
            //    from x in persons
            //    where x.Age < 25
            //    select x;
            IEnumerable<Person> personsAgeUnder25 =
                persons.Where(x => x.Age < 25);
            foreach (Person item in personsAgeUnder25)
            {
                Console.WriteLine(item.Name);
            }

        }


        static void Nullable()
        {
            //Nullable<int> age
            int? age;
            age = 45;
            if (age.HasValue) //age !=null
                Console.WriteLine(age);
            else
                Console.WriteLine("null value");
        }
    }
}
