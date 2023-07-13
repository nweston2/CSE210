using System;

namespace Final
{
    public class Ingredient
    {
        protected string _name;
        protected string _unit;
        protected float _amount;

        public Ingredient()
        {
        }

        public void DoubleSize()
        {
            //doubles the amount needed
            _amount *= 2;
        }

        public void HalfSize()
        {
            //returns doubled recipe to normal
            _amount /= 2;
        }

        public void SetStuff(string name, string unit, float amount)
        {
            //sets the needed information for the ingredient
            _name = name;
            _unit = unit;
            _amount = amount;
        }

        public virtual string SaveWriteUp()
        {
            //if there isn't an ingredient type, that's a problem
            return "something went wrong if you're reading this";
        }

        public virtual string ShoppingWriteUp()
        {
            //if there isn't an ingredient type, that's a problem
            return $"{_name}";
        }

        public virtual void IngredientToCook()
        {
            Console.WriteLine($"{_amount} {_name}");
        }
    }
}