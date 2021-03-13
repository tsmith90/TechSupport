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
            if (technicianTabControl.SelectedTab == technicianTabControl.TabPages["openIncidentsTabPage"])
            {
                this.openIncidentsUserControl1.OpenIncidentsList();
            }
            else if (technicianTabControl.SelectedTab == technicianTabControl.TabPages["addIncidentTabPage"])
            {
                this.addIncidentUserControl1.ClearControl();
            }
            else if (technicianTabControl.SelectedTab == technicianTabControl.TabPages["updateIncidentTabPage"])
            {
                this.updateIncidentUserControl1.ClearControls();
            }
        }


        /// <summary>
        /// Sets the username label from the login form
        /// </summary>
        public void SetUserName(string name)
        {
            usernameLabel.Text = name;
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
        }
    }
}
