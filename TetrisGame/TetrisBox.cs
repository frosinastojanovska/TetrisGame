using System.Drawing;
using System.Windows.Forms;

namespace TetrisGame
{
    /// <summary>
    /// A class that represents the logic of the tetris game.
    /// It inherits from the class System.Windows.Forms.UserControl.
    /// </summary>
    public class TetrisBox : UserControl
    {
        public Board board;  // the board where the tetrimino pieces are going to be drawn
        public Timer timer;  // speed of the faling tetrimino pieces
        public int level = 1;  // the current level of the player
        public long score = 0;  // the current score of the player
        public bool playing = false; // indicates the running mode of the game
        public bool paused = false; // indicates the pause mode of the game
        
        /// <summary>
        /// Initializes a new instance of the TetrisBox class with the specific parameters.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public TetrisBox(Point p, int width, int height)
        {
            DoubleBuffered = true;
            this.Location = p;
            this.Width = width;
            this.Height = height;
        }
        /// <summary>
        /// Overriding the OnPaint method of the class System.Windows.Forms.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            board.Draw(new SolidBrush(board.backgroundColor), new Pen(Color.LightGray), e.Graphics);
        }
        /// <summary>
        /// Increases the score with the value of the parameter.
        /// </summary>
        /// <param name="n"></param>
        private void updateScore(int n)
        {
            score += n;
            this.Controls[0].Controls[0].Text = score.ToString();  // change the score in the label
        }
        /// <summary>
        /// Increments the level of the game.
        /// </summary>
        private void updateLevel()
        {
            level++;
            this.Controls[1].Text = level.ToString(); // change the level in the label
        }
        /// <summary>
        /// Starts the game.
        /// </summary>
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
        /// <summary>
        /// Continues the game.
        /// </summary>
        public void continueGame()
        {
            playing = true;
            paused = false;
            timer.Start();
        }
        /// <summary>
        /// Pauses the game.
        /// </summary>
        public void pauseGame()
        {
            playing = false;
            paused = true;
            timer.Stop();
        }
        /// <summary>
        /// Ends the game.
        /// </summary>
        public void endGame()
        {
            playing = false;
            paused = false;
            timer.Stop();
        }

    }
}
