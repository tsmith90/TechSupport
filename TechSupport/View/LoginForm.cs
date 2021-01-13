using System;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport
{
    public partial class LoginForm : Form
    {
        public static string UserName { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            if ((userTextBox.Text == "Jane") &&
                (passwordTextBox.Text == "test1234"))
            {
                UserName = userTextBox.Text;
                this.Hide();
                var mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                errorTextBox.Text = "invalid username/password";
            }
        }

        private void ClearErrors(object sender, EventArgs e)
        {
            errorTextBox.Text = "";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
