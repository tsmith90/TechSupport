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

namespace TechSupport.UserControls
{
    public partial class SearchIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0-parameter constructor for the SearchIncidentDialog class  
        /// </summary>
        public SearchIncidentUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        /// <summary>
        /// Method to handle the cancel search incident button event  
        /// </summary>
        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            incidentDataGridView.DataSource = null;
        }

        /// <summary>
        /// Method to handle the search incident button event  
        /// </summary>
        private void IncidentSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = int.Parse(searchTextBox.Text);
                RefreshDataGrid(customerID);
                searchTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with your input!!! \n" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to refresh the data grid
        /// </summary>
        /// <param name = "customerID">The customerID to be searched in the incident list</param>
        private void RefreshDataGrid(int customerID)
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = incidentController.SearchIncidentsByCustomerID(customerID);
        }
    }
}
