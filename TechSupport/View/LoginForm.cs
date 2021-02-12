using System;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport
{   
    /// <summary>
    /// Class to represent a login form   
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly MainDashboard dashboard;

        /// <summary>
        /// 0-parameter constructor for the LoginForm object  
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.dashboard = new MainDashboard();
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            if ((userTextBox.Text == "Jane") &&
                (passwordTextBox.Text == "test1234"))
            {
                dashboard.SetUserName(userTextBox.Text);
                Hide();
                dashboard.ShowDialog();
                userTextBox.Text = "";
                passwordTextBox.Text = "";
                Show();
            }
            else
            {
                errorLabelBox.Text = "invalid username/password";
            }
        }

        private void ClearErrors(object sender, EventArgs e)
        {
            errorLabelBox.Text = "";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
