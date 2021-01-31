using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Class to represent a Add Incident form   
    /// </summary>
    public partial class AddIncidentDialog : Form
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0-parameter constructor for the AddIncidentDialog class    
        /// </summary>
        public AddIncidentDialog()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var title = titleTextBox.Text;
                var description = descriptionTextBox.Text;
                int customerID = int.Parse(customerIDTextBox.Text);

                incidentController.AddIncident(title, description, customerID);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with your input!!! \n" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
