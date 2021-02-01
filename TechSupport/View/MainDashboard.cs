using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.UserControls;

namespace TechSupport.View
{
    /// <summary>
    /// Class to hold and control user controls  
    /// </summary>
    public partial class MainDashboard : Form
    {
        private IncidentController incidentController;

        /// <summary>
        /// 0-parameter constructor for the MainDashBoard class  
        /// </summary>
        public MainDashboard()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        private void MainDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dashboardTabControl.SelectedTab == dashboardTabControl.TabPages["allIncidentsTabPage"])
            {
                allIncidentsUserControl.RefreshDataGrid();
            }
        }
    }
}
