using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
     class Shape
        {
            private string Color { get; set; }
            private bool Filled { get; set; }

            public Shape()
            {
                Color = "Red";
                Filled = true;
                Console.WriteLine("Shape() : CTOR is called");
            }

            public Shape(string Color, bool Filled)
            {
                this.Color = Color;
                this.Filled = Filled;
                Console.WriteLine("Shape(Color, Filled) : CTOR is called");
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine("Shape Color {0}", Color);
                Console.WriteLine("Shape Filled {0}", Filled);
            }
        }
}
