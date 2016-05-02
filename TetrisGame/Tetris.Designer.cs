﻿namespace TetrisGame
{
    partial class Tetris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris));
            this.MenuPanel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AboutPanel2 = new System.Windows.Forms.Panel();
            this.GamePanel3 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lbLevel = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.gbNextTetrimino = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AboutPanel2.SuspendLayout();
            this.GamePanel3.SuspendLayout();
            this.gbScore.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel1
            // 
            this.MenuPanel1.Controls.Add(this.btnExit);
            this.MenuPanel1.Controls.Add(this.btnAbout);
            this.MenuPanel1.Controls.Add(this.btnPlay);
            this.MenuPanel1.Controls.Add(this.pictureBox1);
            this.MenuPanel1.Location = new System.Drawing.Point(3, 6);
            this.MenuPanel1.Name = "MenuPanel1";
            this.MenuPanel1.Size = new System.Drawing.Size(429, 435);
            this.MenuPanel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::TetrisGame.Properties.Resources.ExitButton;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(123, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = global::TetrisGame.Properties.Resources.AboutButton;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.DimGray;
            this.btnAbout.Location = new System.Drawing.Point(123, 336);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(193, 41);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::TetrisGame.Properties.Resources.NewGameButton;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.DimGray;
            this.btnPlay.Location = new System.Drawing.Point(123, 289);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(193, 41);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TetrisGame.Properties.Resources.photo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AboutPanel2
            // 
            this.AboutPanel2.Controls.Add(this.pictureBox2);
            this.AboutPanel2.Controls.Add(this.btnBack);
            this.AboutPanel2.Location = new System.Drawing.Point(3, 6);
            this.AboutPanel2.Name = "AboutPanel2";
            this.AboutPanel2.Size = new System.Drawing.Size(429, 435);
            this.AboutPanel2.TabIndex = 3;
            // 
            // GamePanel3
            // 
            this.GamePanel3.Controls.Add(this.btnHelp);
            this.GamePanel3.Controls.Add(this.btnReplay);
            this.GamePanel3.Controls.Add(this.btnPause);
            this.GamePanel3.Controls.Add(this.btnMenu);
            this.GamePanel3.Controls.Add(this.lbLevel);
            this.GamePanel3.Controls.Add(this.btnQuit);
            this.GamePanel3.Controls.Add(this.gbScore);
            this.GamePanel3.Controls.Add(this.label3);
            this.GamePanel3.Controls.Add(this.label2);
            this.GamePanel3.Controls.Add(this.groupBox2);
            this.GamePanel3.Controls.Add(this.gbNextTetrimino);
            this.GamePanel3.Location = new System.Drawing.Point(3, 6);
            this.GamePanel3.Name = "GamePanel3";
            this.GamePanel3.Size = new System.Drawing.Size(429, 435);
            this.GamePanel3.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHelp.BackgroundImage = global::TetrisGame.Properties.Resources.buttonHelp;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.DimGray;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(310, 344);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(38, 41);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReplay.BackgroundImage = global::TetrisGame.Properties.Resources.buttonNewGame;
            this.btnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplay.FlatAppearance.BorderSize = 0;
            this.btnReplay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReplay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplay.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.ForeColor = System.Drawing.Color.DimGray;
            this.btnReplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplay.Location = new System.Drawing.Point(278, 390);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(38, 41);
            this.btnReplay.TabIndex = 13;
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPause.BackgroundImage = global::TetrisGame.Properties.Resources.buttonPause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.DimGray;
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPause.Location = new System.Drawing.Point(251, 344);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(38, 41);
            this.btnPause.TabIndex = 12;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMenu.BackgroundImage = global::TetrisGame.Properties.Resources.buttonMainMenu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(369, 344);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 41);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.lbLevel.ForeColor = System.Drawing.Color.DimGray;
            this.lbLevel.Location = new System.Drawing.Point(355, 221);
            this.lbLevel.MaximumSize = new System.Drawing.Size(50, 20);
            this.lbLevel.MinimumSize = new System.Drawing.Size(50, 20);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbLevel.Size = new System.Drawing.Size(50, 20);
            this.lbLevel.TabIndex = 10;
            this.lbLevel.Text = "1";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnQuit.BackgroundImage = global::TetrisGame.Properties.Resources.buttonQuit;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Location = new System.Drawing.Point(340, 390);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(38, 41);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // gbScore
            // 
            this.gbScore.Controls.Add(this.lbScore);
            this.gbScore.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.gbScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbScore.Location = new System.Drawing.Point(251, 277);
            this.gbScore.Name = "gbScore";
            this.gbScore.Size = new System.Drawing.Size(166, 50);
            this.gbScore.TabIndex = 8;
            this.gbScore.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.lbScore.ForeColor = System.Drawing.Color.DimGray;
            this.lbScore.Location = new System.Drawing.Point(10, 17);
            this.lbScore.MaximumSize = new System.Drawing.Size(150, 30);
            this.lbScore.MinimumSize = new System.Drawing.Size(150, 30);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(150, 30);
            this.lbScore.TabIndex = 0;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(293, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "SCORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(261, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Level:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTime);
            this.groupBox2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(251, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.lbTime.ForeColor = System.Drawing.Color.DimGray;
            this.lbTime.Location = new System.Drawing.Point(6, 31);
            this.lbTime.MaximumSize = new System.Drawing.Size(150, 30);
            this.lbTime.MinimumSize = new System.Drawing.Size(150, 30);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(150, 30);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbNextTetrimino
            // 
            this.gbNextTetrimino.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.gbNextTetrimino.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbNextTetrimino.Location = new System.Drawing.Point(251, 6);
            this.gbNextTetrimino.Name = "gbNextTetrimino";
            this.gbNextTetrimino.Size = new System.Drawing.Size(166, 112);
            this.gbNextTetrimino.TabIndex = 4;
            this.gbNextTetrimino.TabStop = false;
            this.gbNextTetrimino.Text = "Next ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TetrisGame.Properties.Resources.about;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(423, 403);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::TetrisGame.Properties.Resources.backButton;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DimGray;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(9, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(438, 449);
            this.Controls.Add(this.GamePanel3);
            this.Controls.Add(this.AboutPanel2);
            this.Controls.Add(this.MenuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tetris";
            this.Text = "Tetris";
            this.MenuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AboutPanel2.ResumeLayout(false);
            this.GamePanel3.ResumeLayout(false);
            this.GamePanel3.PerformLayout();
            this.gbScore.ResumeLayout(false);
            this.gbScore.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel AboutPanel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel GamePanel3;
        private System.Windows.Forms.GroupBox gbNextTetrimino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbScore;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnHelp;
    }
}

