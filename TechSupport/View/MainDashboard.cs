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
        }
    }
}
