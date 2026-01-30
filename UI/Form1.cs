using System.Diagnostics;
using System.Windows.Forms;
using Npgsql;
using TimeTable.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeTable
{
    public partial class Form1 : Form
    {
        LoginPage loginpage;
        SignUpPage SignUpPage;
        SideBar sideBar;
        DailyTaskPage dailyTaskPage;
        ReportStatsPage reportStatsPage;
        SettingsPage settingsPage;
        SubjectLibaryPage subjectLibaryPage;
        TaskLibaryPage taskLibaryPage;
        TimerPage timerPage;

        public Form1()
        {
            InitializeComponent();

            loginpage = new LoginPage(); // Initialise user controls
            SignUpPage = new SignUpPage();
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

            sideBar.MinSideBarButtonClicked += MinSideBar; //subscribe to when setting button in sidebar got click
            loginpage.SignUpClicked += LoadSignUpPage;
            sideBar.DailyTaskButtonClicked += loadTimerPage;
            sideBar.ReportStatButtonClicked += LoadReportStatsPage;
            sideBar.SettingButtonClicked += LoadSettingPage;
            sideBar.SubjectLibaryButtonClicked += LoadSubjectLibaryPage;
            sideBar.TaskLibaryButtonClicked += LoadTaskLibaryPage;
        }

        private void MinSideBar()
        {
            if (panelSide.Width >= 150)
            {
                panelSide.Width = 100;
            }
            else
            {
                panelSide.Width = 150;
            }
        }


        private void LoadLoginPage()  // requre the user to login before accessing the app
        {
            panelMain.Controls.Clear();
            loginpage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(loginpage);
            Debug.WriteLine("Login Page Loaded");
        }

        private void LoadSignUpPage()
        {
            panelMain.Controls.Clear();
            SignUpPage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(SignUpPage);
            Debug.WriteLine("Sign Up Page Loaded");
        }

        private void LoadReportStatsPage()
        {
            panelMain.Controls.Clear();
            reportStatsPage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(reportStatsPage);
            Debug.WriteLine("Report / Stats Page Loaded");
        }

        private void LoadSettingPage() 
        {
            panelMain.Controls.Clear();
            settingsPage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(settingsPage);
        }

        private void LoadSubjectLibaryPage()
        {
            panelMain.Controls.Clear();
            subjectLibaryPage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(subjectLibaryPage);
        }

        private void LoadTaskLibaryPage()
        {
            panelMain.Controls.Clear();
            taskLibaryPage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(taskLibaryPage);
        }

        private void loadTimerPage()
        {
            panelMain.Controls.Clear();
            timerPage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(timerPage);
        }

        
    }
}
