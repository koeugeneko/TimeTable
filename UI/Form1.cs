using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeTable
{
    public partial class Form1 : Form
    {
        LoginPage loginpage;
        HomePage homePage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeUserControls();
            loadLoginPage();
        }

        private void InitializeUserControls()
        {
            loginpage = new LoginPage(); // Create an instance of the login page
            homePage = new HomePage();
        }

        void loadLoginPage()  // requre the user to login before accessing the app
        {
            panelHome.Controls.Clear();
            loginpage.Dock = DockStyle.Fill;
            panelHome.Controls.Add(loginpage);
        }
    }
}
