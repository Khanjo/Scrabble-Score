using System.Collections.Generic;

namespace Scores.Models
{
    public class Score
    {
        public string Word { get; set; }
        public Score(string input)
        {
            Word = input;
        }
    }
}