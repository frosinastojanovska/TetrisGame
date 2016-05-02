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
        private TetrisBox box;
        private Timer timer;
        private int time;

        public Tetris()
        {
            InitializeComponent();
            DoubleBuffered = true;
            changeView("menu");
            box = new TetrisBox(GamePanel3.Location, GamePanel3.Width, GamePanel3.Width);
            box.Controls.Add(this.gbScore);
            box.Controls.Add(this.lbLevel);
            box.Controls.Add(this.gbNextTetrimino);
            this.GamePanel3.Controls.Add(box);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            time = 0;
            initializeTooltip();
        }

        private void initializeTooltip()
        {
            toolTip.SetToolTip(btnPause, "Pause/Play");
            toolTip.SetToolTip(btnMenu, "MainMenu");
            toolTip.SetToolTip(btnQuit, "Quit/Exit");
            toolTip.SetToolTip(btnReplay, "New Game");
            toolTip.SetToolTip(btnHelp, "Help");
        }

        private void changeView(string s)
        {
            if(s == "menu")
            {
                MenuPanel1.Visible = true;
                AboutPanel2.Visible = false;
                GamePanel3.Visible = false;
            }
            else if (s == "about")
            {
                MenuPanel1.Visible = false;
                AboutPanel2.Visible = true;
                GamePanel3.Visible = false;
            }
            else if (s == "game"){
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
            if (box.paused)
                changeView("game");
            else
                changeView("menu");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            updateTime();
        }

        private void updateTime()
        {
            time = time + 1;
            int seconds = time % 60;
            int minutes = time / 60;
            lbTime.Text = String.Format("{0:00}:{1:00}", minutes, seconds);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            changeView("about");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            changeView("game");
            timer.Start();
            box.startGame();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (box.playing)
            {
                btnPause.BackgroundImage = TetrisGame.Properties.Resources.buttonPlay;
                timer.Stop();
                box.pauseGame();
            }
            else   if (box.paused)
            {
                btnPause.BackgroundImage = TetrisGame.Properties.Resources.buttonPause;
                timer.Start();
                box.continueGame();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            changeView("menu");
            btnPause.BackgroundImage = TetrisGame.Properties.Resources.buttonPause;
            time = -1;
            updateTime();
            timer.Stop();
            box.endGame();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            btnPause.BackgroundImage = TetrisGame.Properties.Resources.buttonPlay;
            timer.Stop();
            box.pauseGame();
            changeView("about");
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            time = -1;
            updateTime();
            box.endGame();
            box.startGame();
        }
    }


}
