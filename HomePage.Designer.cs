namespace TimeTable
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubject1 = new Button();
            btnSubject2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSubject3 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubject1
            // 
            btnSubject1.BackColor = Color.FromArgb(255, 128, 128);
            btnSubject1.Dock = DockStyle.Fill;
            btnSubject1.FlatStyle = FlatStyle.Popup;
            btnSubject1.Location = new Point(3, 3);
            btnSubject1.Name = "btnSubject1";
            btnSubject1.Size = new Size(737, 143);
            btnSubject1.TabIndex = 0;
            btnSubject1.Text = "Subject 1";
            btnSubject1.UseVisualStyleBackColor = false;
            // 
            // btnSubject2
            // 
            btnSubject2.BackColor = Color.FromArgb(255, 192, 128);
            btnSubject2.Dock = DockStyle.Fill;
            btnSubject2.FlatStyle = FlatStyle.Popup;
            btnSubject2.Location = new Point(3, 152);
            btnSubject2.Name = "btnSubject2";
            btnSubject2.Size = new Size(737, 144);
            btnSubject2.TabIndex = 1;
            btnSubject2.Text = "Subject 2";
            btnSubject2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnSubject3, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSubject1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSubject2, 0, 1);
            tableLayoutPanel1.Location = new Point(376, 141);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(743, 450);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnSubject3
            // 
            btnSubject3.BackColor = Color.FromArgb(255, 255, 128);
            btnSubject3.Dock = DockStyle.Fill;
            btnSubject3.FlatStyle = FlatStyle.Popup;
            btnSubject3.Location = new Point(3, 302);
            btnSubject3.Name = "btnSubject3";
            btnSubject3.Size = new Size(737, 145);
            btnSubject3.TabIndex = 2;
            btnSubject3.Text = "Subject 3";
            btnSubject3.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "HomePage";
            Size = new Size(1280, 720);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubject1;
        private Button btnSubject2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSubject3;
    }
}
