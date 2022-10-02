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
        public int speed { get; set; }
        public int range { get; set; }

        public bool facingNorth { get; set; }
        public ShipDesigner(int size, bool direction)
        {

            Size = size;
            facingNorth = direction;
            if(Size == 2)
            {
                speed = 4;
                range = 1;
            }
            else if(Size == 4)
            {
                speed = 2;
                range = 2;
            }
            else if(size==7)
            {
                speed = 1;
                range = 4;
            }
            
            
        }
    }
}
