namespace Final
{
    public abstract class Ingredient
    {
        private string _name;
        private float _amount;
        private bool _cold;

        public Ingredient()
        {}

        public abstract void DoubleSize();
        public virtual float Divide()
        {
            return _amount;
        }
    }
}