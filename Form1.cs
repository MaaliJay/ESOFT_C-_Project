namespace Skills_International
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e) //login button
        {
            if (txt_username.Text == "Admin" && txt_password.Text == "Skills@123")  //username and password validation
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, Please check Username and Password and try again", "Invalid login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e) //clear button
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e) //exit button
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}