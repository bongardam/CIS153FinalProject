namespace CIS153_FinalProject_GroupA
{
    partial class Welcome
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
            this.btn_onePlayer = new System.Windows.Forms.Button();
            this.btn_twoPlayer = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_onePlayer
            // 
            this.btn_onePlayer.Location = new System.Drawing.Point(289, 125);
            this.btn_onePlayer.Name = "btn_onePlayer";
            this.btn_onePlayer.Size = new System.Drawing.Size(202, 72);
            this.btn_onePlayer.TabIndex = 0;
            this.btn_onePlayer.Text = "One Player";
            this.btn_onePlayer.UseVisualStyleBackColor = true;
            this.btn_onePlayer.Click += new System.EventHandler(this.btn_onePlayer_Click);
            // 
            // btn_twoPlayer
            // 
            this.btn_twoPlayer.Location = new System.Drawing.Point(289, 212);
            this.btn_twoPlayer.Name = "btn_twoPlayer";
            this.btn_twoPlayer.Size = new System.Drawing.Size(202, 72);
            this.btn_twoPlayer.TabIndex = 1;
            this.btn_twoPlayer.Text = "Two Player";
            this.btn_twoPlayer.UseVisualStyleBackColor = true;
            this.btn_twoPlayer.Click += new System.EventHandler(this.btn_twoPlayer_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.Location = new System.Drawing.Point(289, 300);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(202, 72);
            this.btn_stats.TabIndex = 2;
            this.btn_stats.Text = "Statistics";
            this.btn_stats.UseVisualStyleBackColor = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(289, 388);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(202, 72);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_twoPlayer);
            this.Controls.Add(this.btn_onePlayer);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_onePlayer;
        private System.Windows.Forms.Button btn_twoPlayer;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_exit;
    }
}

