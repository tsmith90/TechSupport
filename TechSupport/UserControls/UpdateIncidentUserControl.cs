using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// UserControl class to search Incidents
    /// </summary>
    public partial class UpdateIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0-parameter constructor for the SearchIncidentDialog class  
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
            SetTechncicianList();
        }

        private void SetTechncicianList()
        {
            try
            {
                technicianComboBox.DataSource = incidentController.GetTechnicians();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        protected void ClearControls()
        {
            incidentTextBox.Text = "";
            customerTextBox.Text = "";
            productTextBox.Text = "";
            technicianComboBox.Text = "-- Unassigned --";
            titleTextBox.Text = "";
            dateOpenedTextBox.Text = "";
            descriptionTextBox.Text = "";
            textToAddTextBox.Text = "";
        }
    }
}
