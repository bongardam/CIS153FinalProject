﻿using System.Windows.Forms;

namespace CIS153_FinalProject_GroupA
{
    partial class SinglePlayer
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
        /// 

        private void InitializeComponent()
        {
            this.TESTONLY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TESTONLY
            // 
            this.TESTONLY.AutoSize = true;
            this.TESTONLY.Location = new System.Drawing.Point(295, 56);
            this.TESTONLY.Name = "TESTONLY";
            this.TESTONLY.Size = new System.Drawing.Size(99, 13);
            this.TESTONLY.TabIndex = 0;
            this.TESTONLY.Text = "Single TEST ONLY";
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(697, 751);
            this.Controls.Add(this.TESTONLY);
            this.Name = "SinglePlayer";
            this.Text = "SinglePlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SinglePlayer_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SinglePlayer_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TESTONLY;
    }
}