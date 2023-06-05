using System;

namespace Develop03
{
    public class Reference
    {
        //initialize variables
        private string _book;
        private int _chapter;
        private int _verse;

        //begin reference instance
        public Reference()
        {}

        public void SetBook(string book)
        {
            _book = book;
        }

        public string GetBook()
        {
            return _book;
        }

        public void SetChapter(int chapter)
        {
            _chapter = chapter;
        }

        public int GetChapter()
        {
            return _chapter;
        }

        public void SetVerse(int verse)
        {
            _verse = verse;
        }

        public int GetVerse()
        {
            return _verse;
        }
    }
}