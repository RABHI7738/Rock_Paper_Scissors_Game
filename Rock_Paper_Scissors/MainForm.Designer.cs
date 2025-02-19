namespace Rock_Paper_Scissors
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label6 = new System.Windows.Forms.Label();
            this.lblRoundsNumber = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblComputerWinTimes = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblPlayerWinTimes = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ptrbxComputerChoice = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptrbxYourChoice = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRoundsCounter = new System.Windows.Forms.Label();
            this.btnRestartGame = new Guna.UI2.WinForms.Guna2Button();
            this.btnStartGame = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptrbxRock = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxComputerChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxYourChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(483, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 38);
            this.label6.TabIndex = 40;
            // 
            // lblRoundsNumber
            // 
            this.lblRoundsNumber.AutoSize = true;
            this.lblRoundsNumber.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundsNumber.ForeColor = System.Drawing.Color.White;
            this.lblRoundsNumber.Location = new System.Drawing.Point(982, 149);
            this.lblRoundsNumber.Name = "lblRoundsNumber";
            this.lblRoundsNumber.Size = new System.Drawing.Size(156, 38);
            this.lblRoundsNumber.TabIndex = 35;
            this.lblRoundsNumber.Text = "0 Rounds";
            this.lblRoundsNumber.Click += new System.EventHandler(this.lblRoundsNumber_Click_1);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SkyBlue;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(989, 232);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(182, 285);
            this.panel9.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Computer";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.lblComputerWinTimes);
            this.panel10.Location = new System.Drawing.Point(48, 128);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(98, 76);
            this.panel10.TabIndex = 14;
            // 
            // lblComputerWinTimes
            // 
            this.lblComputerWinTimes.AutoSize = true;
            this.lblComputerWinTimes.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWinTimes.Location = new System.Drawing.Point(32, 19);
            this.lblComputerWinTimes.Name = "lblComputerWinTimes";
            this.lblComputerWinTimes.Size = new System.Drawing.Size(35, 38);
            this.lblComputerWinTimes.TabIndex = 1;
            this.lblComputerWinTimes.Text = "0";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SkyBlue;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Location = new System.Drawing.Point(58, 232);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(182, 285);
            this.panel8.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "You";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.lblPlayerWinTimes);
            this.panel11.Location = new System.Drawing.Point(46, 128);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(98, 76);
            this.panel11.TabIndex = 15;
            // 
            // lblPlayerWinTimes
            // 
            this.lblPlayerWinTimes.AutoSize = true;
            this.lblPlayerWinTimes.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinTimes.Location = new System.Drawing.Point(32, 19);
            this.lblPlayerWinTimes.Name = "lblPlayerWinTimes";
            this.lblPlayerWinTimes.Size = new System.Drawing.Size(35, 38);
            this.lblPlayerWinTimes.TabIndex = 0;
            this.lblPlayerWinTimes.Text = "0";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SkyBlue;
            this.panel7.Controls.Add(this.ptrbxComputerChoice);
            this.panel7.Controls.Add(this.ptrbxYourChoice);
            this.panel7.Location = new System.Drawing.Point(246, 232);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(737, 285);
            this.panel7.TabIndex = 29;
            // 
            // ptrbxComputerChoice
            // 
            this.ptrbxComputerChoice.BorderRadius = 10;
            this.ptrbxComputerChoice.FillColor = System.Drawing.Color.Black;
            this.ptrbxComputerChoice.ImageRotate = 0F;
            this.ptrbxComputerChoice.Location = new System.Drawing.Point(472, 69);
            this.ptrbxComputerChoice.Name = "ptrbxComputerChoice";
            this.ptrbxComputerChoice.Size = new System.Drawing.Size(223, 157);
            this.ptrbxComputerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbxComputerChoice.TabIndex = 49;
            this.ptrbxComputerChoice.TabStop = false;
            // 
            // ptrbxYourChoice
            // 
            this.ptrbxYourChoice.BorderRadius = 10;
            this.ptrbxYourChoice.FillColor = System.Drawing.Color.Black;
            this.ptrbxYourChoice.ImageRotate = 0F;
            this.ptrbxYourChoice.Location = new System.Drawing.Point(56, 69);
            this.ptrbxYourChoice.Name = "ptrbxYourChoice";
            this.ptrbxYourChoice.Size = new System.Drawing.Size(223, 157);
            this.ptrbxYourChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbxYourChoice.TabIndex = 48;
            this.ptrbxYourChoice.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(815, 649);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 23);
            this.panel6.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(12, 649);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(397, 23);
            this.panel5.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(12, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 23);
            this.panel4.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(815, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 23);
            this.panel3.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 573);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1183, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 573);
            this.panel1.TabIndex = 23;
            // 
            // lblRoundsCounter
            // 
            this.lblRoundsCounter.AutoSize = true;
            this.lblRoundsCounter.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundsCounter.ForeColor = System.Drawing.Color.White;
            this.lblRoundsCounter.Location = new System.Drawing.Point(541, 80);
            this.lblRoundsCounter.Name = "lblRoundsCounter";
            this.lblRoundsCounter.Size = new System.Drawing.Size(0, 38);
            this.lblRoundsCounter.TabIndex = 41;
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Animated = true;
            this.btnRestartGame.BorderRadius = 8;
            this.btnRestartGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestartGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestartGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestartGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestartGame.FillColor = System.Drawing.Color.ForestGreen;
            this.btnRestartGame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(91, 551);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(207, 48);
            this.btnRestartGame.TabIndex = 42;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click_1);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Animated = true;
            this.btnStartGame.BorderRadius = 8;
            this.btnStartGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartGame.FillColor = System.Drawing.Color.ForestGreen;
            this.btnStartGame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(91, 149);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(207, 48);
            this.btnStartGame.TabIndex = 43;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(989, 580);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(182, 48);
            this.guna2Button1.TabIndex = 47;
            this.guna2Button1.Text = "Result";
            this.guna2Button1.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(113, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Rock Paper Scissors";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 20;
            this.guna2PictureBox2.Image = global::Rock_Paper_Scissors.Properties.Resources.Scissors;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(680, 600);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(102, 80);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 46;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Tag = "3";
            this.guna2PictureBox2.Click += new System.EventHandler(this.ptrbxChoice);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.Image = global::Rock_Paper_Scissors.Properties.Resources.Paper;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(561, 600);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(102, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 45;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Tag = "2";
            this.guna2PictureBox1.Click += new System.EventHandler(this.ptrbxChoice);
            // 
            // ptrbxRock
            // 
            this.ptrbxRock.BorderRadius = 20;
            this.ptrbxRock.Image = global::Rock_Paper_Scissors.Properties.Resources.Rock;
            this.ptrbxRock.ImageRotate = 0F;
            this.ptrbxRock.Location = new System.Drawing.Point(442, 600);
            this.ptrbxRock.Name = "ptrbxRock";
            this.ptrbxRock.Size = new System.Drawing.Size(102, 80);
            this.ptrbxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbxRock.TabIndex = 44;
            this.ptrbxRock.TabStop = false;
            this.ptrbxRock.Tag = "1";
            this.ptrbxRock.Click += new System.EventHandler(this.ptrbxChoice);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = global::Rock_Paper_Scissors.Properties.Resources._4781838_cancel_close_delete_exit_logout_icon;
            this.pictureBox7.Location = new System.Drawing.Point(1183, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(44, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 39;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 706);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ptrbxRock);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblRoundsCounter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblRoundsNumber);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxComputerChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxYourChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblRoundsNumber;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblComputerWinTimes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblPlayerWinTimes;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRoundsCounter;
        private Guna.UI2.WinForms.Guna2Button btnRestartGame;
        private Guna.UI2.WinForms.Guna2Button btnStartGame;
        private Guna.UI2.WinForms.Guna2PictureBox ptrbxRock;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox ptrbxYourChoice;
        private Guna.UI2.WinForms.Guna2PictureBox ptrbxComputerChoice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

