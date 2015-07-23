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
        Graphics paper;
        
        public Form1()
        {
            InitializeComponent();
            paper = pictureBox1.CreateGraphics();
            numOfCells = (int)numGridSize.Value;
            cellSize = (int)numCellSize.Value;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen p = new Pen(Color.Black);
            Pen pf = new Pen(Color.Green);
            //Brush b = graphics.co;

            for (int y = 0; y <= numOfCells; ++y)
            {
                graphics.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x <= numOfCells; ++x)
            {
                graphics.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }

            //for (int y = 0; y < numOfCells; ++y)
            //{
            //    graphics.FillRectangle(pf.Brush, 0, y * cellSize, cellSize, cellSize);
            //}

            //for (int x = 0; x < numOfCells; ++x)
            //{
            //    graphics.FillRectangle(pf.Brush, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            //}
        }

        private void numGridSize_ValueChanged(object sender, EventArgs e)
        {
            lblGridSize.Text = numGridSize.Value + " x " + numGridSize.Value;
        }
    }
}
