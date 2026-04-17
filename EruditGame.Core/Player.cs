using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EruditGame.Core
{
    public class Player
    {
        public List<char> Letters { get; set; } = new List<char>();
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public void AddScore(int points)
        {
            Score += points;
        }

        public void FillLetters(LetterBag bag)
        {
            while (Letters.Count < 7)
            {
                char c = bag.GetRandomLetter();

                if (c != '\0')
                    Letters.Add(c);
                else
                    break;
            }
        }

        public void ReplaceLetters(LetterBag bag)
        {
            Letters.Clear();
            FillLetters(bag);
        }
    }
}
