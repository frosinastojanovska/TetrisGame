using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisGame
{

    /// <summary>
    /// Class TetriminoO: represents the square shaped Tetrimino, implements all the abstract methods from Tetrimino class
    /// </summary>
    class TetriminoO : Tetrimino
    {
        public TetriminoO() : base(Color.Yellow)
        {
            s2.X = X + 1;
            s2.Y = Y;

            s3.X = X;
            s3.Y = Y + 1;

            s4.X = X + 1;
            s4.Y = Y + 1;
        }

        public override void rotate()
        {
            
        }

        public override bool safeDown()
        {
            //immovableSquares
            //  if (Tetris.TetrisBox.board.immovableSquares)
            throw new NotImplementedException();
        }

        public override bool safeLeft()
        {
            if (X == 0) return false;
            return true;
        }

        public override bool safeRight()
        {
            if (s2.X == 9) return false;
            return true;
        }
    }
}
