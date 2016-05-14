using System;
using System.Collections.Generic;
using System.Drawing;

namespace TetrisGame
{

    /// <summary>
    /// A class that represents the tetrimino O in the tetris game.
    /// </summary>
    class TetriminoO : Tetrimino
    {
        /// <summary>
        ///  Initializes a new instance of the TetriminoO class.
        /// </summary>
        public TetriminoO() : base(Color.Yellow, TetrisGame.Properties.Resources.TetriminoO)
        {
            s[0].X = X;
            s[0].Y = Y - 2;

            s[1].X = X + 1;
            s[1].Y = Y - 2;

            s[2].X = X;
            s[2].Y = Y - 1;

            s[3].X = X + 1;
            s[3].Y = Y - 1;
        }
        
        public override void rotate()
        {
            //this tetrimino does not rotate
        }

        public override void tryRotate(List<Square[]> immovableSquares)
        {
            //this tetrimino does not rotate
        }
    }
}
