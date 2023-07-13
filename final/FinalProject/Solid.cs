namespace Final
{
    public class Solid:Ingredient
    {
        //Doubling and halfing should result in whole numbers
        public Solid()
        {
        }

        public override void DoubleSize()
        {
            //Doubles the amount. Should return a whole number
        }

        public override string SaveWriteUp()
        {
            //returns a string for save file
            return $"solid|{_name}|{_unit}|{_amount}";
        }

        public override string ShoppingWriteUp()
        {
            //returns a string for shopping list
            return $"";
        }
    }
}