using System;
using System.Windows.Forms;


namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            nameLabel.Text = LoginForm.UserName;
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm newLoginForm = new LoginForm();
            newLoginForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
