namespace Develop03
{
    public class Reference
    {
        private string _reference;

        public Reference()
        {}

        public void SetReference(string citation)
        {
            _reference = citation;
        }

        public string GetReference()
        {
            return _reference;
        }
    }
}