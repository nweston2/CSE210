using System.Collections.Generic;
using System;

namespace prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> nwNumbers = new List<float>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            float nwNum;
            string nwNumStr;

            do
            {
                Console.Write("Enter number: ");
                nwNumStr = Console.ReadLine();
                nwNum = float.Parse(nwNumStr);

                if (nwNum != 0)
                {
                    nwNumbers.Add(nwNum);
                }
            } while (nwNum != 0);

            float nwSum = 0;
            float nwBiggest = 0;

            foreach (float nwNumber in nwNumbers)
            {
                nwSum += nwNumber;
                if (nwNumber > nwBiggest)
                {
                    nwBiggest = nwNumber;
                }
                // Console.WriteLine(nwNumber);
            }
            float nwAmount = nwNumbers.Count;
            float nwAverage = nwSum / nwAmount;

            Console.WriteLine($"The sum is: {nwSum}");
            Console.WriteLine($"The average is: {nwAverage}");
            Console.WriteLine($"The largest number is: {nwBiggest}");
        }
    }
}