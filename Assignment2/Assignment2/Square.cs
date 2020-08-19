using System;

namespace Assignment2
{
    class Square : Rectangle
    {
        public Square(double Side)
        {
            Width = Side;
            Length = Side;
            Console.WriteLine("Square() : CTOR is called");
        }

        public Square(double Side, string Color, bool Filled) : base(Side, Side, Color, Filled)
        {
            Console.WriteLine("Square(Side, Color, Filled) : CTOR is called");
        }
    }
}
