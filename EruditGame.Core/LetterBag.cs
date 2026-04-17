using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EruditGame.Core
{
    public class LetterBag
    {
        private List<char> letters;
        private Random random = new Random();

        public LetterBag()
        {
            letters = new List<char>();

            string allLetters = "АААААББВВВГГДДЕЕЕЕЕЖЗЗИИИИИЙККЛЛММННННОООООППРРРСССТТТТУУФХЦЧШЩЫЬЭЮЯ";

            foreach (char c in allLetters)
            {
                letters.Add(c);
            }
        }

        public char GetRandomLetter()
        {
            if (letters.Count == 0)
                return '\0';

            int index = random.Next(letters.Count);
            return letters[index];
        }
    }
}
