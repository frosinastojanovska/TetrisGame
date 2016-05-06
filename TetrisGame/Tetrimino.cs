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
        public Square[] s;
        public int X { get; set; }
        public int Y { get; set; }
        public Color color { get; set; }
        public int state { get; set; }

        public Tetrimino(Color c)
        {
            X = 3;
            Y = 0;
            color = c;
            state = 1;

            s = new Square[4];
            for(int i=0; i<4; i++)
            {
                s[i] = new Square();
                s[i].color = c;
            }

            s[0].X = X;
            s[0].Y = Y;
        }

        public void Draw(Graphics g, Point p)
        {
           for(int i=0; i<4; i++)
            {
                s[i].Draw(g, p);
            }
        }

        /// <summary>
        /// Move methods: moves the tetrimino down, left or right accordingly.
        /// </summary>
        public void moveDown(List<Square[]> boardSquares)
        {
            if (safeDown(boardSquares) == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    s[i].moveDown();
                }
            }
        }

        public void moveLeft()
        {
            for (int i = 0; i < 4; i++)
            {
                s[i].moveLeft();
            }
        }

        public void moveRight()
        {
            for (int i = 0; i < 4; i++)
            {
                s[i].moveRight();
            }
        }

        /// <summary>
        /// Safe methods: define whether the tetrimino can move left, right or down accordingly.
        /// </summary>
        public bool safeLeft(List<Square[]> boardSquares)
        {
            for (int i = 0; i < 4; i++)
            {
                if (s[i].X < 1)
                {
                    return false;
                }
                if (boardSquares[s[i].Y][s[i].X - 1] != null)
                {
                    return false;
                }
            }
            return true;
        }
        public bool safeRight(List<Square[]> boardSquares)
        {
            for (int i = 0; i < 4; i++)
            {
                if (s[i].X >= boardSquares[0].Length - 1)
                {
                    return false;
                }
                if (boardSquares[s[i].Y][s[i].X + 1] != null)
                {
                    return false;
                }

            }
            return true;
        }
        public bool safeDown(List<Square[]> boardSquares)
        {
            for (int i = 0; i < 4; i++)
            {
                if (s[i].Y >= boardSquares.Count - 1)
                {
                    return false;
                }
                if (boardSquares[s[i].Y + 1][s[i].X] != null)
                {
                    return false;
                }

            }
            return true;
        }

        /// <summary>
        /// Checks if there is enough space at the top of the board to add the new tetrimino.
        /// </summary>
        /// <returns></returns>
        public abstract bool canCreate();


        /// <summary>
        /// Method safe: uses the three safe-methods to define whether the tetrimino can be moved or rotated.
        /// </summary>
        public bool safe(List<Square[]> boardSquares)
        {
            return safeLeft(boardSquares) && safeRight(boardSquares) && safeDown(boardSquares);
        }

        /// <summary>
        /// Method rotate: rotates the tetrimino clockwise if possible.
        /// </summary>
        public abstract void rotate(List<Square[]> boardSquares);
    }


}
