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
            lblUsername.Location = new Point(193, 179);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(142, 38);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.Silver;
            txtUsername.Location = new Point(193, 241);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(501, 31);
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
            txtPassword.Location = new Point(193, 337);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(501, 31);
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
            lblLoginPassword.Location = new Point(184, 294);
            lblLoginPassword.Margin = new Padding(4, 0, 4, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(132, 38);
            lblLoginPassword.TabIndex = 2;
            lblLoginPassword.Text = "Password";
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLoginLogin.BackColor = Color.FromArgb(128, 128, 255);
            btnLoginLogin.FlatStyle = FlatStyle.Flat;
            btnLoginLogin.Location = new Point(439, 424);
            btnLoginLogin.Margin = new Padding(4);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(255, 65);
            btnLoginLogin.TabIndex = 4;
            btnLoginLogin.Text = "login";
            btnLoginLogin.UseVisualStyleBackColor = false;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(193, 396);
            chkRememberMe.Margin = new Padding(4);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(149, 29);
            chkRememberMe.TabIndex = 5;
            chkRememberMe.Text = "RememberMe";
            chkRememberMe.UseVisualStyleBackColor = true;
            chkRememberMe.CheckedChanged += chkRememberMe_CheckedChanged;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(chkRememberMe);
            Controls.Add(btnLoginLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblLoginPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "LoginPage";
            Size = new Size(1002, 712);
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
