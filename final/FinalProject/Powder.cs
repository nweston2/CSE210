namespace Final
{
    public class Powder:Ingredient
    {
        public Powder()
        {
        }
        public override void DoubleSize()
        {
            //doubles the amount
        }

        public override string SaveWriteUp()
        {
            //returns a string for save file
            return $"powder|{_name}|{_unit}|{_amount}";
        }

        public override string ShoppingWriteUp()
        {
            //returns a string for shopping list
            return $"";
        }
    }
}