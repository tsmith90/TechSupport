using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
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

        /// <summary>
        /// Method to exit the application when the form is closed   
        /// </summary>
        private void MainDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
