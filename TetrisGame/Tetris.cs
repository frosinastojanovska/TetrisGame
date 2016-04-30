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
        public Tetris()
        {
            InitializeComponent();
            DoubleBuffered = true;
            MenuPanel1.Visible = true;
            AboutPanel2.Visible = false;
            GamePanel3.Visible = false;
            TetrisBox box = new TetrisBox(GamePanel3.Location);
            GamePanel3.Controls.Add(box);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AboutPanel2.Visible = false;
            MenuPanel1.Visible = true;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MenuPanel1.Visible = false;
            AboutPanel2.Visible = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MenuPanel1.Visible = false;
            GamePanel3.Visible = true;
        }
    }


}
