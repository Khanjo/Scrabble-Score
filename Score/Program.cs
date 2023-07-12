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
            string input = Console.ReadLine();
            Score userScore = new Score(input);
            userScore.WordArray();
            int score = userScore.WordScore();
            Console.WriteLine(score);
            Console.WriteLine("If you wish to check the score of another word enter 'new' otherwise enter anything to exit program");
            string userResponse = Console.ReadLine();
            if (userResponse.ToLower() == "new")
            {
                Body();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}