using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Reference nwReferenceFirst = new Reference();
            nwReferenceFirst.SetBook("Jeremiah");
            nwReferenceFirst.SetChapter(4);
            nwReferenceFirst.SetVerse(19);
            string nwFirstStr = "My bowels, my bowels! I am pained at my very heart; ";
            nwFirstStr += "my heart maketh a noise in me; I cannot hold my peace, because thou hast heard ";
            nwFirstStr += "O my soul, the sound of the trumpet, the alarm of war.";
            List<string> nwFirstStrings = nwFirstStr.Split(" ").ToList();
            List<Word> nwFirstWords = new List<Word>();
            foreach (string nwstring in nwFirstStrings)
            {
                Word newWord = new Word();
                newWord.SetWord(nwstring);
                nwFirstWords.Add(newWord);
            }

            Reference nwReferenceSecond = new Reference();
            nwReferenceSecond.SetBook("Jeremiah");
            nwReferenceSecond.SetChapter(4);
            nwReferenceSecond.SetVerse(20);
        }
    }
}