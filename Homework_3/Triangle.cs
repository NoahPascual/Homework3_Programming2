using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Triangle : Shape, IShape
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double Base1 { get; set; }
        public double Height { get; set; }

        public Triangle()
        {
            EdgeA = 0;
            EdgeB = 0;
            Base1 = 0;
            Height = 0;
        }

        public Triangle(double edgeA, double edgeB, double base1, double height)
        {
            EdgeA = edgeA;
            EdgeB = edgeB;
            Base1 = base1;
            Height = height;
        }
        public override double CalculateArea()
        {
            return (Base1 * Height) / 2;
        }
        public override double CalculatePerimeter()
        {
            return EdgeA + EdgeB + Base1;
        }

        public void GetSummary()
        {
            Console.WriteLine($"\t* This is a triangle with edge a of {EdgeA}, edge b of {EdgeB}, base of {Base1}, and height of {Height}.");
        }

    }
}
