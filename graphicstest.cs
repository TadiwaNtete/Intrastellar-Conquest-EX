using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCEXtest1
{
    public partial class graphicstest : Form
    {
        public graphicstest()
        {
            InitializeComponent();
        }

        private void graphicstest_Load(object sender, EventArgs e)
        {
            

        }

        private void graphicstest_Paint(object sender, PaintEventArgs e)
        {
            float dx, dy;

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush brushgreen = new SolidBrush(Color.Green);
            SolidBrush brushred = new SolidBrush(Color.Red);
            for (int i = 0; i < GamePage2.designs.Count; i++)
            {
                Point point = new Point((GamePage2.designs[i].Column) * 9, GamePage2.designs[i].Row * 9);
                Size size = new Size(3, 3);
                Rectangle rectangle = new Rectangle(point, size);
                if (GamePage2.designs[i].isOccupied == true)
                {
                    g.FillRectangle(brushred, rectangle);

                }
                else if (GamePage2.designs[i].isOccupied == false)
                {
                    g.FillRectangle(brushgreen, rectangle);

                }
            }
        }
    }
}
