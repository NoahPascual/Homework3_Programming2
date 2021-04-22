// Noah Pascual
// MIS 3033-900
// Homework 3

// Instructions:
// 1) Create two new classes based on the UML diagraphs below.
// 2) Make sure to implement the CalculateArea() and CalculatePerimeter() methods appropriately.
// The formulas for these calculations can be found with the links below.
// 3) The implementation of GetSummary() should print out the type of the shape with all the values of its properties. 
// For example, for a triangle, the output should be like this: This is a triangle with edge a of 5, edge b of 4, base of 3, and height of 4.
// 4) Implement polymorphism for CalculateArea() method using the base class virtual method.
// 5) Implement polymorphism for CalculatePerimeter () method using abstract class and abstract method.
// 6) Implement polymorphism for GetSummary () method using interface.
// 7) Create a rectangle object, a circle object, a triangle object, and a trapezoid object. 
//  Make sure to assign appropriate values to the properties of these objects. 
// 8) Create a base class type list and add these objects to the list, then use the foreach loop to call the CalculateArea() method and CalculatePerimeter () method.
//  Make sure these objects perform these methods according to their own implementations (polymorphism).
// 9) Create an interface list, and add these objects to the list, then use the foreach loop to call GetSummary () method.
//  Make sure these objects perform this method according to their own implementations (polymorphism).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Length = 2;
            r1.Width = 2;

            Circle c1 = new Circle(1);

            Trapezoid trap1 = new Trapezoid();
            trap1.BaseA = 6;
            trap1.BaseB = 4;
            trap1.LegA = 4;
            trap1.LegB = 5;
            trap1.Height = 3;

            Triangle tri1 = new Triangle();
            tri1.EdgeA = 5;
            tri1.EdgeB = 4;
            tri1.Base1 = 5;
            tri1.Height = 4;

            // Title (Homework 3)
            string title= "--- Homework 3 ---\n\r";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Area of each Shape
            Console.WriteLine("* Area for each shape:");
            Console.WriteLine("\tRectangle: " + r1.CalculateArea());
            Console.WriteLine("\tCircle: " + c1.CalculateArea());
            Console.WriteLine("\tTrapezoid: " + trap1.CalculateArea());
            Console.WriteLine("\tTriangle: " + tri1.CalculateArea() + 
                "\n\r");

            // Perimeters for each shape
            Console.WriteLine("* Perimeters for each shape:");
            Console.WriteLine("\tRectangle: " + r1.CalculatePerimeter());
            Console.WriteLine("\tCircle: " + c1.CalculatePerimeter());
            Console.WriteLine("\tTrapezoid: " + trap1.CalculatePerimeter());
            Console.WriteLine("\tTriangle: " + tri1.CalculatePerimeter() +
                "\n\r");


            // Polymorphism with foreach loops
            Console.WriteLine("* Area for each shape (Polymorphism):");
            List<Shape> shapes = new List<Shape>();
            shapes.Add(r1);
            shapes.Add(c1);
            shapes.Add(trap1);
            shapes.Add(tri1);
            // Area for each shape (Polymorphism)
            foreach (Shape s in shapes)
            {
                Console.WriteLine($"\t{s.GetType().Name}: {s.CalculateArea()}");

            }
            Console.WriteLine("\n\r");
            // Perimeters for each shape (Polymorphism)
            Console.WriteLine("* Perimeter for each shape (Polymorphism):");
            foreach (Shape s in shapes)
            {
                Console.WriteLine($"\t{s.GetType().Name}: {s.CalculatePerimeter()}");
            }
            Console.WriteLine("\n\r");


            // Summary of each shape
            Console.WriteLine("* Shape Sumamry:");
            r1.GetSummary();
            c1.GetSummary();
            trap1.GetSummary();
            tri1.GetSummary();
            Console.WriteLine("\n\r");
            // Summary for each shape by polymorphism

            Console.WriteLine("* Shape Sumamry (Polymorphism):");
            List<IShape> ishapes = new List<IShape>();
            ishapes.Add(r1);
            ishapes.Add(c1);
            ishapes.Add(trap1);
            ishapes.Add(tri1);
            foreach (IShape i in ishapes)
            {
                i.GetSummary();
            }

            // Readkey
            Console.ReadKey();
        }
    }
}
