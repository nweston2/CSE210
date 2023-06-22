using System;

namespace learning05
{
    public class Rectangle:Shape
    {
        protected double _length;
        protected double _width;
        public override double GetArea()
        {
            _area = _length * _width;
            return _area;
        }

        public Rectangle(string color, double length, double width)
        {
            this.SetColor(color);
            _length = length;
            _width = width;
        }
    }
}