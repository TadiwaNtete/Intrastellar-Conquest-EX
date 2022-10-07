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
        public static bool bool1 = false;
        public static bool bool2 = false;
        public static bool bool3 = false;
        public static bool bool4 = false;
        public static bool bool5 = false;
        public static bool bool6 = true;
        public static int ind;
        public static int nX = -1;
        public static int nY = -1;
        public static List<int> NeoZone = new List<int>();
        public static SolidBrush brushgreen = new SolidBrush(Color.Green);
        public static SolidBrush brushred = new SolidBrush(Color.Red);
        public static SolidBrush brushcyan = new SolidBrush(Color.Cyan);
        public static Pen pencyan = new Pen(Color.Cyan);


        private void graphicstest_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GamePage3.shipListN;
            dataGridView2.DataSource = GamePage3.shipListS;
            ind = dataGridView1.CurrentRow.Index;

        }

        private void graphicstest_Paint(object sender, PaintEventArgs e)
        {
            float dx, dy;

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

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
            int xloc = GamePage3.shipListN[ind].xLoc;
            int yloc = GamePage3.shipListN[ind].yLoc;
            if(bool1 == true )
            {
                for (int i = 0; i < GamePage3.shipListN[ind].Size; i++)
                {
                    Point point2 = new Point((yloc * 9) + 1, (xloc * 9) + i);
                    Point point3 = new Point((yloc * 9) - 1, (xloc * 9) + i);
                    Size size2 = new Size(3, 3);
                    Rectangle rectangle2 = new Rectangle(point2, size2);
                    Rectangle rectangle3 = new Rectangle((yloc * 9) - (GamePage3.shipListN[ind].speed * 9), (xloc * 9 / 2), GamePage3.shipListN[ind].speed * 18, GamePage3.shipListN[ind].speed * 10);
                    //draw a rectangle that encapsulates the range of movement allowed by speed
                    //g.DrawRectangle(pencyan, rectangle2);
                    g.DrawRectangle(pencyan, rectangle3);
                    if (i == GamePage3.shipListN[ind].Size)
                    {
                        panel1.Refresh();
                    }
                }
                bool1 = false;
            }
            if (bool2 == true)
            {
                
                    for(int d = 0; d < GamePage3.shipListN[ind].Size; d++)
                    {
                        int fdg = GamePage2.designs.FindIndex(c => c.Column == GamePage3.shipListN[ind].yLoc && c.Row == (GamePage3.shipListN[ind].xLoc)+d);
                        NeoZone.Add(fdg);
                    }

                for (int i = 0; i < GamePage3.shipListN[ind].Size; i++)
                {
                    GamePage2.designs[NeoZone[i]].isOccupied = false;

                    //Point point3 = new Point(((GamePage3.shipListN[ind].yLoc) * 9), (GamePage3.shipListN[ind].xLoc + i) * 9);
                    //Size size = new Size(3, 3);
                    //Rectangle rectangle4 = new Rectangle(point3, size);
                    //g.FillRectangle(brushgreen, rectangle4);
                    //bool4 = true;
                }
                bool4 = true;
                NeoZone.Clear();
            }
            if (bool3 == true)
            {
                for (int d = 0; d < GamePage3.shipListN[ind].Size; d++)
                {
                    int fdg = GamePage2.designs.FindIndex(c => c.Column == nX && c.Row == nY + d);
                    NeoZone.Add(fdg);
                }
                for (int i = 0; i < GamePage3.shipListN[ind].Size; i++)
                {
                    GamePage2.designs[NeoZone[i]].isOccupied = true;
                }

                //for (int i = 0; i < GamePage3.shipListN[ind].Size;i++)
                //{
                //    Size size = new Size(3, 3);
                //    Point point4 = new Point((nX), (nY) + (i * 9));
                //    Rectangle rectangle5 = new Rectangle(point4, size);
                //    g.FillRectangle(brushred, rectangle5);
                bool2 = false;
                MoveShip.Visible = true;
                bool4 = false;
                bool3 = false;
                bool5 = true;
                NeoZone.Clear();
                panel1.Refresh();
                //}

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
                MoveShip.Visible = false;
                ConfirmMove.Visible = true;
                bool1 = true;
            }
            else 
            { 
                MessageBox.Show("didn't work"); 
            }
            panel1.Refresh();

        }
        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
             nX = e.X;
             nY = e.Y;
        }
        private void ConfirmMove_Click(object sender, EventArgs e)
        {  
            if(nX != -1 && nY != -1 &&bool4==false)
            {
                bool1 = false;
                bool2 = true;
                ConfirmMove.Visible = false;
                movementbutton.Visible = true;
                panel1.Refresh();

            }

        }

        private void movementbutton_Click(object sender, EventArgs e)
        {
            if (bool4 == true)
            {
                bool2 = false;
                //GamePage3.shipListN[ind].xLoc = nX;
                //GamePage3.shipListN[ind].yLoc = nY;
                bool3 = true;
                
                movementbutton.Visible = false;
                MoveShip.Visible = true;
                panel1.Refresh();

            }

        }
    }
}
