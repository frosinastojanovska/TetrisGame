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
        public readonly float width = 20;
        public readonly float height = 20;
        public float X { get; set; }
        public float Y { get; set; }
        public Color color { get; set; }
        public bool canMove { get; set; }

        public Square(float x, float y, Color c)
        {
            X = x;
            Y = y;
            color = c;
            canMove = true;
        }
    }
}
