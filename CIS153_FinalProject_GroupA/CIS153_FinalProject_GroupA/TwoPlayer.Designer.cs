﻿namespace CIS153_FinalProject_GroupA
{
    partial class TwoPlayer
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
            this.TESTONLY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TESTONLY
            // 
            this.TESTONLY.AutoSize = true;
            this.TESTONLY.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TESTONLY.Location = new System.Drawing.Point(351, 219);
            this.TESTONLY.Name = "TESTONLY";
            this.TESTONLY.Size = new System.Drawing.Size(91, 13);
            this.TESTONLY.TabIndex = 1;
            this.TESTONLY.Text = "Two TEST ONLY";
            // 
            // TwoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TESTONLY);
            this.Name = "TwoPlayer";
            this.Text = "TwoPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TESTONLY;
    }
}