using System.Drawing;
using System.Windows.Forms;

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
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox_bg = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_stats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_onePlayer
            // 
            this.btn_onePlayer.BackColor = System.Drawing.Color.Yellow;
            this.btn_onePlayer.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_onePlayer.FlatAppearance.BorderSize = 3;
            this.btn_onePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btn_onePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_onePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onePlayer.Font = new System.Drawing.Font("Valken", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_onePlayer.Image = global::CIS153_FinalProject_GroupA.Properties.Resources.singleplayerOPTION2;
            this.btn_onePlayer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_onePlayer.Location = new System.Drawing.Point(81, 437);
            this.btn_onePlayer.Name = "btn_onePlayer";
            this.btn_onePlayer.Size = new System.Drawing.Size(202, 111);
            this.btn_onePlayer.TabIndex = 0;
            this.btn_onePlayer.Text = "One Player";
            this.btn_onePlayer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_onePlayer.UseVisualStyleBackColor = false;
            this.btn_onePlayer.Click += new System.EventHandler(this.btn_onePlayer_Click);
            // 
            // btn_twoPlayer
            // 
            this.btn_twoPlayer.BackColor = System.Drawing.Color.Yellow;
            this.btn_twoPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_twoPlayer.FlatAppearance.BorderSize = 3;
            this.btn_twoPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btn_twoPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_twoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_twoPlayer.Font = new System.Drawing.Font("Valken", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_twoPlayer.ForeColor = System.Drawing.Color.Black;
            this.btn_twoPlayer.Image = global::CIS153_FinalProject_GroupA.Properties.Resources.Multiplayer75Pixels;
            this.btn_twoPlayer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_twoPlayer.Location = new System.Drawing.Point(289, 437);
            this.btn_twoPlayer.Name = "btn_twoPlayer";
            this.btn_twoPlayer.Size = new System.Drawing.Size(202, 111);
            this.btn_twoPlayer.TabIndex = 1;
            this.btn_twoPlayer.Text = "Two Players";
            this.btn_twoPlayer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_twoPlayer.UseVisualStyleBackColor = false;
            this.btn_twoPlayer.Click += new System.EventHandler(this.btn_twoPlayer_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Yellow;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_exit.FlatAppearance.BorderSize = 3;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Valken", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(289, 554);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(202, 82);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox_bg
            // 
            this.pictureBox_bg.BackgroundImage = global::CIS153_FinalProject_GroupA.Properties.Resources.connect4logo1;
            this.pictureBox_bg.Image = global::CIS153_FinalProject_GroupA.Properties.Resources.Blue_9809_2__2_;
            this.pictureBox_bg.Location = new System.Drawing.Point(-2, -7);
            this.pictureBox_bg.Name = "pictureBox_bg";
            this.pictureBox_bg.Size = new System.Drawing.Size(787, 665);
            this.pictureBox_bg.TabIndex = 4;
            this.pictureBox_bg.TabStop = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::CIS153_FinalProject_GroupA.Properties.Resources.connect4RESIZE;
            this.pictureBox_logo.Location = new System.Drawing.Point(-84, -57);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(931, 555);
            this.pictureBox_logo.TabIndex = 5;
            this.pictureBox_logo.TabStop = false;
            // 
            // btn_stats
            // 
            this.btn_stats.BackColor = System.Drawing.Color.Yellow;
            this.btn_stats.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_stats.FlatAppearance.BorderSize = 3;
            this.btn_stats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btn_stats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stats.Font = new System.Drawing.Font("Valken", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats.Image = global::CIS153_FinalProject_GroupA.Properties.Resources.research;
            this.btn_stats.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_stats.Location = new System.Drawing.Point(497, 437);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(202, 111);
            this.btn_stats.TabIndex = 2;
            this.btn_stats.Text = "Statistics";
            this.btn_stats.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_stats.UseVisualStyleBackColor = false;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(784, 648);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_twoPlayer);
            this.Controls.Add(this.btn_onePlayer);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.pictureBox_bg);
            this.Name = "Welcome";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_onePlayer;
        private System.Windows.Forms.Button btn_twoPlayer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox_bg;
        private PictureBox pictureBox_logo;
        private Button btn_stats;
    }
}

