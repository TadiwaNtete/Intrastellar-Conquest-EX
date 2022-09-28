using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISCEXtest1
{
    public class ShipDesigner
    {
        public int Size { get; set; }
        public int xLoc { get; set; }
        public int yLoc { get; set; }

        public bool facingNorth { get; set; }
        public ShipDesigner(int size, bool direction)
        {
            Size = size;
            facingNorth = direction;
            
        }
    }
}
