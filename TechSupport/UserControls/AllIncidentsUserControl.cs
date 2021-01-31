using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport.UserControls
{
    public partial class AllIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        public LoginForm newLoginForm;

        /// <summary>
        /// 0-parameter constructor for the MainForm class   
        /// </summary>
        public AllIncidentsUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
            RefreshDataGrid();
        }

        /// <summary>
        /// Method to handle the Logout link event   
        /// </summary>
        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newLoginForm = new LoginForm();
            Hide();
            newLoginForm.Show();
            //Close();
        }

        /// <summary>
        /// Method to exit the application when the form is closed   
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Method to refresh the data grid in the MainForm
        /// </summary>
        public void RefreshDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = incidentController.GetIncidents();
        }
    }
}
