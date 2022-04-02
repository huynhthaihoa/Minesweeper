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

        //list of mined cells
        List<Point> mMinedCells;

        //matrix of cell button
        CellButton[,] mCellButtons;

        //matrix of cell value
        int[,] mCellValues;

        //check if any cell is already clicked
        bool mFlag;

        //check if game is finished
        bool mEndGame;

        //number of uncovered cells (excluding mined cells)
        int mUncoveredCellCnt;

        //time count
        long mHourCount;
        int mMinuteCount;
        int mSecondCount;


        public Form1()
        {
            InitializeComponent();
            modeCheckbox.SelectedIndex = 0;
            clickNewButton(null, null);
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

        private List<Point> initializeMineList()
        {
            mMinedCells = new List<Point>();
            Random rd = new Random();
            while (mMinedCells.Count < mMineCount)
            {
                int seed = rd.Next(0, mCellCount);
                Point point = new Point(seed / mColCount, seed % mColCount);
                if (!mMinedCells.Contains(point))
                    mMinedCells.Add(point);
            }
            return mMinedCells;
        }

        private void initializeCellValues()
        {
            mCellValues = new int[mRowCount, mColCount];

            initializeMineList();

            //1st pass - set mine into mCellValue matrix
            foreach (Point point in mMinedCells)
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

        private void initializeCellButtons()
        {
            cellPanel.Controls.Clear();

            cellPanel.RowStyles.Clear();
            cellPanel.ColumnStyles.Clear();

            cellPanel.RowCount = mRowCount;
            cellPanel.ColumnCount = mColCount;

            for (int i = 0; i < mColCount; i++)
            {
                cellPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / mColCount));
            }
            for (int i = 0; i < mRowCount; i++)
            {
                cellPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / mColCount));
            }

            mCellButtons = new CellButton[mRowCount, mColCount];

            for (int i = 0; i < mRowCount; i++)
            {
                for (int j = 0; j < mColCount; j++)
                {
                    mCellButtons[i, j] = new CellButton(i, j);
                    mCellButtons[i, j].Click += new EventHandler(clickCellButton);
                    cellPanel.Controls.Add(mCellButtons[i, j], j, i);
                }
            }
        }

        private void updateRegion(int row, int col, bool updateItself = false)
        {
            List<Point> neighborPoints = getNeighborPoints(row, col);
            int mineCount = 0;
            foreach (Point point in neighborPoints)
            {
                if (mCellValues[point.X, point.Y] != -1)
                {
                    if (updateItself == true)
                        --mCellValues[point.X, point.Y];
                    else
                        ++mCellValues[point.X, point.Y];

                }
                else
                    ++mineCount;
            }
            if (updateItself == true)
            {
                mCellValues[row, col] = mineCount;
                mMinedCells.Remove(new Point(row, col));
            }
            else
            {
                mCellValues[row, col] = -1;
                mMinedCells.Add(new Point(row, col));
            }
        }

        private void clickNewButton(object sender, EventArgs e)
        {
            initializeCellValues();
            initializeCellButtons();
            stateLabel.Text = "";
            mFlag = false;
            mUncoveredCellCnt = 0;
            mEndGame = false;
            mHourCount = 0;
            mMinuteCount = 0;
            mSecondCount = 0;
            //mTimeCount = 0;
            timeTextbox.Text = "00:00:00";
            playTimer.Start();
        }

        private void clickCellButton(object sender, EventArgs e)
        {
            int r = ((CellButton)sender).Row;
            int c = ((CellButton)sender).Col;
            mCellButtons[r, c].Enabled = false;
            if (mFlag == false)
            {
                if (mCellValues[r, c] == -1) //choose the mined cell at the first click
                {
                    Random rd = new Random();

                    //find a new location to replace this mined cell
                    while(true)
                    {
                        int seed = rd.Next(0, mCellCount);
                        Point point = new Point(seed / mColCount, seed % mColCount);
                        if(mCellValues[point.X, point.Y] != -1) //(point.X, point.Y) is a new mined cell
                        {
                            updateRegion(r, c, true); //update the region around the old mined cell
                            updateRegion(point.X, point.Y); //update the region around the new mined cell
                            break;
                        }
                    }
                }
                mFlag = true;
            }

            if (mCellValues[r, c] > 0)
                mCellButtons[r, c].Text = mCellValues[r, c].ToString();
            else if(mCellValues[r, c] == -1)//click mined cell - game over!
                endGame(e);
            else
            {
                List<Point> neighborPoints = getNeighborPoints(r, c, true);
                foreach (Point point in neighborPoints)
                {
                    if (mCellValues[point.X, point.Y] != -1 && mCellButtons[point.X, point.Y].Enabled == true)
                        clickCellButton(mCellButtons[point.X, point.Y], e);
                }
            }

            if (!mEndGame && mCellValues[r, c] != -1)
            {
                ++mUncoveredCellCnt;
                if (mUncoveredCellCnt == mCellCount - mMineCount) //uncover every unmined cell - win game!
                    endGame(e, true);
            }

        }

        private void modeCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(modeCheckbox.SelectedIndex)
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

        private void playTimer_Tick(object sender, EventArgs e)
        {
            //timeTextbox.Text = (int.Parse(timeTextbox.Text) + 1).ToString();
            //++mTimeCount; 
            ++mSecondCount;
            if(mSecondCount >= 60)
            {
                mSecondCount = 0;
                ++mMinuteCount;
                if(mMinuteCount >= 60)
                {
                    mMinuteCount = 0;
                    ++mHourCount;
                }
            }
            timeTextbox.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", mHourCount, mMinuteCount, mSecondCount);
            timeTextbox.Refresh();
        }

        private void endGame(EventArgs e, bool winGame = false)
        {
            mEndGame = true;
            playTimer.Stop();
            stateLabel.Text = (winGame == true) ? "Victory!" : "Game over!";
            if(winGame == true)
            {
                foreach (Point point in mMinedCells)
                {
                    mCellButtons[point.X, point.Y].Enabled = false;
                    mCellButtons[point.X, point.Y].BackColor = Color.Red;
                }
            }
            else
            {
                for (int i = 0; i < mRowCount; i++)
                {
                    for (int j = 0; j < mColCount; j++)
                    {
                        if (mCellButtons[i, j].Enabled == true)
                            clickCellButton(mCellButtons[i, j], e);
                        if(mCellValues[i, j] == -1)
                        {
                            mCellButtons[i, j].BackgroundImage = Resource1.mine;
                            //Properties.Resources.ResourceManager.
                            //mCellButtons[i, j].BackgroundImage = 
                            mCellButtons[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                }
            }
        }
    }
}
