using System.Collections.Generic;
using System;

namespace prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nwNumbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            int nwNum;
            string nwNumStr;

            do
            {
                Console.Write("Enter number: ");
                nwNumStr = Console.ReadLine();
                nwNum = int.Parse(nwNumStr);

                if (nwNum != 0)
                {
                    nwNumbers.Add(nwNum);
                }
            } while (nwNum != 0);

            int nwSum = 0;
            int nwBiggest = 0;

            foreach (int nwNumber in nwNumbers)
            {

            }
        }
    }
}