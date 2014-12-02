using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroExample
{
    class Triangle : Shape , AreaInterface
    {
        private String description;

        public Triangle(int width, int height,String description) : base (width,height)
        {
            this.description = description;
        }

        public Triangle(String description)  : base()
        {
            this.description = description;
        }

        public void setDescription(String newDescription){
            this.description = newDescription;
        }

        public String getDescription()
        {
            return description;
        }

        public int calculateArea()
        {
            return (height * width) / 2;
            
        }

        public void printInformation() 
        {
            Console.WriteLine();
            Console.WriteLine("Το ύψος είναι: " + height);
            Console.WriteLine("Το πλάτος είναι: " + width);
            Console.WriteLine("Περιγραφή: " + description);
            Console.WriteLine("Το εμβαδό είναι: " + calculateArea());
           
        }
    }
}
