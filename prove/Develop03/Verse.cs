using System;

namespace Develop03
{
    public class Verse
    {
        Reference _reference;
        List<string> _stringList = new List<string>();
        List<Word> _wordList = new List<Word>();

        public Verse()
        {}

        public void SetReference(Reference nwReference)
        {
            _reference = nwReference;
        }

        public void SetWords(string words)
        {
            _stringList = words.Split(" ").ToList();
            foreach (string nwString in _stringList)
            {
                Word nwWord = new Word();
                nwWord.SetWord(nwString);
                _wordList.Add(nwWord);
            }
        }
    }
}