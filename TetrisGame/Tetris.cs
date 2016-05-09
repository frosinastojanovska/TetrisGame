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
        private DialogBox dialog;  // dialog box
        private static readonly System.Media.SoundPlayer AUDIO = new System.Media.SoundPlayer(TetrisGame.Properties.Resources.moveSound);
        private bool sound;
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
            box.Controls.Add(this.gbTime);
            this.GamePanel3.Controls.Add(box);
            initializeTooltip();
            sound = true;
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
            toolTip.SetToolTip(btnSound, "Sound Off/On");
        }
        /// <summary>
        /// It is used to switch the view panel in the form.
        /// </summary>
        /// <param name="view"></param>
        private void changeView(string view)
        {
            if (view == "menu")
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
            else if (view == "game")
            {
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
            box.startGame();
        }
        /// <summary>
        /// Pauses the game.
        /// </summary>
        private void pauseGame()
        {
            btnPause.BackgroundImage = TetrisGame.Properties.Resources.buttonPlay;
            box.pauseGame();
        }
        /// <summary>
        /// Resumes the game.
        /// </summary>
        private void resumeGame()
        {
            btnPause.BackgroundImage = TetrisGame.Properties.Resources.buttonPause;
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
            else if (box.paused)
            {
                resumeGame();
            }
            this.ActiveControl = null;
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

            this.ActiveControl = null;
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
                box.endGame();
            }
            else
                resumeGame();

            this.ActiveControl = null;
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
            this.ActiveControl = null;
        }
        /// <summary>
        /// Starts a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplay_Click(object sender, EventArgs e)
        {
            box.endGame();
            box.startGame();
            this.ActiveControl = null;
        }
        /// <summary>
        /// Turns off or turn on the sound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSound_Click(object sender, EventArgs e)
        {
            if (sound)
            {
                btnSound.BackgroundImage = Properties.Resources.soundOffButton;
                sound = false;
            }
            else 
            {
                btnSound.BackgroundImage = Properties.Resources.soundOnButton;
                sound = true;
            }
            this.ActiveControl = null;
        }
        /// <summary>
        /// Plays sound.
        /// </summary>
        private void playSound()
        {
            if (sound)
            {
                AUDIO.Stop();
                AUDIO.Play();
            }
        }

        private void Tetris_KeyDown(object sender, KeyEventArgs e)
        {
            if (box.playing)
            {
                if (e.KeyCode == Keys.Right)
                {
                    playSound();
                    box.move(Direction.Right);
                }
                else if (e.KeyCode == Keys.Left)
                {
                    playSound();
                    box.move(Direction.Left);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    playSound();
                    box.rotate();
                }
                else if (e.KeyCode == Keys.Down)
                {
                    //playSound();
                    box.move(Direction.Down);
                }
            }
        }
    }
}
