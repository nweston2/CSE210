namespace Final
{
    public class Ingredient
    {
        protected string _name;
        protected string _unit;
        protected float _amount;
        private bool _cold;

        public Ingredient()
        {
        }

        public virtual void DoubleSize()
        {}
        public virtual float Divide()
        {
            return _amount;
        }

        public void SetStuff(string name, string unit, float amount)
        {
            _name = name;
            _unit = unit;
            _amount = amount;
        }
    }
}