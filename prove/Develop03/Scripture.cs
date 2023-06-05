using System;

namespace Develop03
{
    public class Scripture
    {
        List<Verse> _verses = new List<Verse>();

        public Scripture()
        {}

        public void SetVerses(List<Verse> verseList)
        {
            foreach (Verse chunk in verseList)
            {
                _verses.Add(chunk);
            }
        }

        //Write legible reference
        public void CreateReference()
        {
            int smallVerse = 200;
            int bigVerse = 0;
            Reference tempRef = new Reference();
            string bookRef = "";
            int chapRef = 0;
            int verseRef = 0;

            foreach (Verse nwChunk in _verses)
            {
                tempRef = nwChunk.GetReference();
                bookRef = tempRef.GetBook();
                chapRef = tempRef.GetChapter();
                verseRef = tempRef.GetVerse();
                if (smallVerse > verseRef)
                {
                    smallVerse = verseRef;
                }

                if (bigVerse < verseRef)
                {
                    bigVerse = verseRef;
                }
            }

            Console.Write($"{bookRef} {chapRef}:{smallVerse}-{bigVerse} ");
        }
        public void DisplayScripture()
        {

            foreach (Verse nwChunk in _verses)
            {
                foreach (Word nwWord in nwChunk.GetWords())
                {
                    nwWord.DisplayWord();
                    nwWord.SetInvisible();
                }
            }
        }
    }
}