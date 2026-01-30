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
            MinSideBarButton = new Button();
            SuspendLayout();
            // 
            // DailyTaskButton
            // 
            DailyTaskButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DailyTaskButton.BackgroundImageLayout = ImageLayout.Zoom;
            DailyTaskButton.Location = new Point(18, 124);
            DailyTaskButton.Margin = new Padding(4);
            DailyTaskButton.Name = "DailyTaskButton";
            DailyTaskButton.Size = new Size(110, 112);
            DailyTaskButton.TabIndex = 0;
            DailyTaskButton.Text = "Daily task";
            DailyTaskButton.UseVisualStyleBackColor = true;
            DailyTaskButton.Click += DailyTaskButton_Click;
            // 
            // TaskLibaryButton
            // 
            TaskLibaryButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TaskLibaryButton.BackgroundImageLayout = ImageLayout.Zoom;
            TaskLibaryButton.Location = new Point(18, 242);
            TaskLibaryButton.Margin = new Padding(4);
            TaskLibaryButton.Name = "TaskLibaryButton";
            TaskLibaryButton.RightToLeft = RightToLeft.No;
            TaskLibaryButton.Size = new Size(110, 112);
            TaskLibaryButton.TabIndex = 1;
            TaskLibaryButton.Text = "Task libary";
            TaskLibaryButton.UseVisualStyleBackColor = true;
            TaskLibaryButton.Click += TaskLibaryButton_Click;
            // 
            // SubjectLibaryButton
            // 
            SubjectLibaryButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SubjectLibaryButton.Location = new Point(18, 354);
            SubjectLibaryButton.Margin = new Padding(4);
            SubjectLibaryButton.Name = "SubjectLibaryButton";
            SubjectLibaryButton.Size = new Size(110, 112);
            SubjectLibaryButton.TabIndex = 2;
            SubjectLibaryButton.Text = "Subject libary";
            SubjectLibaryButton.UseVisualStyleBackColor = true;
            SubjectLibaryButton.Click += SubjectLibaryButton_Click;
            // 
            // ReportStatButton
            // 
            ReportStatButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ReportStatButton.BackgroundImageLayout = ImageLayout.Zoom;
            ReportStatButton.Location = new Point(18, 471);
            ReportStatButton.Margin = new Padding(4);
            ReportStatButton.Name = "ReportStatButton";
            ReportStatButton.RightToLeft = RightToLeft.No;
            ReportStatButton.Size = new Size(110, 112);
            ReportStatButton.TabIndex = 3;
            ReportStatButton.Text = "Stats";
            ReportStatButton.UseVisualStyleBackColor = true;
            ReportStatButton.Click += ReportStatButton_Click;
            // 
            // SettingButton
            // 
            SettingButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SettingButton.BackgroundImageLayout = ImageLayout.Zoom;
            SettingButton.Location = new Point(18, 591);
            SettingButton.Margin = new Padding(4);
            SettingButton.Name = "SettingButton";
            SettingButton.Size = new Size(110, 112);
            SettingButton.TabIndex = 4;
            SettingButton.Text = "Settings";
            SettingButton.UseVisualStyleBackColor = true;
            SettingButton.Click += SettingButton_Click;
            // 
            // MinSideBarButton
            // 
            MinSideBarButton.BackgroundImageLayout = ImageLayout.Zoom;
            MinSideBarButton.Location = new Point(18, 0);
            MinSideBarButton.Margin = new Padding(4);
            MinSideBarButton.Name = "MinSideBarButton";
            MinSideBarButton.Size = new Size(110, 112);
            MinSideBarButton.TabIndex = 5;
            MinSideBarButton.Text = ". . .";
            MinSideBarButton.UseVisualStyleBackColor = true;
            MinSideBarButton.Click += MinSideBarButton_Click;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SettingButton);
            Controls.Add(ReportStatButton);
            Controls.Add(SubjectLibaryButton);
            Controls.Add(TaskLibaryButton);
            Controls.Add(DailyTaskButton);
            Controls.Add(MinSideBarButton);
            Margin = new Padding(2);
            Name = "SideBar";
            Size = new Size(150, 712);
            ResumeLayout(false);
        }

        #endregion

        private Button DailyTaskButton;
        private Button TaskLibaryButton;
        private Button SubjectLibaryButton;
        private Button ReportStatButton;
        private Button SettingButton;
        private Button MinSideBarButton;
    }
}
