using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisGame
{
    class TetriminoZ : Tetrimino
    {
        public TetriminoZ(): base(Color.LimeGreen)
        {
            s[1].X = X + 1;
            s[1].Y = Y;

            s[2].X = X + 1;
            s[2].Y = Y + 1;

            s[3].X = X + 2;
            s[3].Y = Y + 1;
        }
        
        public override void rotate(List<Square[]> boardSquares)
        {
            //state 1 -> state 2
            if (state == 1)
            {
                s[0].X += 2;

                s[1].X += 1;
                s[1].Y += 1;

                s[3].X -= 1;
                s[3].Y += 1;

                state = 2;
            }
            //state 2 -> state 3
            else if (state == 2)
            {
                s[0].Y += 2;

                s[1].X -= 1;
                s[1].Y += 1;

                s[3].X -= 1;
                s[3].Y -= 1;

                state = 3;
            }
            //state 3 -> state 4   
            else if (state == 3)
            {
                s[0].X -= 2;

                s[1].X -= 1;
                s[1].Y -= 1;

                s[3].X += 1;
                s[3].Y -= 1;

                state = 4;
            }

            //state 4 -> state 1
            else
            {
                s[0].Y -= 2;

                s[1].X += 1;
                s[1].Y -= 1;

                s[3].X += 1;
                s[3].Y += 1;

                state = 1;
            }
        }
    }
}
