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
        public TetriminoT() : base(Color.PeachPuff)
        {
            s[1].X = X + 1;
            s[1].Y = Y;

            s[2].X = X + 2;
            s[2].Y = Y;

            s[3].X = X + 1;
            s[3].Y = Y + 1;
        }

        public override bool safeDown(List<Square[]> boardSquares)
        {
            return true;
        }

        public override bool safeRight(List<Square[]> boardSquares)
        {
            return true;
        }

        public override bool safeLeft(List<Square[]> boardSquares)
        {
            return true;
        }

        public override void rotate(List<Square[]> boardSquares)
        {
            if (state == 1)
            {
                s[0].X += 2;
                s[1].X += 1;
                s[1].Y += 1;
                s[2].Y += 2;
                state = 2;
            }
            else if (state == 2)
            {
                s[0].Y += 2;
                s[1].X -= 1;
                s[1].Y += 1;
                s[2].X -= 2;
                state = 3;
            }
            else if (state == 3)
            {
                s[0].X -= 1;
                s[1].Y -= 1;
                s[2].X += 1;
                s[2].Y -= 2;
                s[3].X += 1;
                state = 4;
            }
            else
            {
                s[0].X -= 1;
                s[0].Y -= 2;
                s[1].Y -= 1;
                s[2].X += 1;
                s[3].X -= 1;
                state = 1;
            }
        }

        public override bool canCreate()
        {
            throw new NotImplementedException();
        }
    }
}
