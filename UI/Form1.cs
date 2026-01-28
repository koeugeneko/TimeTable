using System.Windows.Forms;
using Npgsql;
using TimeTable.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeTable
{
    public partial class Form1 : Form
    {
        LoginPage loginpage;
        ReportStatsPage reportStatsPage;
        SettingsPage settingsPage;
        SideBar sideBar;
        SubjectLibaryPage subjectLibaryPage;
        TaskLibaryPage taskLibaryPage;
        TimerPage timerPage;

        public Form1()
        {
            InitializeComponent();

            loginpage = new LoginPage(); // Initialise user controls
            reportStatsPage = new ReportStatsPage();
            settingsPage = new SettingsPage();
            sideBar = new SideBar();
            subjectLibaryPage = new SubjectLibaryPage();
            taskLibaryPage = new TaskLibaryPage();
            timerPage = new TimerPage();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLoginPage();
            LoadSideBar();
        }

        private void LoadSideBar()  
        {
            panelSide.Controls.Clear();
            sideBar.Dock = DockStyle.Fill;
            panelSide.Controls.Add(sideBar);

            sideBar.SettingButtonClicked += LoadSettingPage; //subscribe to when setting button in sidebar got click
        }

        protected void LoadLoginPage()  // requre the user to login before accessing the app
        {
            panelMain.Controls.Clear();
            loginpage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(loginpage);
        }
        public void LoadSettingPage()  // requre the user to login before accessing the app
        {
            panelMain.Controls.Clear();
            settingsPage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(settingsPage);
        }
    }
}
