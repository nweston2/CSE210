using System;

namespace prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int nwAnswer = randomGenerator.Next(1,100);
            int nwGuess;
            int nwAttempts = 0;

            do
            {
                Console.Write("What is your guess? ");
                string nwGuessStr = Console.ReadLine();
                nwGuess = int.Parse(nwGuessStr);

                if (nwGuess != nwAnswer)
                {
                    if (nwGuess > nwAnswer)
                    {
                        Console.WriteLine("Lower");
                    }

                    else if (nwGuess < nwAnswer)
                    {
                        Console.WriteLine("Higher");
                    }

                    nwAttempts += 1;
                }
            } while (nwGuess != nwAnswer);

            Console.WriteLine($"You got it! It took you {nwAttempts} tries.");
        }
    }
}