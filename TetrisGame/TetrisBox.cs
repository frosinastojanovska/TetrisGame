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
        public int lines = 0;
        public long score = 0;
        public bool playing = false;
        public bool paused = false;
        
        
        public TetrisBox(Point p, int width, int height)
        {
            DoubleBuffered = true;
            this.Location = p;
            this.Width = width;
            this.Height = height;
            board = new Board(20, 10, 20, Color.SeaShell, this.Location);
            timer = new Timer();
            timer.Interval = 1000;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            board.Draw(new SolidBrush(board.backgroundColor), new Pen(Color.LightGray), e.Graphics);
        }
    }
}
