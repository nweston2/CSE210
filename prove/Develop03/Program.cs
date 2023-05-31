using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up first verse
            Reference nwReferenceFirst = new Reference();
            Verse nwFirstVerse = new Verse();
            nwReferenceFirst.SetBook("Jeremiah");
            nwReferenceFirst.SetChapter(4);
            nwReferenceFirst.SetVerse(19);
            string nwFirstStr = "My bowels, my bowels! I am pained at my very heart; ";
            nwFirstStr += "my heart maketh a noise in me; I cannot hold my peace, because thou hast heard ";
            nwFirstStr += "O my soul, the sound of the trumpet, the alarm of war.";
            nwFirstVerse.SetReference(nwReferenceFirst);
            nwFirstVerse.SetWords(nwFirstStr);

            //Set up second verse
            Reference nwReferenceSecond = new Reference();
            Verse nwSecondVerse = new Verse();
            nwReferenceSecond.SetBook("Jeremiah");
            nwReferenceSecond.SetChapter(4);
            nwReferenceSecond.SetVerse(20);
            string nwSecondStr = "Destruction upon destruction is cried; for the whole land is spoiled:";
            nwSecondStr += "suddenly are my tents spoiled, and my curtains in a moment.";
            nwSecondVerse.SetReference(nwReferenceSecond);
            nwSecondVerse.SetWords(nwSecondStr);
        }
    }
}