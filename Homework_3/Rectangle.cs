using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Rectangle: Shape, IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            double area = Width * Length;

            return area;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public void GetSummary()
        {
            Console.WriteLine($"\t* This is a rectangle with Width of {Width} and length of {Length}");
        }
    }
}
