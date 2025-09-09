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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public event Action goToTimerPage;
        private void btnSubject1_Click(object sender, EventArgs e)
        {
            goToTimerPage?.Invoke();

        }

        private void btnSubject2_Click(object sender, EventArgs e)
        {
            goToTimerPage?.Invoke();
        }

        private void btnSubject3_Click(object sender, EventArgs e)
        {
            goToTimerPage?.Invoke();
        }
    }
}
