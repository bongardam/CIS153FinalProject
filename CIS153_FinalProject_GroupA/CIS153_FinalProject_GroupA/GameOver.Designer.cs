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
            this.lbl_fpMoves = new System.Windows.Forms.Label();
            this.lbl_spMoves = new System.Windows.Forms.Label();
            this.btn_showBoard = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_gameOverHeader
            // 
            this.lbl_gameOverHeader.AutoSize = true;
            this.lbl_gameOverHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOverHeader.Location = new System.Drawing.Point(237, 57);
            this.lbl_gameOverHeader.Name = "lbl_gameOverHeader";
            this.lbl_gameOverHeader.Size = new System.Drawing.Size(314, 55);
            this.lbl_gameOverHeader.TabIndex = 0;
            this.lbl_gameOverHeader.Text = "GAME OVER";
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.Location = new System.Drawing.Point(348, 139);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(99, 31);
            this.lbl_winner.TabIndex = 1;
            this.lbl_winner.Text = "Winner";
            // 
            // lbl_firstPlayer
            // 
            this.lbl_firstPlayer.AutoSize = true;
            this.lbl_firstPlayer.Location = new System.Drawing.Point(109, 243);
            this.lbl_firstPlayer.Name = "lbl_firstPlayer";
            this.lbl_firstPlayer.Size = new System.Drawing.Size(58, 13);
            this.lbl_firstPlayer.TabIndex = 2;
            this.lbl_firstPlayer.Text = "player 1 ID";
            // 
            // lbl_secondPlayer
            // 
            this.lbl_secondPlayer.AutoSize = true;
            this.lbl_secondPlayer.Location = new System.Drawing.Point(567, 252);
            this.lbl_secondPlayer.Name = "lbl_secondPlayer";
            this.lbl_secondPlayer.Size = new System.Drawing.Size(58, 13);
            this.lbl_secondPlayer.TabIndex = 3;
            this.lbl_secondPlayer.Text = "player 2 ID";
            // 
            // lbl_fpMoves
            // 
            this.lbl_fpMoves.AutoSize = true;
            this.lbl_fpMoves.Location = new System.Drawing.Point(99, 269);
            this.lbl_fpMoves.Name = "lbl_fpMoves";
            this.lbl_fpMoves.Size = new System.Drawing.Size(85, 13);
            this.lbl_fpMoves.TabIndex = 4;
            this.lbl_fpMoves.Text = "display fp moves";
            // 
            // lbl_spMoves
            // 
            this.lbl_spMoves.AutoSize = true;
            this.lbl_spMoves.Location = new System.Drawing.Point(567, 283);
            this.lbl_spMoves.Name = "lbl_spMoves";
            this.lbl_spMoves.Size = new System.Drawing.Size(89, 13);
            this.lbl_spMoves.TabIndex = 5;
            this.lbl_spMoves.Text = "display 2P moves";
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
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.btn_showBoard);
            this.Controls.Add(this.lbl_spMoves);
            this.Controls.Add(this.lbl_fpMoves);
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
        private System.Windows.Forms.Label lbl_fpMoves;
        private System.Windows.Forms.Label lbl_spMoves;
        private System.Windows.Forms.Button btn_showBoard;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Button btn_exit;
    }
}