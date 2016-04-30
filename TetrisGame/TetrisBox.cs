using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame
{
    public class TetrisBox : UserControl
    {
        public int Rows = 20;
        public int Columns = 10;
        public int SquareSize = 20;
        public Timer timer;
        public int lines;
        public long score;
        public bool playing;
        public bool paused;
        public Tetrimino currentTetrimino;
        public Tetrimino nextTetrimino;
        public List<Square[]> immovableSquares;
        
        public TetrisBox(Point p)
        {
            DoubleBuffered = true;
            this.Location = p;
            this.Width = (this.Columns * this.SquareSize);
            this.Height = (this.Rows * this.SquareSize);
            immovableSquares = new List<Square[]>();
            for (int i = 0; i < Rows; i++)
            {
                Square[] col = new Square[Columns];
                immovableSquares.Add(col);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(Color.SeaShell), this.Location.X, this.Location.Y, this.Width, this.Height);
        }
    }
}
