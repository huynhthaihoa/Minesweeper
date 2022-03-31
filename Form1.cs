using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //matrix of cell value
        int[,] mCellValue;

        //matrix of cell button
        Button[,] mCellButton;

        public Form1()
        {
            InitializeComponent();
            cbMode.SelectedIndex = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panelCell.Controls.Clear();

            panelCell.RowStyles.Clear();
            panelCell.ColumnStyles.Clear();

            panelCell.RowCount = mRowCount;
            panelCell.ColumnCount = mColCount;

            mCellButton = new Button[mRowCount, mColCount];
            mCellValue = new int[mRowCount, mColCount];

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
                    mCellButton[i, j] = new Button();
                    mCellButton[i, j].Dock = DockStyle.Fill;
                    panelCell.Controls.Add(mCellButton[i, j], j, i);
                }
            }
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
                case 1: //16X16 -> 32 mines
                    {
                        mRowCount = 16;
                        mColCount = 16;
                        mMineCount = 32;
                        break;
                    }
                case 2: //16X30 -> 60 mines
                    {
                        mRowCount = 16;
                        mColCount = 30;
                        mMineCount = 60;
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

        private void setCellValues()
        {
            List<Point> mineList = getMineList();

        }
    }
}
