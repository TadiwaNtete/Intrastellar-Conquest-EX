using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISCEXtest1
{
    public class CellDesign
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool isOccupied { get; set; }
        public bool Legal { get; set; }
        public bool Selected { get; set; }
        public CellDesign(int x, int y)
        {
            Row = x;
            Column = y;
        }

    }
}
