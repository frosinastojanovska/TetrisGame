using System;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class HighScore : Form
    {
        /// <summary>
        /// Initializes a new instance of the HighScore class with the specific message.
        /// </summary>
        /// <param name="message"></param>
        public HighScore(long HighScore, long Score)
        {
            InitializeComponent();
            this.lbHighScore.Text = HighScore.ToString();
            this.lbScore.Text = Score.ToString();
        }

        /// <summary>
        /// Sets the DialogResult and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = btnOk.DialogResult;
            this.Close();
        }
    }
}
