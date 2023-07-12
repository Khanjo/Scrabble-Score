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
            Word.ToLower();
            Letters = Word.ToCharArray();
            return Letters;
        }
        public int WordScore()
        {
            int score = 0;
            foreach (char letter in this.Letters)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'l':
                    case 'n':
                    case 'r':
                    case 's':
                    case 't':
                        score += 1;
                        break;
                    case 'd':
                    case 'g':
                        score += 2;
                        break;
                    case 'b':
                    case 'c':
                    case 'm':
                    case 'p':
                        score += 3;
                        break;
                    case 'f':
                    case 'h':
                    case 'v':
                    case 'w':
                    case 'y':
                        score += 4;
                        break;
                    case 'k':
                        score += 5;
                        break;
                    case 'j':
                    case 'x':
                        score += 8;
                        break;
                    case 'q':
                    case 'z':
                        score += 10;
                        break;
                }
            }
            return score;
        }
    }
}