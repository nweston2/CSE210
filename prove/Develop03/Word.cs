using System;

namespace Develop03
{
    public class Word
    {
        //string that contains the word itself
        private string _word;
        //is the word visible in the display? default is true
        public bool _visible = true;
        private readonly Random _random = new Random();

        public Word()
        {}

        public void SetInvisible()
        {
            //Randomly determines if word becomes visible
            int randNum = _random.Next(0,50);
            if (randNum < 6)
            {
                _visible = false;
            }
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
            //If the word is visible, print it. Otherwise give a blank
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