using System;
using System.Collections.Generic;
using Scores.Models;
using Scores.UserInterfaceModels;

namespace Scores
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(WelcomeBanner.Welcome);
            Body();
        }

        static void Body()
        {
            Console.WriteLine("Please enter your word and you will see how many points it is worth");
            Console.WriteLine("");
            string input = Console.ReadLine();
            Score userScore = new Score(input);
            userScore.WordArray();
            int score = userScore.WordScore();
            Console.WriteLine("");
            Console.WriteLine("Your word scores:");
            Console.WriteLine(score + " points");
            Console.WriteLine("");
            Console.WriteLine("If you wish to check the score of another word enter 'new'. If you wish to see your total score enter 'total'. Otherwise, enter anything else to exit program");
            string userResponse = Console.ReadLine();
            if (userResponse.ToLower() == "new")
            {
                Body();
            }
            else if (userResponse.ToLower() == "total")
            {
                int total = userScore.TotalScore();
                Console.WriteLine(total);
                Body();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}