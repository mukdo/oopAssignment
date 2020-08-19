using System;
using System.Collections.Generic;
using System.Text;

namespace OODAssignment
{
    public class Rectangle
    {

        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
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


        public double GetArea()
        {
            Console.WriteLine("Rectangle.GetArea() : MTHD is called");
            return Width * Length;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Rectangle Width: {0}", Width);
            Console.WriteLine("Rectangle Length: {0}", Length);   
            Console.WriteLine("Rectangle Area: {0}", GetArea());
         
        }
    }
}
  