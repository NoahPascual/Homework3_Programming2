using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3
{
   abstract class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        public abstract double CalculatePerimeter();
    }
}
