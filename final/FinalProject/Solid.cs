namespace Final
{
    public class Solid:Ingredient
    {
        //Doubling and halfing should result in whole numbers
        public Solid()
        {
        }

        public override void DoubleSize(bool doubled)
        {
            //Doubles the amount. Should return a whole number
        }
        public override string SaveWriteUp()
        {
            //returns a string for save file
            return $"";
        }

        public override string ShoppingWriteUp()
        {
            //returns a string for shopping list
            return $"";
        }
    }
}