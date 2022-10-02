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
        public static int ind;

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
            SolidBrush brushcyan = new SolidBrush(Color.Cyan);
            Pen pencyan = new Pen(Color.Cyan);
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

            dataGridView1.DataSource = GamePage3.shipListN;
            dataGridView2.DataSource = GamePage3.shipListS;
            int xloc = GamePage3.shipListN[ind].xLoc;
            int yloc = GamePage3.shipListN[ind].yLoc;
            for (int i = 0; i < GamePage3.shipListN[ind].Size; i++)
            {
                Point point2 = new Point((yloc * 9)+1, (xloc * 9)+i);
                Point point3 = new Point((yloc * 9) - 1, (xloc * 9) + i);
                Size size2 = new Size(3, 3);
                Rectangle rectangle2 = new Rectangle(point2, size2);
                Rectangle rectangle3 = new Rectangle((yloc * 9) - (GamePage3.shipListN[ind].speed*9/2), (xloc * 9), GamePage3.shipListN[ind].speed * 9, GamePage3.shipListN[ind].speed*9);
                //draw a rectangle that encapsulates the range of movement allowed by speed
                //g.DrawRectangle(pencyan, rectangle2);
                g.DrawRectangle(pencyan, rectangle3);
                if(i == GamePage3.shipListN[ind].Size)
                {
                    panel1.Refresh();

                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void shipDesignerBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MoveShip_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows!=null)
            {
                ind = dataGridView1.CurrentRow.Index;
            }
            else 
            { 
                MessageBox.Show("didn't work"); 
            }
            panel1.Refresh();

        }
    }
}
