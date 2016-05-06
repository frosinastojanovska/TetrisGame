using System;
using System.Windows.Forms;

namespace TetrisGame
{
    /// <summary>
    /// The form of the Tetris game.
    /// </summary>
    public partial class Tetris : Form
    {
        private TetrisBox box;  // control for the game
        private Timer timer;  // timer that helps calculate the time that the game is played
        private int time;  // the time that the game is played
        private DialogBox dialog;  // dialog box
        /// <summary>
        /// Initializes a new instance of the Tetris class.
        /// </summary>
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
        /// <summary>
        /// Sets tooltips to buttons.
        /// </summary>
        private void initializeTooltip()
        {
            toolTip.SetToolTip(btnPause, "Pause/Play");
            toolTip.SetToolTip(btnMenu, "MainMenu");
            toolTip.SetToolTip(btnQuit, "Quit/Exit");
            toolTip.SetToolTip(btnReplay, "New Game");
            toolTip.SetToolTip(btnHelp, "Help");
        }
        /// <summary>
        /// It is used to switch the view panel in the form.
        /// </summary>
        /// <param name="view"></param>
        private void changeView(string view)
        {
            if(view == "menu")
            {
                MenuPanel1.Visible = true;
                AboutPanel2.Visible = false;
                GamePanel3.Visible = false;
            }
            else if (view == "about")
            {
                MenuPanel1.Visible = false;
                AboutPanel2.Visible = true;
                GamePanel3.Visible = false;
            }
            else if (view == "game"){
                MenuPanel1.Visible = false;
                AboutPanel2.Visible = false;
                GamePanel3.Visible = true;
            }
        }
        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Returns from the About view to the view that was previous shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (box.paused)
                changeView("game");
            else
                changeView("menu");
        }
        /// <summary>
        ///  Occurs when the timer interval has elapsed and the timer is enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            updateTime();
            box.move(Direction.Down);
        }
        /// <summary>
        /// Updates the time of the game.
        /// </summary>
        private void updateTime()
        {
            time = time + 1;
            int seconds = time % 60;
            int minutes = time / 60;
            lbTime.Text = String.Format("{0:00}:{1:00}", minutes, seconds);
        }
        /// <summary>
        /// Shows the About view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            changeView("about");
        }
        /// <summary>
        /// Starts the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            changeView("game");
            timer.Start();
            box.startGame();
        }
        /// <summary>
        /// Pauses the game.
        /// </summary>
        private void pauseGame()
        {
            btnPause.BackgroundImage = TetrisGame.Properties.Resources.buttonPlay;
            timer.Stop();
            box.pauseGame();
        }
        /// <summary>
        /// Resumes the game.
        /// </summary>
        private void resumeGame()
        {
            btnPause.BackgroundImage = TetrisGame.Properties.Resources.buttonPause;
            timer.Start();
            box.continueGame();
        }
        /// <summary>
        /// Pauses or resumes the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (box.playing)
            {
                pauseGame();
            }
            else   if (box.paused)
            {
                resumeGame();
            }
        }
        /// <summary>
        /// Quits the game and closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            pauseGame();
            dialog = new DialogBox("Quit the game and exit the application?");
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                Close();
            else
                resumeGame();
        }
        /// <summary>
        /// Ends the game and shows the MainMenu view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            pauseGame();
            dialog = new DialogBox("Go to Main Menu and quit the game?");
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                changeView("menu");
                btnPause.BackgroundImage = TetrisGame.Properties.Resources.buttonPause;
                time = -1;
                updateTime();
                timer.Stop();
                box.endGame();
            }
            else
                resumeGame();
        }
        /// <summary>
        /// Shows the Help/About view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            pauseGame();
            changeView("about");
        }
        /// <summary>
        /// Starts a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplay_Click(object sender, EventArgs e)
        {
            time = -1;
            updateTime();
            box.endGame();
            box.startGame();
        }

        private void Tetris_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Right)
            {
                box.move(Direction.Right);
            }
            else if (e.KeyCode == Keys.Left)
            {
                box.move(Direction.Left);
            }
            else if (e.KeyCode == Keys.Up)
            {
                //rotate
            }
            else
            {
                //speed up
            }
            Invalidate();*/
        }
    }


}
