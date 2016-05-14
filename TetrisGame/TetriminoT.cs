using System;
using System.Collections.Generic;
using System.Drawing;

namespace TetrisGame
{
    /// <summary>
    /// A class that represents the tetrimino T in the tetris game.
    /// </summary>
    public class TetriminoT : Tetrimino
    {
        /// <summary>
        ///  Initializes a new instance of the TetriminoT class.
        /// </summary>
        public TetriminoT() : base(Color.PeachPuff, TetrisGame.Properties.Resources.TetriminoT)
        {
            s[0].X = X;
            s[0].Y = Y - 2;

            s[1].X = X + 1;
            s[1].Y = Y - 2;

            s[2].X = X + 2;
            s[2].Y = Y - 2;

            s[3].X = X + 1;
            s[3].Y = Y - 1;
        }
        /// <summary>
        /// Rotates the tetrimino.
        /// </summary>
        /// <param name="boardSquares"></param>
        public override void rotate()
        {
            //state 1 -> state 2
            if (state == 1)
            {
                s[0].X += 2;

                s[1].X += 1;
                s[1].Y += 1;

                s[2].Y += 2;

                state = 2;
            }
            //state 2 -> state 3
            else if (state == 2)
            {
                s[0].Y += 2;

                s[1].X -= 1;
                s[1].Y += 1;

                s[2].X -= 2;

                state = 3;
            }
            //state 3 -> state 4
            else if (state == 3)
            {
                s[0].X -= 1;

                s[1].Y -= 1;

                s[2].X += 1;
                s[2].Y -= 2;

                s[3].X += 1;

                state = 4;
            }
            //state 4 -> state 1
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

        /// <summary>
        /// Checks if it can rotate
        /// </summary>
        /// <param name="immovableSquares"></param>
        /// <returns></returns>
        public override void tryRotate(List<Square[]> immovableSquares)
        {
            Tetrimino t = new TetriminoT();
            for (int i = 0; i < 4; i++)
            {
                t.s[i].X = this.s[i].X;
                t.s[i].Y = this.s[i].Y;
            }
            t.state = this.state;
            t.rotate();
            if (t.safe(immovableSquares))
                this.rotate();
        }
    }
}
