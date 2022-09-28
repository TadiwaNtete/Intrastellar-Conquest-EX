using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISCEXtest1
{
    public class Board
    {
        public int Size { get; set; }
        public CellDesign[,] boardCells { get; set; }
        public Board(int size)
        {
            Size = size;

            boardCells = new CellDesign[Size, Size];
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y<Size;y++)
                {
                    boardCells[x, y] = new CellDesign(x,y);
                }
            }
        }
    }
}
