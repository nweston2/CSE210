namespace Final
{
    public class Liquid:Ingredient
    {
        public Liquid()
        {
        }

        public override string SaveWriteUp()
        {
            //returns a string for save file
            return $"liquid|{_name}|{_unit}|{_amount}";
        }
    }
}