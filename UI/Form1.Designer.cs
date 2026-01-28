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
            panelMain = new Panel();
            panelSide = new Panel();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Gray;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(144, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(661, 577);
            panelMain.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.FromArgb(88, 88, 88);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(144, 577);
            panelSide.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 577);
            Controls.Add(panelMain);
            Controls.Add(panelSide);
            MaximizeBox = false;
            MaximumSize = new Size(823, 624);
            MinimumSize = new Size(823, 624);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinForms";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelSide;
    }
}
