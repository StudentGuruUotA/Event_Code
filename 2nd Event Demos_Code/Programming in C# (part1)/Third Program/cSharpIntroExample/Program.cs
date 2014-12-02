using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle skalino = new Triangle(3, 12,"Ένα τρίγωνο");
            skalino.printInformation();
            Triangle pascal = new Triangle( "pascal's triangle");// kamia sxesi me to trigwno tou pascal 
            pascal.printInformation();
            Console.ReadLine();

            // 


        }
    }
}
