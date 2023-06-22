using System;
using System.Collections.Generic;

namespace learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("blue", 5));
            shapes.Add(new Square("red", 5));
            shapes.Add(new Rectangle("yellow", 5, 6));

            foreach (Shape nwShape in shapes)
            {
                double area = nwShape.GetArea();
                string nwColor = nwShape.GetColor();
                Console.WriteLine($"This {nwColor} shape has an area of {area} square units.");
            }
        }
    }
}