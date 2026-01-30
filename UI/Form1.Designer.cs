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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Gray;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(150, 40);
            panelMain.Margin = new Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(874, 748);
            panelMain.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.DimGray;
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 40);
            panelSide.Margin = new Padding(4);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(150, 748);
            panelSide.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 40);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 788);
            Controls.Add(panelMain);
            Controls.Add(panelSide);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1024, 788);
            MinimumSize = new Size(1024, 788);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinForms";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelSide;
        private Panel panel1;
    }
}
