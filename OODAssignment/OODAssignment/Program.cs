using System;

namespace OODAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new Shape();
            shape.DisplayInfo();
            Console.WriteLine("====================");
            
            var circle = new Circle();
            circle.DisplayInfo();
            Console.WriteLine("====================");

            var cylinder = new Cylinder();
            cylinder.DisplayInfo();
            Console.WriteLine("====================");

            var rectangle = new Rectangle();
            cylinder.DisplayInfo();
            Console.WriteLine("===================="); 
            
            var squre = new Square();
            cylinder.DisplayInfo();
            Console.WriteLine("====================");
        }
    }
}
