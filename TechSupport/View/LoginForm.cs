using System;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport

    public partial class LoginForm : Form
    {
        public static string UserName { get; set; }
        public static MainForm mainForm;

        public LoginForm()
        {
            InitializeComponent();
            mainForm = new MainForm();
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            if ((userTextBox.Text == "Jane") &&
                (passwordTextBox.Text == "test1234"))
            {
                UserName = userTextBox.Text;
                this.Hide();
                mainForm.Show();
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
