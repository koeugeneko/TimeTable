using System.Windows.Forms;
using Npgsql;

namespace TimeTable
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadLoginPage();
        }

        void loadLoginPage()  // requre the user to login before accessing the app
        {
            panelHome.Controls.Clear();
            LoginPage loginpage = new LoginPage(); // Create an instance of the login page
            panelHome.Controls.Add(loginpage);

            loginpage.goToHomePage += () => loadHomePage(); // Subscribe to the event to load the home page after login

        }

        public void loadHomePage()
        {
            panelHome.Controls.Clear();
            HomePage homePage = new HomePage();
            panelHome.Controls.Add(homePage);
        }

        

    }
}
