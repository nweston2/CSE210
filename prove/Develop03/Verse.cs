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
            //Set the reference to this verse
            _reference = nwReference;
        }

        public Reference GetReference()
        {
            return _reference;
        }

        public void SetWords(string words)
        {
            //Create a list of Words from the string provided
            _stringList = words.Split(" ").ToList();
            foreach (string nwString in _stringList)
            {
                Word nwWord = new Word();
                nwWord.SetWord(nwString);
                _wordList.Add(nwWord);
            }
        }

        public List<Word> GetWords()
        {
            return _wordList;
        }
    }
}