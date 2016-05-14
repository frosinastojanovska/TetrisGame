using System.Collections.Generic;
using System.Drawing;

namespace TetrisGame
{
    /// <summary>
    /// A class that represents the tetrimino L in the tetris game.
    /// </summary>
    public class TetriminoL : Tetrimino
    {
        /// <summary>
        ///  Initializes a new instance of the TetriminoL class.
        /// </summary>
        public TetriminoL() : base(Color.LimeGreen, TetrisGame.Properties.Resources.TetriminoL)
        {
            s[0].X = X;
            s[0].Y = Y - 3;

            s[1].X = X;
            s[1].Y = Y - 2;

            s[2].X = X;
            s[2].Y = Y - 1;

            s[3].X = X + 1;
            s[3].Y = Y - 1;
        }
        /// <summary>
        /// Rotates the tetrimino.
        /// </summary>
        /// <param name="boardSquares"></param>
        public override void rotate(List<Square[]> boardSquares)
        {
            //state 1 -> state 2
            if (state == 1)
            {
                s[0].X += 1;
                s[0].Y += 1;

                s[2].X -= 1;
                s[2].Y -= 1;

                s[3].X -= 2;

                state = 2;
            }
            //state 2 -> state 3
            else if (state == 2)
            {
                s[0].X -= 1;
                s[0].Y += 1;

                s[2].X += 1;
                s[2].Y -= 1;

                s[3].Y -= 2;

                state = 3;
            }
            //state 3 -> state 4
            else if (state == 3)
            {
                s[0].X -= 1;
                s[0].Y -= 1;

                s[2].X += 1;
                s[2].Y += 1;

                s[3].X += 2;

                state = 4;
            }
            //state 4 -> state 1
            else
            {
                s[0].X += 1;
                s[0].Y -= 1;

                s[2].X -= 1;
                s[2].Y += 1;

                s[3].Y += 2;

                state = 1;
            }
        }
    }
}
