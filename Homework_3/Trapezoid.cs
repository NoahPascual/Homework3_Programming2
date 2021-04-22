using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Trapezoid: Shape, IShape
    {
        public double BaseA { get; set; }
        public double BaseB { get; set; }
        public double LegA { get; set; }
        public double LegB { get; set; }
        public double Height { get; set; }

        public Trapezoid()
        {
            BaseA = 0;
            BaseB = 0;
            LegA = 0;
            LegB = 0;
            Height = 0;
        }

        public Trapezoid(double baseA, double baseB, double legA, double legB, double height)
        {
            BaseA = baseA;
            BaseB = baseB;
            LegA = legA;
            LegB = legB;
            Height = height;
        }
        public override double CalculateArea()
        {
            return (((BaseA + BaseB) / 2) * Height);
        }
        public override double CalculatePerimeter()
        {
            return BaseA + BaseB + LegA + LegB;
        }

        public void GetSummary()
        {
            Console.WriteLine($"\t* This is a trapazoid with a base of {BaseA} and {BaseB}, legs of {LegA} and {LegB}, with a height of {Height}");
        }
    }
}
