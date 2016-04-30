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
        public int X;
        public int Y;
        public Tetrimino currentTetrimino;
        public Tetrimino nextTetrimino;
        public List<Square[]> immovableSquares;

        public Board(int rows, int columns, int squareSize, Color color, int x, int y)
        {
            this.Columns = columns;
            this.Rows = rows;
            this.SquareSize = squareSize;
            this.backgroundColor = color;
            this.X = x;
            this.Y = y;
            immovableSquares = new List<Square[]>();
            for (int i = 0; i < Rows; i++)
            {
                Square[] col = new Square[Columns];
                immovableSquares.Add(col);
            }
        }

        public void Draw(Brush brush, Graphics g)
        {
            g.FillRectangle(brush, this.X, this.Y, this.X*this.Columns, this.Y*this.Rows);
        }
    }
}
