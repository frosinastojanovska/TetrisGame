using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    public class Square
    {
        public readonly float size = 20;
        public int X { get; set; }
        public int Y { get; set; }
        public Color color { get; set; }
        public bool canMove { get; set; }

        public Square(Color c)
        {
            canMove = true;
            color = c;
        }

        public Square(int x, int y, Color c)
        {
            X = x;
            Y = y;
            color = c;
            canMove = true;
        }

        /// <summary>
        /// Checks whether a square is taken, if it is it is unsafe and a now tetrimino cannot occupy it.
        /// </summary>
        /// <returns></returns>
        public bool safe(List<Square[]> boardSquares)
        {
            if (boardSquares.ElementAt(0)[4] == null) return true;
            return false;
        }

        public void Draw(Graphics g, Point location)
        {
            if (Y >= 0)
            {
                g.FillRectangle(new SolidBrush(color), location.X + X * size, location.Y + Y * size, size, size);
                g.DrawRectangle(new Pen(Color.Gray, 2), location.X + X * size, location.Y + Y * size, size, size);
            }
        }

        public void moveDown()
        {
            Y++;
        }

        public void moveLeft()
        {
            X--;
        }

        public void moveRight()
        {
            X++;
        }
    }
}
