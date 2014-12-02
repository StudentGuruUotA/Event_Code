using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroExample
{
    class Rectangle : Shape
    {
        private String color;

        public Rectangle(int height,int width,String color) : base( height, width)
        {
            this.color = color;
        }
        public Rectangle(String color) :base()
        {
            this.color = color;
        }

        public String getColor()
        {
            return color;
        }


    }
}
