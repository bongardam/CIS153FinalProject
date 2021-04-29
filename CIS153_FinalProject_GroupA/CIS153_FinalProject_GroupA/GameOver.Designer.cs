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
            this.lbl_movesTotal = new System.Windows.Forms.Label();
            this.btn_showBoard = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_winnerText = new System.Windows.Forms.Label();
            this.lbl_afterText = new System.Windows.Forms.Label();
            this.lbl_movesText = new System.Windows.Forms.Label();
            this.lbl_playerText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_gameOverHeader
            // 
            this.lbl_gameOverHeader.AutoSize = true;
            this.lbl_gameOverHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOverHeader.Location = new System.Drawing.Point(228, 34);
            this.lbl_gameOverHeader.Name = "lbl_gameOverHeader";
            this.lbl_gameOverHeader.Size = new System.Drawing.Size(314, 55);
            this.lbl_gameOverHeader.TabIndex = 0;
            this.lbl_gameOverHeader.Text = "GAME OVER";
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.Location = new System.Drawing.Point(428, 188);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(176, 55);
            this.lbl_winner.TabIndex = 1;
            this.lbl_winner.Text = "Winner";
            // 
            // lbl_firstPlayer
            // 
            this.lbl_firstPlayer.AutoSize = true;
            this.lbl_firstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstPlayer.Location = new System.Drawing.Point(253, 108);
            this.lbl_firstPlayer.Name = "lbl_firstPlayer";
            this.lbl_firstPlayer.Size = new System.Drawing.Size(154, 25);
            this.lbl_firstPlayer.TabIndex = 2;
            this.lbl_firstPlayer.Text = "PLAYER 1 vs. ";
            // 
            // lbl_secondPlayer
            // 
            this.lbl_secondPlayer.AutoSize = true;
            this.lbl_secondPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secondPlayer.Location = new System.Drawing.Point(393, 109);
            this.lbl_secondPlayer.Name = "lbl_secondPlayer";
            this.lbl_secondPlayer.Size = new System.Drawing.Size(115, 25);
            this.lbl_secondPlayer.TabIndex = 3;
            this.lbl_secondPlayer.Text = "player 2 ID";
            // 
            // lbl_movesTotal
            // 
            this.lbl_movesTotal.AutoSize = true;
            this.lbl_movesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movesTotal.Location = new System.Drawing.Point(370, 265);
            this.lbl_movesTotal.Name = "lbl_movesTotal";
            this.lbl_movesTotal.Size = new System.Drawing.Size(37, 24);
            this.lbl_movesTotal.TabIndex = 4;
            this.lbl_movesTotal.Text = "dm";
            // 
            // btn_showBoard
            // 
            this.btn_showBoard.Location = new System.Drawing.Point(354, 326);
            this.btn_showBoard.Name = "btn_showBoard";
            this.btn_showBoard.Size = new System.Drawing.Size(75, 23);
            this.btn_showBoard.TabIndex = 6;
            this.btn_showBoard.Text = "Show Board";
            this.btn_showBoard.UseVisualStyleBackColor = true;
            this.btn_showBoard.Click += new System.EventHandler(this.btn_showBoard_Click);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.Location = new System.Drawing.Point(354, 364);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_mainMenu.TabIndex = 7;
            this.btn_mainMenu.Text = "Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(354, 404);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_winnerText
            // 
            this.lbl_winnerText.AutoSize = true;
            this.lbl_winnerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winnerText.Location = new System.Drawing.Point(228, 133);
            this.lbl_winnerText.Name = "lbl_winnerText";
            this.lbl_winnerText.Size = new System.Drawing.Size(348, 55);
            this.lbl_winnerText.TabIndex = 9;
            this.lbl_winnerText.Text = "The winner is...";
            // 
            // lbl_afterText
            // 
            this.lbl_afterText.AutoSize = true;
            this.lbl_afterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afterText.Location = new System.Drawing.Point(311, 265);
            this.lbl_afterText.Name = "lbl_afterText";
            this.lbl_afterText.Size = new System.Drawing.Size(53, 24);
            this.lbl_afterText.TabIndex = 10;
            this.lbl_afterText.Text = "After ";
            // 
            // lbl_movesText
            // 
            this.lbl_movesText.AutoSize = true;
            this.lbl_movesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movesText.Location = new System.Drawing.Point(413, 265);
            this.lbl_movesText.Name = "lbl_movesText";
            this.lbl_movesText.Size = new System.Drawing.Size(66, 24);
            this.lbl_movesText.TabIndex = 11;
            this.lbl_movesText.Text = "moves";
            // 
            // lbl_playerText
            // 
            this.lbl_playerText.AutoSize = true;
            this.lbl_playerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerText.Location = new System.Drawing.Point(262, 188);
            this.lbl_playerText.Name = "lbl_playerText";
            this.lbl_playerText.Size = new System.Drawing.Size(160, 55);
            this.lbl_playerText.TabIndex = 12;
            this.lbl_playerText.Text = "Player";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_playerText);
            this.Controls.Add(this.lbl_movesText);
            this.Controls.Add(this.lbl_afterText);
            this.Controls.Add(this.lbl_winnerText);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.btn_showBoard);
            this.Controls.Add(this.lbl_movesTotal);
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
        private System.Windows.Forms.Label lbl_movesTotal;
        private System.Windows.Forms.Button btn_showBoard;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_winnerText;
        private System.Windows.Forms.Label lbl_afterText;
        private System.Windows.Forms.Label lbl_movesText;
        private System.Windows.Forms.Label lbl_playerText;
    }
}