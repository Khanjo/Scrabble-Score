using System.Collections.Generic;

namespace Scores.Models
{
    public class Score
    {
        public string Word { get; set; }
        public char[] Letters;
        public Score(string input)
        {
            Word = input;
        }
        public char[] WordArray()
        {
            char[] Letters = Word.ToCharArray();
            return Letters;
        }
    }
}