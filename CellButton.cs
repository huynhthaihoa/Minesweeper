using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class CellButton : Button
    {
        private int mRow;

        private int mCol;

        //private int mVal;

        public int Row { get { return mRow; } }

        public int Col { get { return mCol; } }

        //public int Value
        //{
        //    get { return mVal; }
        //    set { mVal = value; }
        //}

        public CellButton()
        {
            InitializeComponent();
        }

        public CellButton(int row, int col)
        {
            mRow = row;
            mCol = col;
            //mVal = 0;
            Dock = DockStyle.Fill;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
