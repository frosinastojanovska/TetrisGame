using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisGame
{
    class TetriminoS : Tetrimino
    {
        public TetriminoS() : base(Color.Red)
        {   
            s[1].X = X + 1;
            s[1].Y = Y;

            s[2].X = X - 1;
            s[2].Y = Y + 1;

            s[3].X = X;
            s[3].Y = Y + 1;

        }

        public override bool canCreate()
        {
            throw new NotImplementedException();
        }

        public override void rotate(List<Square[]> boardSquares)
        {
            throw new NotImplementedException();
        }
    }
}
