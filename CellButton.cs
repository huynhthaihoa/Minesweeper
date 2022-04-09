using System;
using System.Drawing;
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
            Font = new Font("Arial", 12, FontStyle.Bold);
            Dock = DockStyle.Fill;
            FlatStyle = FlatStyle.Flat;
            BackgroundImageLayout = ImageLayout.Stretch;
            EnabledChanged += CellButton_EnabledChanged;
            CellButton_EnabledChanged(null, null);
        }

        private void CellButton_EnabledChanged(object sender, EventArgs e)
        {
            BackColor = (Enabled) ? Color.LightGray : Color.DarkGray;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
