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
            Y = -2;
            color = c;
            state = 1;

            s = new Square[4];
            for(int i=0; i<4; i++)
            {
                s[i] = new Square(c);
            }

            s[0].X = X;
            s[0].Y = Y;
        }

        public Tetrimino(Tetrimino t)
        {
            X = t.X;
            Y = t.Y;
            color = t.color;
            state = t.state;

            s = new Square[4];

            for (int i = 0; i < 4; i++)
            {
                s[i] = new Square(color);

                s[i].X = t.s[i].X;
                s[i].Y = t.s[i].Y;
            }

        }


        public void Draw(Graphics g, Point p)
        {
           for(int i=0; i<4; i++)
            {
                s[i].Draw(g, p);
            }
        }
        /// <summary>
        /// Checks if the Tetrimino is out of the board 
        /// </summary>
        /// <returns></returns>
        public bool isOut()
        {
            foreach(Square square in s)
            {
                if (square.Y < 0)
                    return true;
            }
            return false;
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

        public void moveLeft(List<Square[]> boardSquares)
        {
            if (safeLeft(boardSquares) == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    s[i].moveLeft();
                }
            }
        }

        public void moveRight(List<Square[]> boardSquares)
        {
            if (safeRight(boardSquares) == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    s[i].moveRight();
                }
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
                if (s[i].Y >= 0 && boardSquares[s[i].Y][s[i].X - 1] != null)
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
                if (s[i].Y >= 0 && boardSquares[s[i].Y][s[i].X + 1] != null)
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
                if (s[i].Y >= 0 && boardSquares[s[i].Y + 1][s[i].X] != null)
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
        public bool canCreate(List<Square[]> immovableSquares)
        {
            for (int i = 0; i < 4; i++)
            {
                if (!s[i].safe(immovableSquares)) return false;
            }
            return true;
        }


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
