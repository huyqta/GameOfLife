using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        int numOfCells = 10;
        int cellSize = 10;
        Graphics graphics;
        bool[,] listOfCells;
        bool isRun = false;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public MainForm()
        {
            InitializeComponent();
            numOfCells = (int)numGridSize.Value;
            cellSize = (int)numCellSize.Value;
            InitGridBySize(numOfCells);
            timer.Tick += timer_Tick;
        }

        protected void timer_Tick(object sender, EventArgs myEventArgs)
        {
            GenerationPicture();
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            numOfCells = (int)numGridSize.Value;
            cellSize = (int)numCellSize.Value;

            graphics = e.Graphics;
            Pen p = new Pen(Color.Black);
            Pen pf = new Pen(Color.Green);
            Pen pw = new Pen(Color.White);
            graphics.Clear(Color.White);
            for (int y = 0; y <= numOfCells; ++y)
            {
                graphics.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x <= numOfCells; ++x)
            {
                graphics.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }

            for (int i = 0; i < numOfCells; i++)
            {
                for (int j = 0; j < numOfCells; j++)
                {
                    bool cellState = (bool)listOfCells.GetValue(i, j);
                    if (cellState)
                    {
                        graphics.FillRectangle(pf.Brush, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                }
            }
        }

        private void numGridSize_ValueChanged(object sender, EventArgs e)
        {
            numOfCells = (int)numGridSize.Value;
            cellSize = (int)numCellSize.Value;
            lblGridSize.Text = numGridSize.Value + " x " + numGridSize.Value;
            InitPictureBox();
        }

        private void numCellSize_ValueChanged(object sender, EventArgs e)
        {
            InitPictureBox();
        }
        private void InitGridBySize(int size)
        {
            if (size < 5) size = 5;
            listOfCells = new bool[size, size];
        }

        private void InitPictureBox()
        {
            InitGridBySize(numOfCells);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int clickX = e.Location.X / cellSize * cellSize;
                int clickY = e.Location.Y / cellSize * cellSize;
                txtTesting.Text += e.Location.X / cellSize + "," + e.Location.Y / cellSize + "  |  ";
                bool cellState = (bool)listOfCells.GetValue(e.Location.X / cellSize, e.Location.Y / cellSize);
                listOfCells.SetValue(!cellState, e.Location.X / cellSize, e.Location.Y / cellSize);
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UpdateCells(Cell cell)
        {
            if (cell.CellAlive && (cell.NumOfAlive <= 1 || cell.NumOfAlive >= 4))
            {
                cell.CellAlive = false;
            }
            if (!cell.CellAlive && (cell.NumOfAlive == 3))
            {
                cell.CellAlive = true;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer.Interval = 200;
            timer.Start();
        }

        private void GenerationPicture()
        {
            bool[,] listOfCellsTemp = new bool[numOfCells, numOfCells];
            for (int i = 0; i < numOfCells; i++)
            {
                for (int j = 0; j < numOfCells; j++)
                {
                    int numOfCellAlive = 0;

                    numOfCellAlive += IsNeighborAlive(i, j, -1, -1);
                    numOfCellAlive += IsNeighborAlive(i, j, -1, 0);
                    numOfCellAlive += IsNeighborAlive(i, j, -1, 1);
                    numOfCellAlive += IsNeighborAlive(i, j, 0, -1);
                    numOfCellAlive += IsNeighborAlive(i, j, 0, 1);
                    numOfCellAlive += IsNeighborAlive(i, j, 1, -1);
                    numOfCellAlive += IsNeighborAlive(i, j, 1, 0);
                    numOfCellAlive += IsNeighborAlive(i, j, 1, 1);

                    bool shouldLive = false;

                    bool isAlive = listOfCells[i, j];

                    if (isAlive && (numOfCellAlive == 2 || numOfCellAlive == 3))
                    {
                        shouldLive = true;
                    }
                    else if (!isAlive && numOfCellAlive == 3)
                    {
                        shouldLive = true;
                    }

                    listOfCellsTemp.SetValue(shouldLive, i, j);
                }
            }
            listOfCells = listOfCellsTemp;
            pictureBox1.Invalidate();
        }

        private int IsNeighborAlive(int x, int y, int offsetX, int offsetY)
        {
            int result = 0;
            bool isOutBound = x + offsetX < 0 || x + offsetX >= numOfCells || y + offsetY >= numOfCells || y + offsetY < 0;
            if (!isOutBound)
            {
                result = (bool)listOfCells[x + offsetX, y + offsetY] ? 1 : 0;
            }
            return result;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
