using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TetrisGame
{
    public enum Direction
    {
        Down,
        Left,
        Right
    }
    /// <summary>
    /// A class that represents the logic of the tetris game.
    /// It inherits from the class System.Windows.Forms.UserControl.
    /// </summary>
    public class TetrisBox : UserControl
    {
        private Board board;  // the board where the tetrimino pieces are going to be drawn
        private Timer timer;  // timer that helps calculate the time
        private long time;  // the time that the game is played
        private int speed;  // the speed that tetriminos are moving down
        private int level = 1;  // the current level of the player
        private long score = 0;  // the current score of the player
        private int update = 0;  // indicates when the level is going to be incremented
        private long highScore = 0; // the highest score of the player
        public bool playing = false; // indicates the running mode of the game
        public bool paused = false; // indicates the pause mode of the game
        public Tetrimino currentTetrimino;  // tetrimino that moves
        public Tetrimino nextTetrimino;  // next tetrimino that will move
        public Dictionary<int, Tetrimino> Tetriminoes;  // all possible tetriminos
        private Graphics graphics;  // graphics of the game
        private static Random random = new Random(); // choose the next tetrimino
        
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
            addTetriminos();
            graphics = this.CreateGraphics();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            time = 0;
        }
        /// <summary>
        /// Adds all possible tetriminos in the dictionary Tetriminos
        /// </summary>
        private void addTetriminos()
        {
            Tetriminoes = new Dictionary<int, Tetrimino>();
            Tetriminoes.Add(0, new TetriminoO());
            Tetriminoes.Add(1, new TetriminoI());
            Tetriminoes.Add(2, new TetriminoJ());
            Tetriminoes.Add(3, new TetriminoL());
            Tetriminoes.Add(4, new TetriminoT());
            Tetriminoes.Add(5, new TetriminoS());
            Tetriminoes.Add(6, new TetriminoZ());
        }
        /// <summary>
        ///  Occurs when the timer interval has elapsed and the timer is enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            updateTime();
            if (time % speed == 0)
                move(Direction.Down);
        }
        /// <summary>
        /// Updates the time of the game.
        /// </summary>
        private void updateTime()
        {
            time = time + timer.Interval;
            if (time % 1000 == 0)
            {
                long seconds = (time / 1000) % 60;
                long minutes = (time / 1000) / 60;
                this.Controls[3].Controls[0].Text = String.Format("{0:00}:{1:00}", minutes, seconds);
            }
        }
        /// <summary>
        /// Creates the next tetrimino that will fall
        /// </summary>
        /// <param name="g"></param>
        public void createTetrimino()
        {
            if (nextTetrimino != null)
            {
                currentTetrimino = nextTetrimino;
            }
            else
            {
                currentTetrimino = Tetriminoes[random.Next(7)];
            }
            nextTetrimino = Tetriminoes[random.Next(7)];
        }
        /// <summary>
        /// Moves the current tetrimino down, left or right
        /// </summary>
        public void move(Direction direction)
        {
            if (direction == Direction.Down)
            {
                if (!currentTetrimino.safeDown(board.immovableSquares))
                {
                    if (currentTetrimino.isOut())
                        endGame();
                    else
                    {
                        board.addSquares(currentTetrimino);
                        checkFullRows();
                        addTetriminos();
                        createTetrimino();
                    }

                }
                else
                {
                    currentTetrimino.moveDown(board.immovableSquares);
                }
            }
            else if (direction == Direction.Left)
            {
                currentTetrimino.moveLeft(board.immovableSquares);
            }
            else
            {
                currentTetrimino.moveRight(board.immovableSquares);
            }
            Invalidate();
        }
        /// <summary>
        /// Looks for full rows
        /// </summary>
        private void checkFullRows()
        {
            int sum = 0;
            List<int> rowsForDeleting = new List<int>();

            foreach (Square s in currentTetrimino.s)
            {
                int y = s.Y;
                if (!rowsForDeleting.Contains(y))
                    rowsForDeleting.Add(y);
            }
            rowsForDeleting.Sort();
            foreach(int y in rowsForDeleting)
            {
                int count = 0;
                for(int i=0; i < board.Columns; i++)
                {
                    if (board.immovableSquares[y][i] == null)
                    {
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (count == board.immovableSquares[y].Length)
                {
                    sum += sum * 2 + 60;
                    board.immovableSquares.RemoveAt(y);
                    board.immovableSquares.Insert(0, new Square[board.Columns]);
                }
            }
            updateScore(sum);
        }
        /// <summary>
        /// Overriding the OnPaint method of the class System.Windows.Forms.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            board.Draw(new SolidBrush(board.backgroundColor), new Pen(Color.LightGray), e.Graphics);
            currentTetrimino.Draw(e.Graphics, board.Location);
        }
        /// <summary>
        /// Increases the score with the value of the parameter.
        /// </summary>
        /// <param name="n"></param>
        private void updateScore(int n)
        {
            score += n;
            update += n;
            this.Controls[0].Controls[0].Text = score.ToString();  // change the score in the label
            if(n != 0 && (update/500) > 0)
            {
                updateLevel();
                this.speed -= 100;
                this.update -= 500;
            }
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
            update = 0;
            level = 1;
            speed = 1000;
            Point location = new Point(this.Location.X + 10, this.Location.Y + 5);
            board = new Board(20, 10, 20, Color.SeaShell, location);
            addTetriminos();
            timer.Start();
            currentTetrimino = null;
            nextTetrimino = null;
            createTetrimino();
            Invalidate();
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
            time = 0;
            update = 0;
            score = 0;
            level = 0;
            updateTime();
            if (highScore < score)
                highScore = score;
            HighScore dialog = new HighScore(highScore, score);
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                startGame();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TetrisBox
            // 
            this.Name = "TetrisBox";
            this.ResumeLayout(false);

        }

        public bool safeToRotate(Tetrimino tetrimino)
        {
            //  Tetrimino t = new Tetrimino(tetrimino);

            tetrimino.rotate(board.immovableSquares);
            if (!tetrimino.safe(board.immovableSquares))
            {
                tetrimino.rotate(board.immovableSquares);
                tetrimino.rotate(board.immovableSquares);
                tetrimino.rotate(board.immovableSquares);
                return false;
            }
            return true;
        }

        public void rotate()
        {
            safeToRotate(currentTetrimino);
            Invalidate();
        }
    }
}
