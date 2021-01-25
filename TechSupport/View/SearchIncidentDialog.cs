using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Class used to search all Incidents according to the customerID  
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0-parameter constructor for the SearchIncidentDialog class  
        /// </summary>
        public SearchIncidentDialog()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        /// <summary>
        /// Method to handle the cancel search incident button event  
        /// </summary>
        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
