using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    /// <summary>
    /// An abstract class that holds an abstract representation of the Tetrimino (the building shape of the game).
    /// </summary>
    public abstract class Tetrimino
    {
        public Square s1 { get; set; }
        public Square s2 { get; set; }
        public Square s3 { get; set; }
        public Square s4 { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public Color color { get; set; }
        public int state { get; set; }

        public Tetrimino(Point p, float x, float y)
        {
            X = x;
            Y = y;
            color = Color.PeachPuff;
        }

        public void Draw(Graphics g)
        {
            s1.Draw(g);
            s2.Draw(g);
            s3.Draw(g);
            s4.Draw(g);
        }

        /// <summary>
        /// Move methods: moves the tetrimino down, left or right accordingly.
        /// </summary>
        public void moveDown()
        {
            s1.moveDown();
            s2.moveDown();
            s3.moveDown();
            s4.moveDown();
        }

        public void moveLeft()
        {
            s1.moveLeft();
            s2.moveLeft();
            s3.moveLeft();
            s4.moveLeft();
        }

        public void moveRight()
        {
            s1.moveRight();
            s2.moveRight();
            s3.moveRight();
            s4.moveRight();
        }

        /// <summary>
        /// Safe methods: define whether the tetrimino can move left, right or down accordingly.
        /// </summary>

        public abstract bool safeLeft();
        public abstract bool safeRight();
        public abstract bool safeDown();


        /// <summary>
        /// Method safe: uses the three safe-methods to define whether the tetrimino can be moved or rotated.
        /// </summary>
        public bool safe()
        {
            return safeLeft() && safeRight() && safeDown();
        }

        /// <summary>
        /// Method rotate: rotates the tetrimino clockwise.
        /// </summary>
        public abstract void rotate();
    }
}
