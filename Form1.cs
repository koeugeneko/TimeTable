namespace TimeTable
{
    public partial class Form1 : Form
    {   
        
        bool isPanelVisible = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (!isPanelVisible)
            {
                flowLayoutPanel1.Show();
                isPanelVisible = true;
            }
            else
            {
                flowLayoutPanel1.Hide();
                isPanelVisible = false;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
