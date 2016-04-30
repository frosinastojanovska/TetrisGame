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
        public Board board;
        public Timer timer;
        public int lines;
        public long score;
        public bool playing;
        public bool paused;
        
        
        public TetrisBox(Point p, int width, int height)
        {
            DoubleBuffered = true;
            this.Location = p;
            this.Width = width;
            this.Height = height;
            board = new Board(20, 10, 20, Color.SeaShell, this.Location.X, this.Location.Y);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(board.backgroundColor), this.Location.X, this.Location.Y, this.Location.X * 10, this.Location.Y * 20);
            board.Draw(new SolidBrush(board.backgroundColor), e.Graphics);
        }
    }
}
