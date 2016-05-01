using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class Tetris : Form
    {
        public TetrisBox box;
        public Tetris()
        {
            InitializeComponent();
            DoubleBuffered = true;
            changeView(1);
            box = new TetrisBox(GamePanel3.Location, GamePanel3.Width, GamePanel3.Width);
            this.GamePanel3.Controls.Add(box);
        }

        private void changeView(int n)
        {
            if(n == 1)
            {
                MenuPanel1.Visible = true;
                AboutPanel2.Visible = false;
                GamePanel3.Visible = false;
            }
            else if (n == 2)
            {
                MenuPanel1.Visible = false;
                AboutPanel2.Visible = true;
                GamePanel3.Visible = false;
            }
            else if (n == 3){
                MenuPanel1.Visible = false;
                AboutPanel2.Visible = false;
                GamePanel3.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            changeView(1);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            changeView(2);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            changeView(3);
        }
    }


}
