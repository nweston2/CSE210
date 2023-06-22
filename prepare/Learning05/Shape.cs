using System;

namespace learning05
{
    public abstract class Shape
    {
        private string _color;
        protected double _area;

        protected void SetColor(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public abstract double GetArea();

        public Shape()
        {
        }
    }
}