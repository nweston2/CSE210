namespace Final
{
    public class Solid:Ingredient
    {
        public Solid(string name, string unit, float amount)
        {
            _name = name;
            _unit = unit;
            _amount = amount;
        }
        public override void DoubleSize()
        {
        }
    }
}