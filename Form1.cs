namespace TimeTable
{
    public partial class Form1 : Form
    {

        bool isPanelVisible = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (!string.IsNullOrWhiteSpace(name) && name != "Enter Name")
            {
                MessageBox.Show($"Welcome, {name}!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_click(object sender, EventArgs e)
        {
            if (txtName.Text == "Enter Name")
            {
                txtName.Text = "";
            }
        }


        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
