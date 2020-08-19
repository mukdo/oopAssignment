using System;
using System.Collections.Generic;
using System.Text;

namespace OODAssignment
{
    public class Cylinder
    {
        public double Height { get; set; }
        public double Radius { get; set; }

        public readonly double PI = 3.14;
        Circle circle = new Circle();
        public Cylinder()
        {
            Height = 1.0;
            Radius = 1.0;
            
            Console.WriteLine("Cylinder() : CTOR is called");
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public Cylinder(double Height)
        {
            this.Height = Height;
            Console.WriteLine("Cylinder(Height) : CTOR is called");
        }


        public  double GetArea()
        {
           
            Console.WriteLine("Cylinder.GetArea() : MTHD is called");
            return 2 * PI * Radius * (Height + Radius);
        }

        public  void DisplayInfo()
        {
            Console.WriteLine("Cylinder Height : {0} Area is: {1}", Height,GetArea());
           
        }
    }
}

