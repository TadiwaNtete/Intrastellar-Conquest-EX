using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ISCEXtest1
{
    public partial class GamePage2 : Form
    {
        public static int size = 0;
        //        public static List<CellDesign> initializeGame(int dimensions, List<CellDesign>designs, List<int> boardInfo, int[,]blockZone, List<int> startCoordsX1, List<int> startCoordsX2, List<int> startCoordsY)
        public static List<CellDesign> designs = new List<CellDesign>();
        static List<int> boardInfo;
        static int[,] blockzone;
        static List<int> startCoordsX1;
        static List<int> startCoordsX2;
        List<int> startCoordsY;
        
        public GamePage2()
        {
            InitializeComponent();
        }

        private void GamePage2_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void initializeButton_Click(object sender, EventArgs e)
        {
            size = 64;
                    
        }

        private void small_Click(object sender, EventArgs e)
        {
            size = 8;
        }

        private void big_Click(object sender, EventArgs e)
        {
            size = 128;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if(size != 0)
            {
                AllocConsole();
                designs = GameCommands.initializeGame(size, designs, boardInfo, blockzone, startCoordsX1, startCoordsX2, startCoordsY);
                GamePage3 shiptest = new GamePage3();
                shiptest.ShowDialog();

            }else if(size == 0)
            {
                MessageBox.Show("Pick a map size.");
            }
        }
    }
}
