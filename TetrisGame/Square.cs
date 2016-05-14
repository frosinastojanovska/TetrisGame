using System.Drawing;

namespace TetrisGame
{
    /// <summary>
    /// A class that represents the squares in the tetris game.
    public class Square
    {
        public readonly float size = 20;
        public int X { get; set; }
        public int Y { get; set; }
        public Color color { get; set; }
        public static Color borderColor = Color.Gray;
        
        /// <summary>
        /// Initializes a new instance of the Square class with the specific color.
        /// </summary>
        /// <param name="c"></param>
        public Square(Color c)
        {
            color = c;
        }
        
        /// <summary>
        ///  Draws the square.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="location"></param>
        public void Draw(Graphics g, Point location)
        {
            if (Y >= 0)
            {
                g.FillRectangle(new SolidBrush(color), location.X + X * size, location.Y + Y * size, size, size);
                g.DrawRectangle(new Pen(borderColor, 2), location.X + X * size, location.Y + Y * size, size, size);
            }
        }

        /// <summary>
        /// Moves the square down.
        /// </summary>
        public void moveDown()
        {
            Y++;
        }

        /// <summary>
        /// Moves the square left.
        /// </summary>
        public void moveLeft()
        {
            X--;
        }

        /// <summary>
        /// moves the square right.
        /// </summary>
        public void moveRight()
        {
            X++;
        }
    }
}
