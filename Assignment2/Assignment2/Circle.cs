using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Circle : Shape
    {
        protected double Radius { get; set; }
        protected const double PI = 3.14;

        public Circle()
        {
            Radius = 1.0;
            Console.WriteLine("Circle() : CTOR is called");
        }

        public Circle(double Radius)
        {
            this.Radius = Radius;
            Console.WriteLine("Circle(Radius) : CTOR is called");
        }

        public Circle(double Radius, string Color, bool Filled) : base(Color, Filled)
        {
            this.Radius = Radius;
            Console.WriteLine("Circle(Radius, Color, Filled) : CTOR is called");
        }

        public virtual double GetArea()
        {
            Console.WriteLine("Circle.GetArea() : MTHD is called");
            return PI * (Radius * Radius);
        }

        public double GetPerimeter()
        {
            Console.WriteLine("Circle.GetPerimeter() : MTHD is called");
            return 2 * PI * Radius;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Circle Radius : {0}", Radius);
            base.DisplayInfo();
            Console.WriteLine("Circle Area {0:0.##}", GetArea());
            Console.WriteLine("Circle Perimeter {0:0.##}", GetPerimeter());
        }
    }
}
