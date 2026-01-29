namespace TimeTable.UI
{
    partial class TaskLibaryPage
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
            SubjectColumn = new DataGridViewTextBoxColumn();
            DescriptionCoulmn = new DataGridViewTextBoxColumn();
            EstimatedTimeColumn = new DataGridViewTextBoxColumn();
            DueDateColumn = new DataGridViewTextBoxColumn();
            PriorityColumn = new DataGridViewTextBoxColumn();
            StatsColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SubjectColumn, DescriptionCoulmn, EstimatedTimeColumn, DueDateColumn, PriorityColumn, StatsColumn });
            dataGridView1.Location = new Point(1, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(659, 348);
            dataGridView1.TabIndex = 0;
            // 
            // SubjectColumn
            // 
            SubjectColumn.HeaderText = "Subject";
            SubjectColumn.MinimumWidth = 6;
            SubjectColumn.Name = "SubjectColumn";
            SubjectColumn.Width = 110;
            // 
            // DescriptionCoulmn
            // 
            DescriptionCoulmn.HeaderText = "Description";
            DescriptionCoulmn.MinimumWidth = 6;
            DescriptionCoulmn.Name = "DescriptionCoulmn";
            DescriptionCoulmn.Width = 125;
            // 
            // EstimatedTimeColumn
            // 
            EstimatedTimeColumn.HeaderText = "Time";
            EstimatedTimeColumn.MinimumWidth = 6;
            EstimatedTimeColumn.Name = "EstimatedTimeColumn";
            EstimatedTimeColumn.Width = 80;
            // 
            // DueDateColumn
            // 
            DueDateColumn.HeaderText = "Due Date";
            DueDateColumn.MinimumWidth = 6;
            DueDateColumn.Name = "DueDateColumn";
            DueDateColumn.Width = 125;
            // 
            // PriorityColumn
            // 
            PriorityColumn.HeaderText = "Priority";
            PriorityColumn.MinimumWidth = 6;
            PriorityColumn.Name = "PriorityColumn";
            PriorityColumn.Width = 125;
            // 
            // StatsColumn
            // 
            StatsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StatsColumn.HeaderText = "Stats";
            StatsColumn.MinimumWidth = 6;
            StatsColumn.Name = "StatsColumn";
            // 
            // TaskLibaryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "TaskLibaryPage";
            Size = new Size(661, 577);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SubjectColumn;
        private DataGridViewTextBoxColumn DescriptionCoulmn;
        private DataGridViewTextBoxColumn EstimatedTimeColumn;
        private DataGridViewTextBoxColumn DueDateColumn;
        private DataGridViewTextBoxColumn PriorityColumn;
        private DataGridViewCheckBoxColumn StatsColumn;
    }
}
