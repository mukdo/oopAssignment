using System;
using System.Collections.Generic;
using System.Text;

namespace OODAssignment
{
    public class Square
    {
        public double Side { get; set; }
        public Square()
        {
            
            Side = 2;
        }
        public Square(double Side)
        {
            this.Side = Side;

            Console.WriteLine("Square() : CTOR is called");
        }

        public double GetArea()
        {
            double result = Side * Side;
            return result;
        }
      public void DisplayDisplayInfo()
        {
            Console.WriteLine($"Your Square value is : {GetArea()}");
        }
    }
}
