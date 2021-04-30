namespace CIS153_FinalProject_GroupA
{
    partial class Stats
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
            this.lbl_gameStatsHeader = new System.Windows.Forms.Label();
            this.lbl_gamesPlayedTitle = new System.Windows.Forms.Label();
            this.lbl_gamesWonTitle = new System.Windows.Forms.Label();
            this.lbl_gamesTiedTitle = new System.Windows.Forms.Label();
            this.lbl_gamesRatioTitle = new System.Windows.Forms.Label();
            this.lbl_gamesPlayedDisplay = new System.Windows.Forms.Label();
            this.lbl_gamesPercentDisplay = new System.Windows.Forms.Label();
            this.lbl_gamesTiedDisplay = new System.Windows.Forms.Label();
            this.lbl_gamesWonDisplay = new System.Windows.Forms.Label();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_gameStatsHeader
            // 
            this.lbl_gameStatsHeader.AutoSize = true;
            this.lbl_gameStatsHeader.BackColor = System.Drawing.Color.White;
            this.lbl_gameStatsHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gameStatsHeader.Font = new System.Drawing.Font("Valken", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameStatsHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gameStatsHeader.Location = new System.Drawing.Point(181, 9);
            this.lbl_gameStatsHeader.Name = "lbl_gameStatsHeader";
            this.lbl_gameStatsHeader.Size = new System.Drawing.Size(331, 61);
            this.lbl_gameStatsHeader.TabIndex = 0;
            this.lbl_gameStatsHeader.Text = "GAME STATS";
            // 
            // lbl_gamesPlayedTitle
            // 
            this.lbl_gamesPlayedTitle.AutoSize = true;
            this.lbl_gamesPlayedTitle.BackColor = System.Drawing.Color.White;
            this.lbl_gamesPlayedTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gamesPlayedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesPlayedTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gamesPlayedTitle.Location = new System.Drawing.Point(181, 114);
            this.lbl_gamesPlayedTitle.Name = "lbl_gamesPlayedTitle";
            this.lbl_gamesPlayedTitle.Size = new System.Drawing.Size(154, 27);
            this.lbl_gamesPlayedTitle.TabIndex = 4;
            this.lbl_gamesPlayedTitle.Text = "Games Played";
            // 
            // lbl_gamesWonTitle
            // 
            this.lbl_gamesWonTitle.AutoSize = true;
            this.lbl_gamesWonTitle.BackColor = System.Drawing.Color.White;
            this.lbl_gamesWonTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gamesWonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesWonTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gamesWonTitle.Location = new System.Drawing.Point(181, 169);
            this.lbl_gamesWonTitle.Name = "lbl_gamesWonTitle";
            this.lbl_gamesWonTitle.Size = new System.Drawing.Size(132, 27);
            this.lbl_gamesWonTitle.TabIndex = 5;
            this.lbl_gamesWonTitle.Text = "Games Won";
            // 
            // lbl_gamesTiedTitle
            // 
            this.lbl_gamesTiedTitle.AutoSize = true;
            this.lbl_gamesTiedTitle.BackColor = System.Drawing.Color.White;
            this.lbl_gamesTiedTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gamesTiedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesTiedTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gamesTiedTitle.Location = new System.Drawing.Point(181, 228);
            this.lbl_gamesTiedTitle.Name = "lbl_gamesTiedTitle";
            this.lbl_gamesTiedTitle.Size = new System.Drawing.Size(130, 27);
            this.lbl_gamesTiedTitle.TabIndex = 6;
            this.lbl_gamesTiedTitle.Text = "Games Tied";
            // 
            // lbl_gamesRatioTitle
            // 
            this.lbl_gamesRatioTitle.AutoSize = true;
            this.lbl_gamesRatioTitle.BackColor = System.Drawing.Color.White;
            this.lbl_gamesRatioTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gamesRatioTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesRatioTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gamesRatioTitle.Location = new System.Drawing.Point(181, 280);
            this.lbl_gamesRatioTitle.Name = "lbl_gamesRatioTitle";
            this.lbl_gamesRatioTitle.Size = new System.Drawing.Size(168, 27);
            this.lbl_gamesRatioTitle.TabIndex = 7;
            this.lbl_gamesRatioTitle.Text = "Player/AI Win %";
            // 
            // lbl_gamesPlayedDisplay
            // 
            this.lbl_gamesPlayedDisplay.AutoSize = true;
            this.lbl_gamesPlayedDisplay.BackColor = System.Drawing.Color.White;
            this.lbl_gamesPlayedDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gamesPlayedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesPlayedDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gamesPlayedDisplay.Location = new System.Drawing.Point(465, 114);
            this.lbl_gamesPlayedDisplay.Name = "lbl_gamesPlayedDisplay";
            this.lbl_gamesPlayedDisplay.Size = new System.Drawing.Size(148, 27);
            this.lbl_gamesPlayedDisplay.TabIndex = 8;
            this.lbl_gamesPlayedDisplay.Text = "games played";
            // 
            // lbl_gamesPercentDisplay
            // 
            this.lbl_gamesPercentDisplay.AutoSize = true;
            this.lbl_gamesPercentDisplay.BackColor = System.Drawing.Color.White;
            this.lbl_gamesPercentDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gamesPercentDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesPercentDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gamesPercentDisplay.Location = new System.Drawing.Point(465, 280);
            this.lbl_gamesPercentDisplay.Name = "lbl_gamesPercentDisplay";
            this.lbl_gamesPercentDisplay.Size = new System.Drawing.Size(103, 27);
            this.lbl_gamesPercentDisplay.TabIndex = 9;
            this.lbl_gamesPercentDisplay.Text = "games %";
            // 
            // lbl_gamesTiedDisplay
            // 
            this.lbl_gamesTiedDisplay.AutoSize = true;
            this.lbl_gamesTiedDisplay.BackColor = System.Drawing.Color.White;
            this.lbl_gamesTiedDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gamesTiedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesTiedDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gamesTiedDisplay.Location = new System.Drawing.Point(465, 228);
            this.lbl_gamesTiedDisplay.Name = "lbl_gamesTiedDisplay";
            this.lbl_gamesTiedDisplay.Size = new System.Drawing.Size(119, 27);
            this.lbl_gamesTiedDisplay.TabIndex = 10;
            this.lbl_gamesTiedDisplay.Text = "games tied";
            // 
            // lbl_gamesWonDisplay
            // 
            this.lbl_gamesWonDisplay.AutoSize = true;
            this.lbl_gamesWonDisplay.BackColor = System.Drawing.Color.White;
            this.lbl_gamesWonDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gamesWonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesWonDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gamesWonDisplay.Location = new System.Drawing.Point(465, 169);
            this.lbl_gamesWonDisplay.Name = "lbl_gamesWonDisplay";
            this.lbl_gamesWonDisplay.Size = new System.Drawing.Size(123, 27);
            this.lbl_gamesWonDisplay.TabIndex = 11;
            this.lbl_gamesWonDisplay.Text = "games won";
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.FlatAppearance.BorderSize = 3;
            this.btn_mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainMenu.Font = new System.Drawing.Font("Valken", 24.25F);
            this.btn_mainMenu.Location = new System.Drawing.Point(51, 364);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(610, 155);
            this.btn_mainMenu.TabIndex = 12;
            this.btn_mainMenu.Text = "Back to Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CIS153_FinalProject_GroupA.Properties.Resources.Blue_9809_2__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(732, 582);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.lbl_gamesWonDisplay);
            this.Controls.Add(this.lbl_gamesTiedDisplay);
            this.Controls.Add(this.lbl_gamesPercentDisplay);
            this.Controls.Add(this.lbl_gamesPlayedDisplay);
            this.Controls.Add(this.lbl_gamesRatioTitle);
            this.Controls.Add(this.lbl_gamesTiedTitle);
            this.Controls.Add(this.lbl_gamesWonTitle);
            this.Controls.Add(this.lbl_gamesPlayedTitle);
            this.Controls.Add(this.lbl_gameStatsHeader);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Stats";
            this.Text = "Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stats_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gameStatsHeader;
        private System.Windows.Forms.Label lbl_gamesPlayedTitle;
        private System.Windows.Forms.Label lbl_gamesWonTitle;
        private System.Windows.Forms.Label lbl_gamesTiedTitle;
        private System.Windows.Forms.Label lbl_gamesRatioTitle;
        private System.Windows.Forms.Label lbl_gamesPlayedDisplay;
        private System.Windows.Forms.Label lbl_gamesPercentDisplay;
        private System.Windows.Forms.Label lbl_gamesTiedDisplay;
        private System.Windows.Forms.Label lbl_gamesWonDisplay;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}