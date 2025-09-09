namespace TimeTable
{
    partial class LoginPage
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
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblLoginPassword = new Label();
            btnLoginLogin = new Button();
            chkRememberMe = new CheckBox();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.FlatStyle = FlatStyle.Flat;
            lblUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(336, 189);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(117, 31);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.Silver;
            txtUsername.Location = new Point(343, 235);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(579, 27);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Username";
            txtUsername.Click += txtUsername_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.Silver;
            txtPassword.Location = new Point(343, 327);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(579, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.Click += txtPassword_Click;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.FlatStyle = FlatStyle.Flat;
            lblLoginPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginPassword.Location = new Point(336, 293);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(110, 31);
            lblLoginPassword.TabIndex = 2;
            lblLoginPassword.Text = "Password";
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.BackColor = Color.FromArgb(128, 128, 255);
            btnLoginLogin.FlatStyle = FlatStyle.Flat;
            btnLoginLogin.Location = new Point(718, 383);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(204, 52);
            btnLoginLogin.TabIndex = 4;
            btnLoginLogin.Text = "login";
            btnLoginLogin.UseVisualStyleBackColor = false;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(343, 374);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(125, 24);
            chkRememberMe.TabIndex = 5;
            chkRememberMe.Text = "RememberMe";
            chkRememberMe.UseVisualStyleBackColor = true;
            chkRememberMe.CheckedChanged += chkRememberMe_CheckedChanged;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(chkRememberMe);
            Controls.Add(btnLoginLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblLoginPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            DoubleBuffered = true;
            Name = "LoginPage";
            Size = new Size(1280, 720);
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblLoginPassword;
        private Button btnLoginLogin;
        private CheckBox chkRememberMe;
    }
}
