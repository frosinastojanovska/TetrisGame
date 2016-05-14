using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TetrisGame
{
    /// <summary>
    /// An abstract class that holds an abstract representation of the Tetrimino (the building shape of the game).
    /// </summary>
    public abstract class Tetrimino
    {
        public Square[] s;  // the squares of the tetrimino
        public int X { get; set; }  // x coordinate of the position
        public int Y { get; set; }  // y coordinate of the position
        public int state { get; set; }  // current state of the tetrimino
        public Image tetriminoImage { get; set; }  // the image of the tetrimino

        /// <summary>
        /// Helps in creating a new instance of a class that inherits from Tetrimino class.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="image"></param>
        public Tetrimino(Color c, Image image)
        {
            X = 3;
            Y = 0;
            state = 1;
            tetriminoImage = image;
            s = new Square[4];
            for(int i=0; i<4; i++)
            {
                s[i] = new Square(c);
            }
        }

        /// <summary>
        /// Draws the tetrimino
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        public void Draw(Graphics g, Point p)
        {
           for(int i=0; i<4; i++)
            {
                s[i].Draw(g, p);
            }
        }

        /// <summary>
        /// Checks if the Tetrimino is out of the top border of the board 
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
        /// Moves the tetrimino down.
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

        /// <summary>
        /// Moves the tetrimino left.
        /// </summary>
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

        /// <summary>
        /// Moves the tetrimino right.
        /// </summary>
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
        /// Safe method - define whether the tetrimino can move left.
        /// </summary>
        public bool safeLeft(List<Square[]> boardSquares)
        {
            for (int i = 0; i < 4; i++)
            {
                if (s[i].X < 1 || s[i].X > 9)
                {
                    return false;
                }
                if (s[i].Y >= 0 && s[i].Y < boardSquares.Count() && boardSquares[s[i].Y][s[i].X - 1] != null)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Safe method - define whether the tetrimino can move right.
        /// </summary>
        public bool safeRight(List<Square[]> boardSquares)
        {
            for (int i = 0; i < 4; i++)
            {
                if (s[i].X >= boardSquares[0].Length - 1)
                {
                    return false;
                }
                if (s[i].Y >= 0 && s[i].Y < boardSquares.Count() && boardSquares[s[i].Y][s[i].X + 1] != null)
                {
                    return false;
                }

            }
            return true;
        }

        /// <summary>
        /// Safe method - define whether the tetrimino can move down.
        /// </summary>
        public bool safeDown(List<Square[]> boardSquares)
        {
            for (int i = 0; i < 4; i++)
            {
                if (s[i].Y >= boardSquares.Count - 1)
                {
                    return false;
                }
                if (s[i].Y >= 0 && s[i].Y < boardSquares.Count() && boardSquares[s[i].Y + 1][s[i].X] != null)
                {
                    return false;
                }
                if (s[i].Y == -1 && boardSquares[0][s[i].X] != null)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if the tetrimino is inside the board limits and doesn't innterupt some immovable square
        /// </summary>
        public bool safe(List<Square[]> boardSquares)
        {
            for (int i = 0; i < 4; i++)
            {
                if (s[i].X < 0 || s[i].X >= boardSquares[0].Length || s[i].Y >= boardSquares.Count())
                {
                    return false;
                }
                if (s[i].Y >=0 && boardSquares[s[i].Y][s[i].X] != null)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Method rotate: rotates the tetrimino.
        /// </summary>
        public abstract void rotate();

        /// <summary>
        /// Method tryRotate: tries to rotate the tetrimino clockwise if possible.
        /// </summary>
        public abstract void tryRotate(List<Square[]> immovableSquares);
    }  
}
