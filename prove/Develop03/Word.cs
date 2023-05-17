namespace Develop03
{
    public class Word
    {
        private string _word;
        private bool _visible;

        public Word()
        {}

        public void SetInvisible()
        {}

        public bool GetInvisible()
        {
            return _visible;
        }

        public void SetWord(string _string)
        {
            _word = _string;
        }
    }
}