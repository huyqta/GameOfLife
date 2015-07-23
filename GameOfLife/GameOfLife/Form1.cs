using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        int numOfCells = 10;
        int cellSize = 10;
        Graphics graphics;
        //Point mousePoint = new Point(-1, -1);
        List<Cell> listOfCells = new List<Cell>();

        public Form1()
        {
            InitializeComponent();
            numOfCells = (int)numGridSize.Value;
            cellSize = (int)numCellSize.Value;
            InitPictureBox();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            numOfCells = (int)numGridSize.Value;
            cellSize = (int)numCellSize.Value;

            graphics = e.Graphics;
            Pen p = new Pen(Color.Black);
            Pen pf = new Pen(Color.Green);
            Pen pw = new Pen(Color.White);
            //Brush b = graphics.co;
            graphics.Clear(Color.White);
            for (int y = 0; y <= numOfCells; ++y)
            {
                graphics.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x <= numOfCells; ++x)
            {
                graphics.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }

            if (listOfCells.Count > 0)
            {
                foreach (Cell cell in listOfCells)
                {
                    if (cell.CellAlive)
                    {
                        graphics.FillRectangle(pf.Brush, cell.CellPoint.X, cell.CellPoint.Y, cellSize, cellSize);
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

        private void InitPictureBox()
        {
            listOfCells = new List<Cell>();
            for (int i = 0; i < numOfCells; i++)
            {
                for (int j = 0; j < numOfCells; j++)
                {
                    listOfCells.Add(
                        new Cell()
                        {
                            CellPoint = new Point(i * cellSize, j * cellSize),
                            CellAddress = new Point(i, j),
                            CellAlive = false
                        });
                }
            }
            pictureBox1.Size = new System.Drawing.Size(numOfCells * cellSize + 1, numOfCells * cellSize + 1);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //txtTesting.Text += e.Location.X + "," + e.Location.Y + "  |  ";
                //Bitmap b = (Bitmap)pictureBox1.Image;
                int clickX = e.Location.X / cellSize * cellSize;
                int clickY = e.Location.Y / cellSize * cellSize;
                //if (listOfCells.Any(l => l.CellAddress == new Point(e.Location.X / cellSize, e.Location.Y / cellSize)))
                //{
                //    listOfCells.Remove(listOfCells.FirstOrDefault(l => l.CellAddress == new Point(e.Location.X / cellSize, e.Location.Y / cellSize)));
                //}
                //else
                //{
                //    listOfCells.Add(new Cell()
                //                    {
                //                        CellPoint = new Point(clickX, clickY),
                //                        CellAlive = true,
                //                        CellAddress = new Point(e.Location.X / cellSize, e.Location.Y / cellSize)
                //                    });
                //}
                listOfCells.FirstOrDefault(l => l.CellAddress.X == e.Location.X / cellSize && l.CellAddress.Y == e.Location.Y / cellSize).CellAlive = !listOfCells.FirstOrDefault(l => l.CellAddress.X == e.Location.X / cellSize && l.CellAddress.Y == e.Location.Y / cellSize).CellAlive;
                txtTesting.Text += e.Location.X / cellSize + "," + e.Location.Y / cellSize + "  |  ";
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DrawOnMouseClick(Graphics graphics)
        {


        }

        private void GetNumOfAlive(Cell cell)
        {
            int neiboughAlive = 0;
            if (listOfCells.Any(l => l.CellAddress.X == cell.CellAddress.X - 1 && l.CellAddress.Y == cell.CellAddress.Y - 1 && l.CellAlive)) neiboughAlive += 1;
            if (listOfCells.Any(l => l.CellAddress.X == cell.CellAddress.X - 1 && l.CellAddress.Y == cell.CellAddress.Y && l.CellAlive)) neiboughAlive += 1;
            if (listOfCells.Any(l => l.CellAddress.X == cell.CellAddress.X - 1 && l.CellAddress.Y == cell.CellAddress.Y + 1 && l.CellAlive)) neiboughAlive += 1;
            if (listOfCells.Any(l => l.CellAddress.X == cell.CellAddress.X && l.CellAddress.Y == cell.CellAddress.Y - 1 && l.CellAlive)) neiboughAlive += 1;
            if (listOfCells.Any(l => l.CellAddress.X == cell.CellAddress.X && l.CellAddress.Y == cell.CellAddress.Y + 1 && l.CellAlive)) neiboughAlive += 1;
            if (listOfCells.Any(l => l.CellAddress.X == cell.CellAddress.X + 1 && l.CellAddress.Y == cell.CellAddress.Y - 1 && l.CellAlive)) neiboughAlive += 1;
            if (listOfCells.Any(l => l.CellAddress.X == cell.CellAddress.X + 1 && l.CellAddress.Y == cell.CellAddress.Y && l.CellAlive)) neiboughAlive += 1;
            if (listOfCells.Any(l => l.CellAddress.X == cell.CellAddress.X + 1 && l.CellAddress.Y == cell.CellAddress.Y + 1 && l.CellAlive)) neiboughAlive += 1;
            cell.NumOfAlive = neiboughAlive;
            //if (cell.CellAlive && (neiboughAlive <= 1 || neiboughAlive >= 4))
            //{
            //    cell.CellAlive = false;
            //}
            //if (!cell.CellAlive && (neiboughAlive == 3))
            //{
            //    cell.CellAlive = true;
            //}
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
            listOfCells.ForEach(GetNumOfAlive);
            listOfCells.ForEach(UpdateCells);
            //foreach (Cell cell in listOfCells)
            //{
            //for (int i = 0; i < 8; i++)
            //{

            //}
            //if (cell.CellAlive)
            //{
            //    int count = listOfCells.Count(l =>
            //        (l.CellAddress.X == cell.CellAddress.X - 1 && l.CellAddress.Y == cell.CellAddress.Y - 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X - 1 && l.CellAddress.Y == cell.CellAddress.Y && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X - 1 && l.CellAddress.Y == cell.CellAddress.Y + 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X && l.CellAddress.Y == cell.CellAddress.Y - 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X && l.CellAddress.Y == cell.CellAddress.Y && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X && l.CellAddress.Y == cell.CellAddress.Y + 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X + 1 && l.CellAddress.Y == cell.CellAddress.Y - 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X + 1 && l.CellAddress.Y == cell.CellAddress.Y && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X + 1 && l.CellAddress.Y == cell.CellAddress.Y + 1 && l.CellAlive)
            //     );
            //    if (count <= 1 || count >= 4) cell.CellAlive = false;

            //}
            //else
            //{
            //    int count = listOfCells.Count(l =>
            //        (l.CellAddress.X == cell.CellAddress.X - 1 && l.CellAddress.Y == cell.CellAddress.Y - 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X - 1 && l.CellAddress.Y == cell.CellAddress.Y && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X - 1 && l.CellAddress.Y == cell.CellAddress.Y + 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X && l.CellAddress.Y == cell.CellAddress.Y - 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X && l.CellAddress.Y == cell.CellAddress.Y && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X && l.CellAddress.Y == cell.CellAddress.Y + 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X + 1 && l.CellAddress.Y == cell.CellAddress.Y - 1 && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X + 1 && l.CellAddress.Y == cell.CellAddress.Y && l.CellAlive)
            //     || (l.CellAddress.X == cell.CellAddress.X + 1 && l.CellAddress.Y == cell.CellAddress.Y + 1 && l.CellAlive)
            //     );
            //    if (count == 3) cell.CellAlive = true;
            //}

            //}
            pictureBox1.Refresh();
        }
    }

    public class Cell
    {
        public Point CellPoint { get; set; }
        public Point CellAddress { get; set; }
        public bool CellAlive { get; set; }
        public int NumOfAlive { get; set; }
    }
}
