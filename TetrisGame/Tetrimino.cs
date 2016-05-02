using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    public class Tetrimino
    {
        public Square s1 { get; set; }
        public Square s2 { get; set; }
        public Square s3 { get; set; }
        public Square s4 { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public Color color { get; set; }

        public Tetrimino(Point p, float x, float y)
        {
            X = x;
            Y = y;
            color = Color.PeachPuff;
        }

        public void Draw(Graphics g)
        {

        }

        public void moveDown()
        {
            
        }

        public void moveLeft()
        {
            
        }

        public void moveRight()
        {
            
        }
    }
}
