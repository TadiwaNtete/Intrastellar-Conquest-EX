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

        public List<string> occupiedSpace { get; set; }
        public int HP { get;set; }

        public bool facingNorth { get; set; }
        public ShipDesigner(int size, bool direction)
        {
            this.occupiedSpace = new List<string>();
            Size = size;
            facingNorth = direction;
            HP = size;
            if(Size == 2)
            {
                speed = 8;
                range = 1;
            }
            else if(Size == 4)
            {
                speed = 5;
                range = 2;
            }
            else if(size==7)
            {
                speed = 2;
                range = 4;
            }
            if(HP == 0)
            {
                
            }




        }
        public void ResetSpace()
        {
            occupiedSpace.Clear();
        }
    public void OccupiedSpace(List<ShipDesigner> ship, List<string> occupiedSpace, int index)
    {
            if(facingNorth == false)
            {
                for (int i = 0; i < ship[index].Size; i++)
                {
                    string x = (xLoc + i).ToString();
                    string y = (yLoc).ToString();
                    string xy = x + "," + y;
                    occupiedSpace.Add(xy);
                }
            }
            if (facingNorth == true)
            {
                for (int i = 0; i < ship[index].Size; i++)
                {
                    string x = (xLoc - i).ToString();
                    string y = (yLoc).ToString();
                    string xy = x + "," + y;
                    occupiedSpace.Add(xy);
                }
            }

        }
    public void AttackShip(int xVal, int yVal, int ind, List<CellDesign> cellDesigns, List<ShipDesigner>shipDesigns)
        {
            int loc = cellDesigns.FindIndex(x => x.Column == yVal && x.Row == xVal);
            string xyval = xVal + "," + yVal;
            if (cellDesigns[loc].isOccupied == true)
            {
                for (int i = 0; i < shipDesigns.Count; i++)
                {
                    int occLoc = shipDesigns[i].occupiedSpace.IndexOf(xyval);
                    if(occLoc != -1)
                    {
                        shipDesigns[i].occupiedSpace[occLoc]
                        Console.WriteLine(sax.ToString());
                    }

                }

            }

        }
    }
}
