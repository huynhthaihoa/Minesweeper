using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        //number of rows
        int mRowCount;

        //number of columns
        int mColCount;

        //number of cells
        int mCellCount;

        //number of mines
        int mMineCount;

        //matrix of cell button
        CellButton[,] mCellButtons;

        //matrix of cell value
        int[,] mCellValues;

        //check if any cell is already clicked
        bool mFlag;

        public Form1()
        {
            InitializeComponent();
            cbMode.SelectedIndex = 0;
            btnNew_Click(null, null);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mFlag = false;

            panelCell.Controls.Clear();

            panelCell.RowStyles.Clear();
            panelCell.ColumnStyles.Clear();

            panelCell.RowCount = mRowCount;
            panelCell.ColumnCount = mColCount;

            mCellButtons = new CellButton[mRowCount, mColCount];
            
            mCellValues = new int[mRowCount, mColCount];
            setCellValues();

            for (int i = 0; i < mColCount; i++)
            {
                panelCell.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / mColCount));
            }
            for (int i = 0; i < mRowCount; i++)
            {
                panelCell.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / mColCount));
            }

            for(int i = 0; i < mRowCount; i++)
            {
                for(int j = 0; j < mColCount; j++)
                {
                    mCellButtons[i, j] = new CellButton(i, j);
                    mCellButtons[i, j].Click += new EventHandler(clickCellButton);
                    panelCell.Controls.Add(mCellButtons[i, j], j, i);
                }
            }

        }

        private void clickCellButton(object sender, EventArgs e)
        {
            int r = ((CellButton)sender).Row;
            int c = ((CellButton)sender).Col;
            mCellButtons[r, c].Enabled = false;
            
            if (mCellValues[r, c] != 0)
            {
                mCellButtons[r, c].Text = mCellValues[r, c].ToString();
                
                if(mCellValues[r, c] == -1)
                {
                    if(mFlag == true)
                    {
                        for (int i = 0; i < mRowCount; i++)
                        {
                            for (int j = 0; j < mColCount; j++)
                            {
                                if (mCellButtons[i, j].Enabled == true)
                                    clickCellButton(mCellButtons[i, j], e);
                            }
                        }
                    }
                    else
                    {
                        //update the position of the clicked mine
                    }
                }
            }
            else
            {
                List<Point> neighborPoints = getNeighborPoints(r, c, true);
                foreach (Point point in neighborPoints)
                {
                    if (mCellValues[point.X, point.Y] != -1)
                        clickCellButton(mCellButtons[point.X, point.Y], e);
                }
            }

            if (mFlag == false)
                mFlag = true;
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbMode.SelectedIndex)
            {
                case 0: //9X9 -> 10 mines
                    {
                        mRowCount = 9;
                        mColCount = 9;
                        mMineCount = 10;
                        break;
                    }
                case 1: //16X16 -> 40 mines
                    {
                        mRowCount = 16;
                        mColCount = 16;
                        mMineCount = 40;
                        break;
                    }
                case 2: //16X30 -> 99 mines
                    {
                        mRowCount = 16;
                        mColCount = 30;
                        mMineCount = 99;
                        break;
                    }
            }

            mCellCount = mRowCount * mColCount;
        }

        private List<Point> getMineList()
        {
            List<Point> mineList = new List<Point>();
            Random rd = new Random();
            while (mineList.Count < mMineCount)
            {
                int seed = rd.Next(0, mCellCount);
                Point point = new Point(seed / mColCount, seed % mColCount);
                if (!mineList.Contains(point))
                    mineList.Add(point);
            }
            return mineList;
        }

        private List<Point> getNeighborPoints(int row, int col, bool checkEnable = false)
        {
            List<Point> neighborPoints = new List<Point>();
            if (row > 0)
            {
                if (checkEnable == false || mCellButtons[row - 1, col].Enabled == true)
                    neighborPoints.Add(new Point(row - 1, col));
                if (col > 0 && (checkEnable == false || mCellButtons[row - 1, col - 1].Enabled == true))
                    neighborPoints.Add(new Point(row - 1, col - 1));
                if (col < mColCount - 1 && (checkEnable == false || mCellButtons[row - 1, col + 1].Enabled == true))
                    neighborPoints.Add(new Point(row - 1, col + 1));
            }
            if (col > 0)
            {
                if (checkEnable == false || mCellButtons[row, col - 1].Enabled == true)
                    neighborPoints.Add(new Point(row, col - 1));
                if (row < mRowCount - 1 && (checkEnable == false || mCellButtons[row + 1, col - 1].Enabled == true))
                    neighborPoints.Add(new Point(row + 1, col - 1));
            }
            if (row < mRowCount - 1)
            {
                if (checkEnable == false || mCellButtons[row + 1, col].Enabled == true)
                    neighborPoints.Add(new Point(row + 1, col));
                if (col < mColCount - 1 && (checkEnable == false || mCellButtons[row + 1, col + 1].Enabled == true))
                    neighborPoints.Add(new Point(row + 1, col + 1));
            }
            if (col < mColCount - 1 && (checkEnable == false || mCellButtons[row, col + 1].Enabled == true))
                neighborPoints.Add(new Point(row, col + 1));
            return neighborPoints;
        }

        private void setCellValues()
        {
            List<Point> mineList = getMineList();

            //1st pass - set mine into mCellValue matrix
            foreach (Point point in mineList)
                mCellValues[point.X, point.Y] = -1;

            //2nd pass - update value for each mine's neighbor
            for (int i = 0; i < mRowCount; i++)
            {
                for (int j = 0; j < mColCount; j++)
                {
                    if (mCellValues[i, j] != -1)
                    {
                        List<Point> neighborPoints = getNeighborPoints(i, j);
                        foreach (Point point in neighborPoints)
                        {
                            if (mCellValues[point.X, point.Y] == -1)
                                ++mCellValues[i, j];
                        }
                    }

                }
            }
        }
    }
}
