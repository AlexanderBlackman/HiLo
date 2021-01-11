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
            Console.WriteLine("The pot is empty, Bye!");
        }
    }

    static class HiLoGame
    {
       const int MAXIMUM = 10;
       static Random steve = new Random();
        static int currentNumber = steve.Next(1, MAXIMUM);
        static private int pot = 10;

       public static int GetPot()
        {
            return pot;
        }

    // This method ended up unnecessary, as private variables can be changed internally.
    //    public static void changePot(int change)
     //   {
    //        pot += change;
     //   }

        public static void Guess(bool ishigher)
        {
            int newnum = steve.Next(1, MAXIMUM);

            if (((ishigher) && (currentNumber > newnum) || ((!ishigher) && (currentNumber < newnum))))
            {
                pot++;
                Console.WriteLine($"You win a buck; total{GetPot()}\nguess again");
            }
            else
            {
               pot--;
                Console.WriteLine($"You lose a whole dollarido, {GetPot()}\nguess again");
            }
            Console.WriteLine(currentNumber);
            currentNumber = newnum;

        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
                Console.WriteLine($"The number is at least {half}");
            else
                Console.WriteLine($"The number is at most {half}");
            pot--;
        }

       

    }
}
