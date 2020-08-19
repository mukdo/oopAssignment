using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle()
        {
            Width = 1.0;
            Length = 1.0;
            Console.WriteLine("Rectangle() : CTOR is called");
        }

        public Rectangle(double Width, double Length)
        {
            this.Width = Width;
            this.Length = Length;
            Console.WriteLine("Rectangle(Width, Length) : CTOR is called");
        }

        public Rectangle(double Width, double Length, string Color, bool Filled) : base(Color, Filled)
        {
            this.Width = Width;
            this.Length = Length;
            Console.WriteLine("Rectangle(Width, Length, Color, Filled) : CTOR is called");
        }

        public double GetArea()
        {
            Console.WriteLine("Rectangle.GetArea() : MTHD is called");
            return Width * Length;
        }

        public double GetPerimeter()
        {
            Console.WriteLine("Rectangle.GetPerimeter() : MTHD is called");
            return 2 * (Length + Width);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Rectangle Width: {0}", Width);
            Console.WriteLine("Rectangle Length: {0}", Length);
            base.DisplayInfo();
            Console.WriteLine("Rectangle Area: {0}", GetArea());
            Console.WriteLine("Rectangle Perimeter: {0}", GetPerimeter());
        }
    }
}

