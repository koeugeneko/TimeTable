using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable.UI
{
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void DailyTaskButton_Click(object sender, EventArgs e)
        {

        }

        private void TaskLibaryButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportStatButton_Click(object sender, EventArgs e)
        {
        }

        public event Action SettingButtonClicked; //set up a event
        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingButtonClicked?.Invoke(); //set up a event
        }


    }
}
