namespace TimeTable.UI
{
    partial class SignUpPage
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
            txtPassword = new TextBox();
            lblLoginPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            btnLoginLogin = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.Silver;
            txtPassword.Location = new Point(189, 273);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(401, 27);
            txtPassword.TabIndex = 10;
            txtPassword.Text = "Password";
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.FlatStyle = FlatStyle.Flat;
            lblLoginPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginPassword.Location = new Point(182, 238);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(171, 31);
            lblLoginPassword.TabIndex = 9;
            lblLoginPassword.Text = "Enter password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.Silver;
            txtUsername.Location = new Point(191, 173);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(401, 27);
            txtUsername.TabIndex = 8;
            txtUsername.Text = "Username";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.FlatStyle = FlatStyle.Flat;
            lblUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(191, 131);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(173, 31);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Enter username";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(189, 360);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 27);
            textBox1.TabIndex = 11;
            textBox1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 425);
            label2.Name = "label2";
            label2.Size = new Size(129, 31);
            label2.TabIndex = 13;
            label2.Text = "Enter Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 326);
            label1.Name = "label1";
            label1.Size = new Size(232, 31);
            label1.TabIndex = 14;
            label1.Text = "Enter Password again";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(191, 459);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(401, 27);
            textBox2.TabIndex = 15;
            textBox2.Text = "Email";
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.BackColor = Color.White;
            btnLoginLogin.FlatStyle = FlatStyle.Flat;
            btnLoginLogin.Location = new Point(386, 523);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(204, 52);
            btnLoginLogin.TabIndex = 16;
            btnLoginLogin.Text = "Sign up";
            btnLoginLogin.UseVisualStyleBackColor = false;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLoginLogin);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(lblLoginPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Margin = new Padding(2);
            Name = "SignUpPage";
            Size = new Size(856, 721);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label lblLoginPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Button btnLoginLogin;
    }
}
