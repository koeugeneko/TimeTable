namespace TimeTable.UI
{
    partial class SubjectLibaryPage
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
            dataGridView1 = new DataGridView();
            SubjectNameColumn = new DataGridViewTextBoxColumn();
            AddNewSubject = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SubjectNameColumn });
            dataGridView1.Location = new Point(74, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(503, 359);
            dataGridView1.TabIndex = 0;
            // 
            // SubjectNameColumn
            // 
            SubjectNameColumn.HeaderText = "Subject name";
            SubjectNameColumn.MinimumWidth = 6;
            SubjectNameColumn.Name = "SubjectNameColumn";
            SubjectNameColumn.Width = 200;
            // 
            // AddNewSubject
            // 
            AddNewSubject.Location = new Point(164, 478);
            AddNewSubject.Name = "AddNewSubject";
            AddNewSubject.Size = new Size(326, 55);
            AddNewSubject.TabIndex = 1;
            AddNewSubject.Text = "Add new subject";
            AddNewSubject.UseVisualStyleBackColor = true;
            // 
            // SubjectLibaryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddNewSubject);
            Controls.Add(dataGridView1);
            Name = "SubjectLibaryPage";
            Size = new Size(661, 577);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SubjectNameColumn;
        private Button AddNewSubject;
    }
}
