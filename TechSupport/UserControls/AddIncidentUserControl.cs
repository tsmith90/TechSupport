using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport.UserControls
{
    public partial class AddIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0-parameter constructor for the AddIncidentDialog class    
        /// </summary>
        public AddIncidentUserControl()
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

                if (!int.TryParse(customerIDTextBox.Text, out int customerID))
                {
                    throw new ArgumentOutOfRangeException("customerID must be a valid number");
                }

                incidentController.AddIncident(title, description, customerID);
                ClearControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void ClearControl() 
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            customerIDTextBox.Text = "";
        }
    }
}
