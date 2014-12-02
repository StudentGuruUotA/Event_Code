using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroExample
{
    class Shape
    {
        protected int width;
        protected int height;

        public Shape(int width = 0,int height = 0)
        {
            this.height = height;
            this.width = width;
        }

        public int getWidth()
        {
            return width;
        }
        public int getHeight(int h)
        {
            return height;
        }
        
    }
}
