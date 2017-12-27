using System;
using System.Windows.Forms;

namespace BookSystemWindows
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();

            mainForm.ShowDialog();

            this.Dispose();
        }
    }
}
