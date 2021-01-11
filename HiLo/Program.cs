using System;

namespace HiLo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HiLo");
            Console.WriteLine($"Press h for higher, l for lower, ? to buy a hint,\n" +
                $"or any other key to quit with {HiLoGame.GetPot()}.");

            while (HiLoGame.GetPot() > 0) 
            { 
            char key = Console.ReadKey(true).KeyChar;
            if (key == 'h') HiLoGame.Guess(true);
            else if (key == 'l') HiLoGame.Guess(false);
            else if (key == '?') HiLoGame.Hint();
            else return;
            }
        }
    }

    static class HiLoGame
    {
       const int MAXIMUM = 10;
       static Random steve = new Random();
        static int currentNumber = steve.Next(1, MAXIMUM);
        static private int pot;

       public static int GetPot()
        {
            return pot;
        }

         static Guess(bool ishigher)
        {
            currentNumber = steve.Next(1, MAXIMUM);
            return 3;   
        }

       

    }
}
