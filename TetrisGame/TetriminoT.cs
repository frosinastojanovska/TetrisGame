using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    public class TetriminoT : Tetrimino
    {
        private int state { get; set; }

        public TetriminoT(Point p) : base(Color.PeachPuff)
        {
            s1 = new Square(X, Y, color, p);
            s2 = new Square(X + 1, Y, color, p);
            s3 = new Square(X + 2, Y, color, p);
            s4 = new Square(X + 1, Y + 1, color, p);
            state = 1;
        }

        public override bool safeDown()
        {
            return true;
        }

        public override bool safeRight()
        {
            return true;
        }

        public override bool safeLeft()
        {
            return true;
        }

        public override void rotate()
        {
            if (state == 1)
            {
                s1.X += 2;
                s2.X += 1;
                s2.Y += 1;
                s3.Y += 2;
                state = 2;
            }
            else if (state == 2)
            {
                s1.Y += 2;
                s2.X -= 1;
                s2.Y += 1;
                s3.X -= 2;
                state = 3;
            }
            else if (state == 3)
            {
                s1.X -= 1;
                s2.Y -= 1;
                s3.X += 1;
                s3.Y -= 2;
                s4.X += 1;
                state = 4;
            }
            else
            {
                s1.X -= 1;
                s1.Y -= 2;
                s2.Y -= 1;
                s3.X += 1;
                s4.X -= 1;
                state = 1;
            }
        }
    }
}
