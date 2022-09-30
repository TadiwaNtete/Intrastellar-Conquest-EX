using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ISCEXtest1
{
    public class GameCommands
    {
        static int xi1 = 0;
        static int yi1 = 0;
        static int yi2 = 0;
        static int[,] gameStateOriginal;
        static List<CellDesign> cellListOriginal;

        public static Board setBoardDimensions(int dimension)
        {
            Board gameBoard = new Board(dimension);
            return gameBoard;
        }

        static Board gameBoard = GameCommands.setBoardDimensions(64);

        public static List<int> initializeBoardStuff(Board board)
        {
            int boardDim = board.Size;
            int bdiv = boardDim / 2;
            int spawnZone = 8;
            int bzone = ((boardDim - spawnZone) / 2);

            List<int> boardInfo = new List<int>();

            boardInfo.Add(bdiv);
            boardInfo.Add(spawnZone);
            boardInfo.Add(bzone);

            return boardInfo;
        }

        static List<int> boardInfo = initializeBoardStuff(gameBoard);

        public static int[,] initializeStartArea(Board board)
        {
            int[,] baseZone = new int[board.Size, board.Size];
            return baseZone;
        }

        static int[,] baseZone = initializeStartArea(gameBoard);

        public static List<int> initializeStartCoordsX1()
        {
            List<int> startCoordsX1 = new List<int>() { 0 };

            return startCoordsX1;
        }

        static List<int> startCoordsX1 = initializeStartCoordsX1();

        public static List<int> initializeStartCoordsX2(Board board)
        {
            List<int> startCoordsX2 = new List<int>() { board.Size };
            return startCoordsX2;
        }

        static List<int> startCoordsX2 = initializeStartCoordsX2(gameBoard);

        public static List<int> initializeStartCoordsY1(Board board)
        {
            List<int> startCoordsY = new List<int>();

            for(int p = boardInfo[2]; p < boardInfo[2] + boardInfo[1];p++)
            {
                startCoordsY.Add(p);
            }

            return startCoordsY;
        }

        static List<int> startCoordsY = initializeStartCoordsY1(gameBoard);

        //static int[,] afflictedZone;

        public static List<CellDesign> displayBoard(Board useBoard, int[,] blockZone, List<CellDesign> designs)
        {
            designs.Clear();
            List<string> strings = new List<string>();

            for (int x = 0; x < useBoard.Size; x++)
            {
                for (int y = 0; y < useBoard.Size; y++)
                {
                    CellDesign cell = new CellDesign(x, y);
                    designs.Add(cell);
                    if (blockZone[cell.Row, cell.Column] == 0)
                    {
                        strings.Add("0");
                    }
                    else if (blockZone[cell.Row, cell.Column] == 1)
                    {
                        cell.isOccupied = true;
                        strings.Add("X");

                    }
                    Console.Write(strings[y]);
                }
                Console.WriteLine();
                strings.Clear();

            }
            return designs;
        }
        //static List<CellDesign> gameState = displayBoard(gameBoard,blockZone,designs);

        public static int[,] addShip(int size, bool up, List<CellDesign> gameState, int[,]afflictedZone, List<ShipDesigner>shipList)
        {
            ShipDesigner ship = new ShipDesigner(size, up);

            if (up == false)
            {
                if (afflictedZone[startCoordsX2[xi1], startCoordsY[yi1]] == 1)
                {
                    yi1++;
                }
                else
                {
                    ship.xLoc = startCoordsX2[xi1];
                    ship.yLoc = startCoordsY[yi1];
                }

                for (int i = 0; i < ship.Size; i++)
                {
                    afflictedZone[xi1 + i, ship.yLoc] = 1;
                }
                yi1++;
                if (yi1 == startCoordsY.Count)
                {
                    yi1 = 0;
                }

            }
            Console.Clear();
            gameState = displayBoard(gameBoard, afflictedZone, gameState);
            if (up == true)
            {

                if (afflictedZone[startCoordsX1[xi1], startCoordsY[yi2]] == 1)
                {
                    yi2++;
                }
                else
                {
                    ship.xLoc = startCoordsX1[xi1];
                    ship.yLoc = startCoordsY[yi2];
                }
                int z = gameBoard.Size - ship.Size;


                for (int i = 0; i < ship.Size; i++)
                {
                    afflictedZone[z + i, ship.yLoc] = 1;
                }
                yi2++;
                if (yi2 == startCoordsY.Count)
                {
                    yi2 = 0;
                }

                Console.Clear();
                gameState = displayBoard(gameBoard, afflictedZone, gameState);

            }
            shipList.Add(ship);
            return afflictedZone;
        }
        
        public static List<CellDesign> initializeGame(int dimensions, List<CellDesign>designs, List<int> boardInfo, int[,]blockZone, List<int> startCoordsX1, List<int> startCoordsX2, List<int> startCoordsY)
        {
            Board board = setBoardDimensions(dimensions);
            boardInfo = initializeBoardStuff(board);
            blockZone = initializeStartArea(board);
            startCoordsX1 = initializeStartCoordsX1();
            startCoordsX2 = initializeStartCoordsX2(board);
            startCoordsY = initializeStartCoordsY1(board);
            int[,] afflictedZone = new int[board.Size + 1, board.Size + 1];
            designs = displayBoard(board, blockZone, designs);
            return designs;

        }

    }

}
