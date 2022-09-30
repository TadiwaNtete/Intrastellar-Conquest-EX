using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ISCEXtest1
{
    public partial class GamePage3 : Form
    {
        static int oSize = GamePage2.designs.Count;
        static int nSize = (int)Math.Sqrt(oSize);
        public static int[,] afflictedZone = new int[nSize, nSize];
        public static List<ShipDesigner> shipList = new List<ShipDesigner>();

        public GamePage3()
        {
            InitializeComponent();
        }

        private void AddShip_Click(object sender, EventArgs e)
        {
            afflictedZone = GameCommands.addShip(5, true, GamePage2.designs, afflictedZone,shipList);
            var afflicted = GamePage2.designs.Where(a => a.isOccupied == true).FirstOrDefault();
            graphicstest graphicstest = new graphicstest();
            graphicstest.ShowDialog();
            this.Hide();
        }
    }
}
