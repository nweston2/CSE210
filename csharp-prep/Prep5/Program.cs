using System;

namespace prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            displayWelcome();
            string nwName = promptUserName();
            int nwFaveNum = promptUserNumber();
            int nwSquare = squareNumber(nwFaveNum);
            displayResults(nwSquare, nwName);
        }

        static void displayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string promptUserName()
        {
            Console.Write("Please enter your name: ");
            string nwName = Console.ReadLine();
            return nwName;
        }

        static int promptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string nwNumStr = Console.ReadLine();
            int nwNum = int.Parse(nwNumStr);
            return nwNum;
        }

        static int squareNumber(int nwFav)
        {
            int nwSquared = nwFav * nwFav;
            return nwSquared;
        }

        static void displayResults(int num, string username)
        {
            Console.WriteLine($"{username}, the square of your number is {num}.");
        }
    }
}