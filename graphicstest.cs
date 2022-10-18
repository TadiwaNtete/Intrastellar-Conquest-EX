using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;
using SkiaSharp.Internals;
using SkiaSharp.Views.Forms;
using SkiaSharp.Views.WPF;
using Xamarin.Forms;

namespace ISCEXtest1
{
    public partial class graphicstest : Form
    {
        public graphicstest()
        {
            InitializeComponent();

        }
        public static int ind;
        public static int nX = -1;
        public static int nY = -1;
        public static List<int> NeoZone = new List<int>();
        public static int selectedColumn;
        public static int selectedRow;
        public static bool moveAllow = false;
        public static bool selectedMove = false;

        private void graphicstest_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = GamePage3.shipListN;
            dataGridView2.DataSource = GamePage3.shipListS;
            ind = dataGridView1.CurrentRow.Index;

        }

        private void graphicstest_Paint(object sender, PaintEventArgs e)
        {   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SKColor grid = SKColors.Green;
            var info = new SKImageInfo(panel1.Size.Width, panel1.Size.Height);

            SKPointI point1 = new SKPointI();
            SKPointI point1y;
            SKPointI point2x;
            SKPointI point2y;

            //for(int i = 0; i<GamePage2.designs.Count;i++)
            {
                using (SKSurface surface = SKSurface.Create(info))
                {
                    SKCanvas canvas = surface.Canvas;
                    using (SKPaint gridInit = new SKPaint())
                    {

                        SKPaint redInit = new SKPaint();
                        SKPaint blueInit = new SKPaint();

                        blueInit.Color = SKColors.Blue;
                        blueInit.IsAntialias = true;
                        blueInit.StrokeWidth = 5;
                        blueInit.Style = SKPaintStyle.Stroke;

                        redInit.Color = SKColors.Red;
                        redInit.IsAntialias = true;
                        redInit.StrokeWidth = 5;
                        redInit.Style = SKPaintStyle.Stroke;

                        gridInit.Color = grid;
                        gridInit.IsAntialias = true;
                        gridInit.StrokeWidth = 5;
                        gridInit.Style = SKPaintStyle.Stroke;

                        for(int x = 0; x < GamePage2.designs.Count;x++)
                        {
                            if (GamePage2.designs[x].isOccupied == false)
                            {
                                if (GamePage2.designs[x].Legal == true)
                                {
                                    canvas.DrawRect(GamePage2.designs[x].Column * 9, GamePage2.designs[x].Row * 9, 1, 1, blueInit);

                                }
                                else if (GamePage2.designs[x].Legal == false)
                                {
                                    canvas.DrawRect(GamePage2.designs[x].Column * 9, GamePage2.designs[x].Row * 9, 1, 1, gridInit);
                                }
                            }
                            else if (GamePage2.designs[x].isOccupied == true)
                            {
                                if(GamePage2.designs[x].Legal == true)
                                {
                                    canvas.DrawRect(GamePage2.designs[x].Column * 9, GamePage2.designs[x].Row * 9, 1, 1, blueInit);

                                } else if (GamePage2.designs[x].Legal == false)
                                {
                                    canvas.DrawRect(GamePage2.designs[x].Column * 9, GamePage2.designs[x].Row * 9, 1, 1, redInit);
                                }
                            }
                        }
                        using (SKImage image = surface.Snapshot())
                        using (SKData data = image.Encode(SKEncodedImageFormat.Jpeg, 100))
                        using (MemoryStream mStream = new MemoryStream(data.ToArray()))
                        {
                            Bitmap bm = new Bitmap(mStream, false);
                            pictureBox1.Image = bm;
                        }
                    }
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
            int ind = dataGridView1.CurrentCell.RowIndex;
            int speed = GamePage3.shipListN[ind].speed;
            int baseInd = GamePage2.designs.FindIndex(x => x.Column == GamePage3.shipListN[ind].yLoc && x.Row == GamePage3.shipListN[ind].xLoc);

            int baseX = GamePage2.designs[baseInd].Row;
            int baseY = GamePage2.designs[baseInd].Column;

            for(int i = 1; i < speed; i++)
            {
                int yind = GamePage2.designs.FindIndex(x => x.Column == GamePage3.shipListN[ind].yLoc + i && x.Row == GamePage3.shipListN[ind].xLoc);
                int xInd = GamePage2.designs.FindIndex(x => x.Column == GamePage3.shipListN[ind].yLoc && x.Row == GamePage3.shipListN[ind].xLoc + i);
                GamePage2.designs[xInd].Legal = true;
                GamePage2.designs[yind].Legal = true;
            }

            pictureBox1.Refresh();
            panel1.Refresh();
            MoveShip.Visible = false;
            ConfirmMove.Visible = true;
            moveAllow = true;
        }
        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void ConfirmMove_Click(object sender, EventArgs e)
        {
            ConfirmMove.Visible = false;
            if(selectedMove == true)
            {
                for (int i = 0; i < GamePage2.designs.Count; i++)
                {
                    if (GamePage2.designs[i].Legal == true)
                    {
                        GamePage2.designs[i].Legal = false;
                    }
                }
                moveAllow = false;
            }else if (selectedMove == false)
            {
                MessageBox.Show("select a move");
            }


        }

        private void movementbutton_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if(moveAllow == true)
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                selectedColumn = e.X;
                selectedRow = e.Y;
                int newColumn;
                int newRow;

                newRow = Math.Abs(GamePage3.shipListN[ind].xLoc - selectedRow);
                newColumn = Math.Abs(GamePage3.shipListN[ind].yLoc - selectedColumn);


                int firstInd = GamePage2.designs.FindIndex(x => x.Column == GamePage3.shipListN[ind].yLoc && x.Row == GamePage3.shipListN[ind].xLoc);

                for (int size = 0; size < GamePage3.shipListN[ind].Size; size++)
                {
                    //GamePage2.designs[firstInd + size].isOccupied = false;
                    int thirdInd = GamePage2.designs.FindIndex(x => x.Column == GamePage3.shipListN[ind].yLoc && x.Row == GamePage3.shipListN[ind].xLoc + size);
                    GamePage2.designs[thirdInd].isOccupied = false;
                }

                GamePage3.shipListN[ind].xLoc = GamePage3.shipListN[ind].xLoc + selectedRow;
                GamePage3.shipListN[ind].yLoc = GamePage3.shipListN[ind].yLoc + selectedColumn;

                //int secInd = GamePage2.designs.FindIndex(x => x.Column == GamePage3.shipListN[ind].yLoc && x.Row == GamePage3.shipListN[ind].xLoc);

                for (int size = 0; size < GamePage3.shipListN[ind].Size; size++)
                {
                    int fourthInd = GamePage2.designs.FindIndex(x => x.Column == GamePage3.shipListN[ind].yLoc && x.Row == GamePage3.shipListN[ind].xLoc + size);
                    GamePage2.designs[fourthInd].isOccupied = true;
                }

                pictureBox1.Refresh();
                panel1.Refresh();
                moveAllow = false;


            }
            else
            {
                MessageBox.Show("Select a blue square to move to.");
            }
            
        }
    }
}
