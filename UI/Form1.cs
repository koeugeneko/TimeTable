using System.Diagnostics;
using TimeTable.UI;

namespace TimeTable
{
    public partial class Form1 : Form
    {
        LoginPage loginpage;
        SignUpPage SignUpPage;
        SideBar sideBar;
        SideBarTop sideBarTop;
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
            dailyTaskPage = new DailyTaskPage();
            settingsPage = new SettingsPage();
            sideBar = new SideBar();
            sideBarTop = new SideBarTop();
            subjectLibaryPage = new SubjectLibaryPage();
            taskLibaryPage = new TaskLibaryPage();
            timerPage = new TimerPage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLoginPage();
            LoadSideBarButtom();
            LoadSideBarTop();
        }

        private void LoadSideBarButtom()
        {
            panelSideBottom.Controls.Clear();
            sideBar.Dock = DockStyle.Fill;
            panelSideBottom.Controls.Add(sideBar);

            sideBarTop.MinSideBarButtonClicked += MinSideBar; //subscribe to when setting button in sidebar got click
            loginpage.SignUpClicked += LoadSignUpPage;
            sideBar.DailyTaskButtonClicked += LoadDailyTaskPage;
            sideBar.ReportStatButtonClicked += LoadReportStatsPage;
            sideBar.SettingButtonClicked += LoadSettingPage;
            sideBar.SubjectLibaryButtonClicked += LoadSubjectLibaryPage;
            sideBar.TaskLibaryButtonClicked += LoadTaskLibaryPage;
        }
        
        private void LoadSideBarTop()
        {
            panelSideTop.Controls.Clear();
            sideBarTop.Dock = DockStyle.Fill;
            panelSideTop.Controls.Add(sideBarTop);
        }

        private void MinSideBar()
        {
            if (panelSideBottom.Width >= 150) //sidebar
            {
                panelSideBottom.Width = 0;
            }
            else
            {
                panelSideBottom.Width = 150;
            }

            if (panelSide.Width >= 150) // sidebar main
            {
                panelSide.Width = 50;
            }
            else
            {
                panelSide.Width = 150;
            }

            if (panelSideTop.Width >= 150) //sidebar top
            {
                panelSideTop.Width = 50;
            }
            else
            {
                panelSideTop.Width = 150;
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
        private void LoadDailyTaskPage()
        {
            panelMain.Controls.Clear();
            dailyTaskPage.Dock = DockStyle.Fill;
            panelMain.Controls.Add(dailyTaskPage);
            Debug.WriteLine("Daily Task Page Loaded");
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
