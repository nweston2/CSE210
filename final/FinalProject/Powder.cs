namespace Final
{
    public class Powder:Ingredient
    {
        public Powder()
        {
        }

        public override string SaveWriteUp()
        {
            //returns a string for save file
            return $"powder|{_name}|{_unit}|{_amount}";
        }
    }
}