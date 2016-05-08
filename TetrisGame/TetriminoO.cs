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
        
        public override void rotate(List<Square[]> boardSquares)
        {
            //this tetrimino does not rotate
        }
    }
}
