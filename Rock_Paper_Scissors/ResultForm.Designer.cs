namespace Rock_Paper_Scissors
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWiner = new System.Windows.Forms.Label();
            this.lblComputerWinTimes = new System.Windows.Forms.Label();
            this.lblPlayerWinTimes = new System.Windows.Forms.Label();
            this.lblDrawTimes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRundsNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Winner :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer Win Times :   ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player Win Times :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(12, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Draw Times  : ";
            // 
            // lblWiner
            // 
            this.lblWiner.AutoSize = true;
            this.lblWiner.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWiner.ForeColor = System.Drawing.Color.White;
            this.lblWiner.Location = new System.Drawing.Point(167, 85);
            this.lblWiner.Name = "lblWiner";
            this.lblWiner.Size = new System.Drawing.Size(43, 38);
            this.lblWiner.TabIndex = 4;
            this.lblWiner.Text = "l1";
            this.lblWiner.Click += new System.EventHandler(this.lblWiner_Click);
            // 
            // lblComputerWinTimes
            // 
            this.lblComputerWinTimes.AutoSize = true;
            this.lblComputerWinTimes.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWinTimes.ForeColor = System.Drawing.Color.White;
            this.lblComputerWinTimes.Location = new System.Drawing.Point(385, 150);
            this.lblComputerWinTimes.Name = "lblComputerWinTimes";
            this.lblComputerWinTimes.Size = new System.Drawing.Size(43, 38);
            this.lblComputerWinTimes.TabIndex = 5;
            this.lblComputerWinTimes.Text = "l2";
            this.lblComputerWinTimes.Click += new System.EventHandler(this.lblComputerWinTimes_Click);
            // 
            // lblPlayerWinTimes
            // 
            this.lblPlayerWinTimes.AutoSize = true;
            this.lblPlayerWinTimes.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinTimes.ForeColor = System.Drawing.Color.White;
            this.lblPlayerWinTimes.Location = new System.Drawing.Point(328, 215);
            this.lblPlayerWinTimes.Name = "lblPlayerWinTimes";
            this.lblPlayerWinTimes.Size = new System.Drawing.Size(43, 38);
            this.lblPlayerWinTimes.TabIndex = 6;
            this.lblPlayerWinTimes.Text = "l3";
            this.lblPlayerWinTimes.Click += new System.EventHandler(this.lblPlayerWinTimes_Click);
            // 
            // lblDrawTimes
            // 
            this.lblDrawTimes.AutoSize = true;
            this.lblDrawTimes.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawTimes.ForeColor = System.Drawing.Color.White;
            this.lblDrawTimes.Location = new System.Drawing.Point(257, 280);
            this.lblDrawTimes.Name = "lblDrawTimes";
            this.lblDrawTimes.Size = new System.Drawing.Size(43, 38);
            this.lblDrawTimes.TabIndex = 7;
            this.lblDrawTimes.Text = "l4";
            this.lblDrawTimes.Click += new System.EventHandler(this.lblDrawTimes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Result";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblRundsNum
            // 
            this.lblRundsNum.AutoSize = true;
            this.lblRundsNum.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRundsNum.ForeColor = System.Drawing.Color.White;
            this.lblRundsNum.Location = new System.Drawing.Point(179, 345);
            this.lblRundsNum.Name = "lblRundsNum";
            this.lblRundsNum.Size = new System.Drawing.Size(43, 38);
            this.lblRundsNum.TabIndex = 9;
            this.lblRundsNum.Text = "l5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(12, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rounds :";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(642, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRundsNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDrawTimes);
            this.Controls.Add(this.lblPlayerWinTimes);
            this.Controls.Add(this.lblComputerWinTimes);
            this.Controls.Add(this.lblWiner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWiner;
        private System.Windows.Forms.Label lblComputerWinTimes;
        private System.Windows.Forms.Label lblPlayerWinTimes;
        private System.Windows.Forms.Label lblDrawTimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRundsNum;
        private System.Windows.Forms.Label label6;
    }
}