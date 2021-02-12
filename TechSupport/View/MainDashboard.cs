using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Class to hold and control user controls  
    /// </summary>
    public partial class MainDashboard : Form
    {

        /// <summary>
        /// 0-parameter constructor for the MainDashBoard class  
        /// </summary>
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void MainDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dashboardTabControl.SelectedTab == dashboardTabControl.TabPages["openIncidentsTabPage"])
            {
                this.openIncidentsUserControl1.openIncidentsList();
            }
            else if (dashboardTabControl.SelectedTab == dashboardTabControl.TabPages["addIncidentTabPage"])
            {
                this.addIncidentUserControl1.ClearControl();
            }

        }

        public void SetUserName(string name)
        {
            usernameLabel.Text = name;
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
