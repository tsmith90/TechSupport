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
        #region Data members

        private readonly IncidentController incidentController;

        #endregion
        /// <summary>
        /// 0-parameter constructor for the SearchIncidentDialog class  
        /// </summary>
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// Method to handle the cancel search incident button event  
        /// </summary>
        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Method to handle the search incident button event  
        /// </summary>
        private void incidentSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = int.Parse(this.searchTextBox.Text);
                this.RefreshDataGrid(customerID);
                this.searchTextBox.Text = "";
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
        private void RefreshDataGrid(int id)
        {
            this.incidentDataGridView.DataSource = null;

            ///fix the second part of this statement and add parameter to the comment
            this.incidentDataGridView.DataSource = this.incidentController.SearchIncidentsByCustomerID(id);
        }
    }
}
