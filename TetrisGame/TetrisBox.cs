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
        public int level = 1;
        public long score = 0;
        public bool playing = false;
        public bool paused = false;
        
        
        public TetrisBox(Point p, int width, int height)
        {
            DoubleBuffered = true;
            this.Location = p;
            this.Width = width;
            this.Height = height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            board.Draw(new SolidBrush(board.backgroundColor), new Pen(Color.LightGray), e.Graphics);
        }

        private void updateScore(int n)
        {
            score += n;
            this.Controls[0].Controls[0].Text = score.ToString();
        }

        private void updateLevel()
        {
            level++;
            this.Controls[1].Text = level.ToString();
        }

        public void startGame()
        {
            playing = true;
            paused = false;
            score = 0;
            level = 1;
            Point location = new Point(this.Location.X + 10, this.Location.Y + 5);
            board = new Board(20, 10, 20, Color.SeaShell, location);
            timer = new Timer();
            timer.Interval = 1000;
        }

        public void continueGame()
        {
            playing = true;
            paused = false;
            timer.Start();
        }

        public void pauseGame()
        {
            playing = false;
            paused = true;
            timer.Stop();
        }

        public void endGame()
        {
            playing = false;
            paused = false;
            timer.Stop();
        }

    }
}
