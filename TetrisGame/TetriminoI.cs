using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisGame
{
    class TetriminoI : Tetrimino
    {
        public TetriminoI() : base(Color.Aqua)
        {
            s2.X = X;
            s2.Y = Y + 1;
            
            s3.X = X;
            s3.Y = Y + 2;

            s4.X = X;
            s4.Y = Y + 3;
        }

        public override void rotate()
        {
            //state 1 -> state 2
            if(state == 1)
            {
                X += 2;
                Y += 1;

                s1.X = X;
                s1.Y = Y;

                s2.X += 1;
                s3.Y -= 1;

                s4.Y -= 2;
                s4.X -= 1;

                state = 2;
            }

            //state 2 -> state 3

            if(state == 2)
            {
                X -= 1;
                Y += 2;

                s1.X = X;
                s1.Y = Y;

                s2.Y += 1;
                s3.X += 1;

                s4.X += 2;
                s4.Y -= 1;

                state = 3;
            }
            //state 3 -> state 4

            if(state == 3)
            {
                X -= 2;
                Y -= 1;

                s1.X = X;
                s1.Y = Y;

                s2.X -= 1;
                s3.Y += 1;

                s4.X += 1;
                s4.Y += 2;

                state = 4;
            }
            //state 4 -> state 1

            if(state == 4)
            {
                X += 1;
                Y -= 2;

                s1.X = X;
                s1.Y = Y;

                s2.Y -= 1;
                s3.X -= 1;

                s4.X -= 2;
                s4.Y += 1;

                state = 1;
            }
        }

        public override bool safeDown()
        {
            throw new NotImplementedException();
        }

        public override bool safeLeft()
        {
            if (X == 0) return false;
            return true;
        }

        public override bool safeRight()
        {
            if (X == 9) return false;
            return true;
        }
    }
}
