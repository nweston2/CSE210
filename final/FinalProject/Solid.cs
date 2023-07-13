using System;

namespace Final
{
    public class Solid:Ingredient
    {
        public Solid()
        {
        }

        public override string SaveWriteUp()
        {
            //returns a string for save file
            return $"solid|{_name}|{_unit}|{_amount}";
        }

        public override string ShoppingWriteUp()
        {
            //returns a string for shopping list
            return $"{_amount} {_name}";
        }
    }
}