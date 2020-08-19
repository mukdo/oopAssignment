using System;
using System.Collections.Generic;
using System.Text;

namespace OODAssignment
{
    public class Shape
    {
        public string _Color { get; set; }
        public bool _Filled { get; set; }

        public Shape()
        {
            _Color = "Blue";
            Console.ForegroundColor = ConsoleColor.Blue;
            
            _Filled = true;
        }

        public Shape( string color ,bool filled)
        {
            this._Color = color;
            this._Filled = filled;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Shape is called: color ={_Color} ");
            Console.WriteLine($"Filled ={_Filled}");
            Console.WriteLine("======================");
        }
        
        public void ShapeWorks()
        {
            Console.WriteLine("Shape Works Perfectly");
        }
    }
}
