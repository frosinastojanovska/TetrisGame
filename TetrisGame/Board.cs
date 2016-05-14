using System.Collections.Generic;
using System.Drawing;

namespace TetrisGame
{
    /// <summary>
    /// A class that represents the game board. Many of the game logic is implemented here.
    /// </summary>
    public class Board
    {
        public int Rows;  // number of rows
        public int Columns;  // number of columns
        public int SquareSize;  // size of the squares
        public Color backgroundColor;  // background color of the board
        public Point Location;  // location of the board
        public List<Square[]> immovableSquares;  // container of immovable squares

        /// <summary>
        /// Initializes a new instance of the Board class with the specific parameters.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="squareSize"></param>
        /// <param name="color"></param>
        /// <param name="location"></param>
        public Board(int rows, int columns, int squareSize, Color color, Point location)
        {
            this.Columns = columns;
            this.Rows = rows;
            this.SquareSize = squareSize;
            this.backgroundColor = color;
            this.Location = location;
            immovableSquares = new List<Square[]>();
            for (int i = 0; i < Rows; i++)
            {
                Square[] col = new Square[Columns];
                immovableSquares.Add(col);
            }
        }

        /// <summary>
        /// Method for adding squares of the tetrimino to the board
        /// </summary>
        /// <param name="t"></param>
        public void addSquares(Tetrimino t)
        {
            foreach(Square s in t.s)
            {
                immovableSquares[s.Y][s.X] = s;
            }
        }
        
        /// <summary>
        /// Draws the board.
        /// </summary>
        /// <param name="brush"></param>
        /// <param name="pen"></param>
        /// <param name="g"></param>
        public void Draw(Brush brush, Pen pen, Graphics g)
        {
            g.FillRectangle(brush, this.Location.X, this.Location.Y, this.Columns * this.SquareSize, this.Rows * this.SquareSize);
            g.DrawRectangle(pen, this.Location.X, this.Location.Y, this.Columns * this.SquareSize, this.Rows * this.SquareSize);
            drawSquares(g);
        }

        /// <summary>
        /// Draws the immovable tetriminoes of the board
        /// </summary>
        /// <param name="g"></param>
        public void drawSquares(Graphics g)
        {
            int j = 0;
            foreach (Square[] square in immovableSquares)
            {
                for (int i = 0; i < square.Length; i++)
                {
                    if (square[i] != null)
                    {
                        if (square[i].Y != j) // update row number after deleting rows
                        {
                            square[i].Y = j;
                        }
                        square[i].Draw(g, this.Location);
                    }
                }
                j++;
            }
        }
    }
}
