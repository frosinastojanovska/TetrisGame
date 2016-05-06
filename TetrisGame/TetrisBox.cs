﻿using System;
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
            Tetriminoes = new Dictionary<int, Tetrimino>();
            Tetriminoes.Add(0, new TetriminoO());
            Tetriminoes.Add(1, new TetriminoI());
            Tetriminoes.Add(2, new TetriminoJ());
            Tetriminoes.Add(3, new TetriminoL());
            Tetriminoes.Add(4, new TetriminoT());
            Tetriminoes.Add(5, new TetriminoS());
            Tetriminoes.Add(6, new TetriminoZ());
            graphics = this.CreateGraphics();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            time = 0;
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
                currentTetrimino.moveDown(board.immovableSquares);
            }
            else if (direction == Direction.Left)
            {
                currentTetrimino.moveLeft();
            }
            else
            {
                currentTetrimino.moveRight();
            }
            Invalidate();
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
            speed = 1000;
            Point location = new Point(this.Location.X + 10, this.Location.Y + 5);
            board = new Board(20, 10, 20, Color.SeaShell, location);
            timer.Start();
            currentTetrimino = null;
            nextTetrimino = null;
            createTetrimino();
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
            updateTime();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TetrisBox
            // 
            this.Name = "TetrisBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TetrisBox_KeyDown);
            this.ResumeLayout(false);

        }

        private void TetrisBox_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Right)
            {
                move(Direction.Right);
            }
            else if (e.KeyCode == Keys.Left)
            {
                move(Direction.Left);
            }
            else if (e.KeyCode == Keys.Up)
            {
                //rotate
            }
            else
            {
                //speed up
            }
            Invalidate();*/
        }
    }
}
