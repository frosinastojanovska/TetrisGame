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
            s[1].X = X + 1;
            s[1].Y = Y;

            s[2].X = X;
            s[2].Y = Y + 1;

            s[3].X = X + 1;
            s[3].Y = Y + 1;
        }

        public override bool canCreate()
        {
            throw new NotImplementedException();
        }

        public override void rotate(List<Square[]> boardSquares)
        {
            
        }

        public override bool safeDown(List<Square[]> boardSquares)
        {
            //immovableSquares
            //  if (Tetris.TetrisBox.board.immovableSquares)
            throw new NotImplementedException();
        }

        public override bool safeLeft(List<Square[]> boardSquares)
        {
            if (X == 0) return false;
            return true;
        }

        public override bool safeRight(List<Square[]> boardSquares)
        {
            if (s[1].X == 9) return false;
            return true;
        }
    }
}
