﻿namespace TimeTable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHome = new Panel();
            panelSide = new Panel();
            SuspendLayout();
            // 
            // panelHome
            // 
            panelHome.BackColor = SystemColors.ActiveBorder;
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(0, 0);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1902, 1033);
            panelHome.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.FromArgb(88, 88, 88);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(260, 1033);
            panelSide.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelSide);
            Controls.Add(panelHome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinForms";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHome;
        private Panel panelSide;
    }
}
