using System;
using System.Collections.Generic;

namespace HIgherLower
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Would you like to play?");

            bool check = Console.ReadLine().ToLower() == "y";
            number guess = new number(5000);
            int x = 0;
            int guessCheck = guess.getNum();
            int highNum = 10000;
            int lowNum = 0;
            if(check)
            {
                for (int i = 0; x == 0; i++)
                {
                    
                    Console.WriteLine("Is your number higher or lower than " + guessCheck + "? [Higher/Lower/Correct]");
                    string ans = Console.ReadLine().ToLower();
                   
                    bool high = ans == "higher";
                    bool low = ans == "lower";
                    bool correct = ans == "correct";
                    if (high)
                    {
                        if(lowNum <= guessCheck)
                        {
                            lowNum = guessCheck;
                        };
                        guessCheck = guessCheck + (highNum - lowNum)/2;
                    }
                    else if (low)
                    {
                        if(highNum >= guessCheck)
                        {
                            highNum = guessCheck;
                        };
                        guessCheck = guessCheck - (highNum - lowNum) / 2;
                    }
                    else if (correct)
                    {
                        x = 1;
                        break;
                    }
                    else Console.WriteLine("Please enter a valid choice");
                };

            }
        }
    }
}
