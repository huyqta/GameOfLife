using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{

    [TestClass]
    public class GameOfLife
    {
        bool[,] listOfCells;
        int gridSize = 1;
        int cellSize = 10;

        [TestMethod]
        public void TheListsShouldBeCreateCellsBySizeAtleast25Cells()
        {
            InitGridBySize(gridSize);
            Assert.IsNotNull(listOfCells);
            Assert.IsTrue(listOfCells.Length >= 25);
        }

        public void TheCellShouldBeChangeState()
        {
            InitGridBySize(gridSize);

            //Cell cell = listOfCells.FirstOrDefault();

            //ChangeStateOfCell(listOfCells.)

            Assert.IsNotNull(listOfCells);
            Assert.IsTrue(listOfCells.Length > 0);
        }

        private void ChangeStateOfCell(Cell cell)
        {
            cell.state = !cell.state;
        }

        private void InitGridBySize(int size)
        {
            if (size < 5) size = 5;
            listOfCells = new bool[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    listOfCells.SetValue(false, i, j);
                }
            }
        }
    }

    public class Cell
    {
        public int locX { get; set; }
        public int locY { get; set; }
        public bool state { get; set; }
        public int numOfAlive { get; set; }
    }
}
