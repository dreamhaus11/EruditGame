using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EruditGame.Core
{
    public class Board
    {
        private int size;
        private Tile[,] grid;

        //Создание поля
        public Board(int size)
        {
            this.size = size;
            grid = new Tile[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = new Tile();
                }
            }

            grid[0, 4].Multiplier = 2;
            grid[4, 0].Multiplier = 2;
            grid[9, 4].Multiplier = 2;
            grid[4, 9].Multiplier = 2;
            grid[4, 4].Multiplier = 2;

            grid[1, 1].Multiplier = 3;
            grid[1, 8].Multiplier = 3;
            grid[8, 1].Multiplier = 3;
            grid[8, 8].Multiplier = 3;
            grid[5, 5].Multiplier = 3;
        }

        //Ставит букву в клетку
        public void PlaceLetter(int x, int y, char letter)
        {
            grid[x, y].Letter = letter;
        }

        //Возвращает букву
        public char GetLetter(int x, int y)
        {
            return grid[x, y].Letter;
        }

        //Возвращает клетку
        public int GetMultiplier(int x, int y)
        {
            return grid[x, y].Multiplier;
        }
    }
}
