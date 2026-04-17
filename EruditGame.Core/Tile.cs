using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EruditGame.Core
{
    public class Tile
    {
        public char Letter { get; set; }

        public int Multiplier { get; set; }

        public Tile()
        {
            Letter = '\0';
            Multiplier = 1;
        }
    }
}
