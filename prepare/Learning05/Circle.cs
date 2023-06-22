using System;

namespace learning05
{
    public class Circle:Shape
    {
        private double _radius;
        public override double GetArea()
        {
            _area = Math.PI * Math.Pow(_radius, 2);
            return _area;
        }

        public Circle(string color, double radius)
        {
            this.SetColor(color);
            _radius = radius;
        }
    }
}