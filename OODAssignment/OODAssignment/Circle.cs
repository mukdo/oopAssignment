using System;
using System.Collections.Generic;
using System.Text;

namespace OODAssignment
{
    public class Circle
    {
        public double Radius { get; set; }
        public readonly double PI = 3.14;

        public Circle()
        {
            Radius = 1.0;
            Console.ForegroundColor=ConsoleColor.Green;
        }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public Circle(double Radius, string Color, bool Filled) 
        {
            this.Radius = Radius;
            Console.WriteLine("Circle(Radius, Color, Filled) : CTOR is called");
        }

        public virtual double GetArea()
        {
            Console.WriteLine("Circle.GetArea() : Method is called");
            return PI * (Radius * Radius);
        }

        public double GetPerimeter()
        {
            Console.WriteLine("Circle.GetPerimeter() : MTHD is called");
            return 2 * PI * Radius;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Circle Radius : {Radius}");
            Console.WriteLine($"Circle Area { GetArea()}");
            Console.WriteLine("Circle Perimeter {0:0.##}", GetPerimeter());
        }
    }

}

