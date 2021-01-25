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
        public static string UserName { get; set; }
        public static MainForm mainForm;

        /// <summary>
        /// 0-parameter constructor for the LoginForm object  
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to trigger event when LoginButton is used  
        /// </summary>
        private void LoginButtonClick(object sender, EventArgs e)
        {
            if ((userTextBox.Text == "Jane") &&
                (passwordTextBox.Text == "test1234"))
            {
                mainForm = new MainForm();
                UserName = userTextBox.Text;
                Hide();
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                errorLabelBox.Text = "invalid username/password";
            }
        }

        /// <summary>
        /// Clears the error text label when the user makes a change
        /// </summary>
        private void ClearErrors(object sender, EventArgs e)
        {
            errorLabelBox.Text = "";
        }

        /// <summary>
        /// Method to exit the application when the form is closed   
        /// </summary>
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
