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
        public float X { get; set; }
        public float Y { get; set; }
        public Color color { get; set; }
        public bool canMove { get; set; }
        public Point location { get; set; }

        public Square(float x, float y, Color c, Point l)
        {
            X = x;
            Y = y;
            color = c;
            canMove = true;
            location = l;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(color), location.X + X * size, location.Y + Y * size, size, size);
            g.DrawRectangle(new Pen(Color.RosyBrown), location.X + X * size, location.Y + Y * size, size, size);
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
