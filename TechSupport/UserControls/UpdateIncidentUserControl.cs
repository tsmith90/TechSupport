using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

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
            technicianComboBox.Text = "";
            titleTextBox.Text = "";
            dateOpenedTextBox.Text = "";
            descriptionTextBox.Text = "";
            textToAddTextBox.Text = "";
            closeButton.Enabled = false;
            updateButton.Enabled = false;
            textToAddTextBox.ReadOnly = true;
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetTechncicianList();
                Incident incident = GetIncidentByID();

                customerTextBox.Text = incident.CustomerName;
                productTextBox.Text = incident.ProductCode;

                if(String.IsNullOrEmpty(incident.TechnicianName))
                {
                    technicianComboBox.Text = "-- Unassigned --";
                }
                else
                {
                    technicianComboBox.Text = incident.TechnicianName;
                }

                titleTextBox.Text = incident.Title;
                dateOpenedTextBox.Text = incident.DateOpened;
                descriptionTextBox.Text = incident.Description;

                if(String.IsNullOrEmpty(incident.DateClosed))
                {
                    closeButton.Enabled = true;
                    updateButton.Enabled = true;
                    textToAddTextBox.ReadOnly = false;
                    technicianComboBox.Enabled = true;
                }
                else
                {
                    closeButton.Enabled = false;
                    updateButton.Enabled = false;
                    textToAddTextBox.ReadOnly = true;
                    technicianComboBox.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private Incident GetIncidentByID()
        {
            int id = 0;

            try
            {
                id = Int32.Parse(incidentTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Incident ID number!");
            }

            return incidentController.GetIncidentByID(id);
        }
    }
}
