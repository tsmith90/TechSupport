using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// UserControl class to search Incidents
    /// </summary>
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

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            incidentDataGridView.DataSource = null;
        }

        private void IncidentSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID;

                if (!int.TryParse(searchTextBox.Text, out customerID))
                {
                    throw new ArgumentOutOfRangeException("customerID must be a valid number");
                }

                RefreshDataGrid(customerID);
                searchTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to refresh the data grid
        /// </summary>
        /// <param name = "customerID">The customerID to be searched in the incident list (must be greater than 0)</param>
        private void RefreshDataGrid(int customerID)
        {
            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Please enter a valid number!!! \n");
            }

            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = incidentController.SearchIncidentsByCustomerID(customerID);
        }
    }
}
