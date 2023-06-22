using System;

namespace learning05
{
    public class Square:Shape
    {
        private double _side;

        public override double GetArea()
        {
            _area = _side * _side;
            return _area;
        }
        public Square(string color, double side)
        {
            this.SetColor(color);
            _side = side;
        }
    }
}