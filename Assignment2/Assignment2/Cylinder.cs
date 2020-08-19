using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Cylinder : Circle
    {
        public double Height { get; set; }

        public Cylinder()
        {
            Height = 1.0;
            Console.WriteLine("Cylinder() : CTOR is called");
        }

        public Cylinder(double Height)
        {
            this.Height = Height;
            Console.WriteLine("Cylinder(Height) : CTOR is called");
        }

        public Cylinder(double Height, double Radius) : base(Radius)
        {
            this.Height = Height;
            Console.WriteLine("Cylinder(Height, Radius) : CTOR is called");
        }

        public Cylinder(double Height, double Radius, string Color, bool Filled) : base(Radius, Color, Filled)
        {
            this.Height = Height;
            Console.WriteLine("Cylinder(Height, Radius, Color, Filled) : CTOR is called");
        }

        public override double GetArea()
        {
            Console.WriteLine("Cylinder.GetArea() : MTHD is called");
            return 2 * PI * Radius * (Height + Radius);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Cylinder Height : {0}", Height);
            base.DisplayInfo();
        }
    }
}
