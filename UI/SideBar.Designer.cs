namespace TimeTable.UI
{
    partial class SideBar
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
            DailyTaskButton = new Button();
            TaskLibaryButton = new Button();
            SubjectLibaryButton = new Button();
            ReportStatButton = new Button();
            SettingButton = new Button();
            SuspendLayout();
            // 
            // DailyTaskButton
            // 
            DailyTaskButton.Location = new Point(5, 17);
            DailyTaskButton.Name = "DailyTaskButton";
            DailyTaskButton.Size = new Size(127, 78);
            DailyTaskButton.TabIndex = 0;
            DailyTaskButton.Text = "Daily task";
            DailyTaskButton.UseVisualStyleBackColor = true;
            DailyTaskButton.Click += DailyTaskButton_Click;
            // 
            // TaskLibaryButton
            // 
            TaskLibaryButton.Location = new Point(5, 114);
            TaskLibaryButton.Name = "TaskLibaryButton";
            TaskLibaryButton.Size = new Size(127, 72);
            TaskLibaryButton.TabIndex = 1;
            TaskLibaryButton.Text = "Task libary";
            TaskLibaryButton.UseVisualStyleBackColor = true;
            TaskLibaryButton.Click += TaskLibaryButton_Click;
            // 
            // SubjectLibaryButton
            // 
            SubjectLibaryButton.Location = new Point(5, 205);
            SubjectLibaryButton.Name = "SubjectLibaryButton";
            SubjectLibaryButton.Size = new Size(127, 72);
            SubjectLibaryButton.TabIndex = 2;
            SubjectLibaryButton.Text = "Subject libary";
            SubjectLibaryButton.UseVisualStyleBackColor = true;
            // 
            // ReportStatButton
            // 
            ReportStatButton.Location = new Point(5, 296);
            ReportStatButton.Name = "ReportStatButton";
            ReportStatButton.Size = new Size(127, 70);
            ReportStatButton.TabIndex = 3;
            ReportStatButton.Text = "Reports / stats";
            ReportStatButton.UseVisualStyleBackColor = true;
            ReportStatButton.Click += ReportStatButton_Click;
            // 
            // SettingButton
            // 
            SettingButton.Location = new Point(5, 497);
            SettingButton.Name = "SettingButton";
            SettingButton.Size = new Size(127, 66);
            SettingButton.TabIndex = 4;
            SettingButton.Text = "Settings";
            SettingButton.UseVisualStyleBackColor = true;
            SettingButton.Click += SettingButton_Click;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SettingButton);
            Controls.Add(ReportStatButton);
            Controls.Add(SubjectLibaryButton);
            Controls.Add(TaskLibaryButton);
            Controls.Add(DailyTaskButton);
            Margin = new Padding(2);
            Name = "SideBar";
            Size = new Size(144, 577);
            ResumeLayout(false);
        }

        #endregion

        private Button DailyTaskButton;
        private Button TaskLibaryButton;
        private Button SubjectLibaryButton;
        private Button ReportStatButton;
        private Button SettingButton;
    }
}
