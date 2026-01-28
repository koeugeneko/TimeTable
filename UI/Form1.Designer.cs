namespace TimeTable
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
            panelHome.BackColor = Color.Gray;
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(180, 0);
            panelHome.Margin = new Padding(4);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(822, 712);
            panelHome.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.FromArgb(88, 88, 88);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 0);
            panelSide.Margin = new Padding(4);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(180, 712);
            panelSide.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 712);
            Controls.Add(panelHome);
            Controls.Add(panelSide);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1024, 768);
            MinimumSize = new Size(1024, 768);
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
