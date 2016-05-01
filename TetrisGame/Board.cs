using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    public class Board
    {
        public int Rows;
        public int Columns;
        public int SquareSize;
        public Color backgroundColor;
        public Point Location;
        public Tetrimino currentTetrimino;
        public Tetrimino nextTetrimino;
        public List<Square[]> immovableSquares;

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

        public void Draw(Brush brush, Pen pen, Graphics g)
        {
            g.FillRectangle(brush, this.Location.X, this.Location.Y, this.Columns*this.SquareSize, this.Rows*this.SquareSize);
            g.DrawRectangle(pen, this.Location.X, this.Location.Y, this.Columns * this.SquareSize, this.Rows * this.SquareSize);
        }
    }
}
