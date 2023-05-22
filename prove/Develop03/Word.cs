using System;
using System.Collections.Generic;

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
            if (randNum < 11)
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
    }
}