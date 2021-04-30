namespace CIS153_FinalProject_GroupA
{
    partial class GameOver
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
            this.lbl_gameOverHeader = new System.Windows.Forms.Label();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.lbl_firstPlayer = new System.Windows.Forms.Label();
            this.lbl_secondPlayer = new System.Windows.Forms.Label();
            this.btn_showBoard = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_winnerText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_gameOverHeader
            // 
            this.lbl_gameOverHeader.AutoSize = true;
            this.lbl_gameOverHeader.Font = new System.Drawing.Font("Valken", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOverHeader.Location = new System.Drawing.Point(48, 9);
            this.lbl_gameOverHeader.Name = "lbl_gameOverHeader";
            this.lbl_gameOverHeader.Size = new System.Drawing.Size(307, 59);
            this.lbl_gameOverHeader.TabIndex = 0;
            this.lbl_gameOverHeader.Text = "GAME OVER";
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Font = new System.Drawing.Font("Valken", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.Location = new System.Drawing.Point(78, 184);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(197, 59);
            this.lbl_winner.TabIndex = 1;
            this.lbl_winner.Text = "Winner";
            this.lbl_winner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_firstPlayer
            // 
            this.lbl_firstPlayer.AutoSize = true;
            this.lbl_firstPlayer.BackColor = System.Drawing.Color.Turquoise;
            this.lbl_firstPlayer.Font = new System.Drawing.Font("Valken", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstPlayer.ForeColor = System.Drawing.Color.Red;
            this.lbl_firstPlayer.Location = new System.Drawing.Point(53, 86);
            this.lbl_firstPlayer.Name = "lbl_firstPlayer";
            this.lbl_firstPlayer.Size = new System.Drawing.Size(108, 26);
            this.lbl_firstPlayer.TabIndex = 2;
            this.lbl_firstPlayer.Text = "PLAYER 1";
            // 
            // lbl_secondPlayer
            // 
            this.lbl_secondPlayer.AutoSize = true;
            this.lbl_secondPlayer.Font = new System.Drawing.Font("Valken", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secondPlayer.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_secondPlayer.Location = new System.Drawing.Point(230, 86);
            this.lbl_secondPlayer.Name = "lbl_secondPlayer";
            this.lbl_secondPlayer.Size = new System.Drawing.Size(124, 26);
            this.lbl_secondPlayer.TabIndex = 3;
            this.lbl_secondPlayer.Text = "player 2 ID";
            // 
            // btn_showBoard
            // 
            this.btn_showBoard.FlatAppearance.BorderSize = 3;
            this.btn_showBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showBoard.Font = new System.Drawing.Font("Valken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showBoard.Location = new System.Drawing.Point(137, 262);
            this.btn_showBoard.Name = "btn_showBoard";
            this.btn_showBoard.Size = new System.Drawing.Size(126, 58);
            this.btn_showBoard.TabIndex = 6;
            this.btn_showBoard.Text = "Show Board";
            this.btn_showBoard.UseVisualStyleBackColor = true;
            this.btn_showBoard.Click += new System.EventHandler(this.btn_showBoard_Click);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.FlatAppearance.BorderSize = 3;
            this.btn_mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainMenu.Font = new System.Drawing.Font("Valken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainMenu.Location = new System.Drawing.Point(137, 326);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(126, 58);
            this.btn_mainMenu.TabIndex = 7;
            this.btn_mainMenu.Text = "Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.FlatAppearance.BorderSize = 3;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Valken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(137, 390);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(126, 58);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_winnerText
            // 
            this.lbl_winnerText.AutoSize = true;
            this.lbl_winnerText.Font = new System.Drawing.Font("Valken", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winnerText.Location = new System.Drawing.Point(12, 125);
            this.lbl_winnerText.Name = "lbl_winnerText";
            this.lbl_winnerText.Size = new System.Drawing.Size(388, 59);
            this.lbl_winnerText.TabIndex = 9;
            this.lbl_winnerText.Text = "The winner is...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Valken", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(173, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "vs.";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_winnerText);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.btn_showBoard);
            this.Controls.Add(this.lbl_secondPlayer);
            this.Controls.Add(this.lbl_firstPlayer);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.lbl_gameOverHeader);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gameOverHeader;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Label lbl_firstPlayer;
        private System.Windows.Forms.Label lbl_secondPlayer;
        private System.Windows.Forms.Button btn_showBoard;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_winnerText;
        private System.Windows.Forms.Label label1;
    }
}