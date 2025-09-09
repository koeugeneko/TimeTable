using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class LoginPage : UserControl
    {
        string username;
        string password;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        public event Action goToHomePage;
        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            //sould add a loading screen here
            username = txtUsername.Text;
            password = txtPassword.Text;

            goToHomePage?.Invoke();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Set focus to the username label when login page loads - workaround for text box focus issue
            this.BeginInvoke(new Action(() =>
            {
                lblUsername.Focus(); 
            }));
        }
    }
}
