using System;

namespace Develop03
{
    public class Word
    {
        private string _word;
        private bool _visible = true;
        private readonly Random _random = new Random();

        public Word()
        {}

        public void SetInvisible()
        {
            int randNum = _random.Next(0,50);
            if (randNum < 6)
            {
                _visible = false;
            }
        }

        public bool GetInvisible()
        {
            return _visible;
        }

        public void SetWord(string _string)
        {
            _word = _string;
        }

        public string GetWord()
        {
            return _word;
        }

        public void DisplayWord()
        {
            if (_visible == true)
            {
                Console.Write(_word);
                Console.Write(" ");
            }

            else if (_visible == false)
            {
                Console.Write("____");
                Console.Write(" ");
            }
        }
    }
}