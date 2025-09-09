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
            // requre the user to login before accessing the app
            LoginPage loginpage = new LoginPage(); // Create an instance of the login page
            panelHome.Controls.Clear();
            panelHome.Controls.Add(loginpage);
        }

        public void loadHomePage()
        {
            panelHome.Controls.Clear();
            //HomePage homePage = new HomePage();
            //panelHome.Controls.Add(homePage);
        }
    }
}
