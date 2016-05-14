using System;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class DialogBox : Form
    {
        /// <summary>
        /// Initializes a new instance of the DialogBox class with the specific message.
        /// </summary>
        /// <param name="message"></param>
        public DialogBox(String message)
        {
            InitializeComponent();
            this.lbMessage.Text = message;
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
        /// <summary>
        /// Sets the DialogResult and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = btnCancel.DialogResult;
            this.Close();
        }
    }
}
