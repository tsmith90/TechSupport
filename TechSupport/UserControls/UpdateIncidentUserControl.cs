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
        private Incident incident;

        /// <summary>
        /// 0-parameter constructor for the SearchIncidentDialog class  
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            incident = new Incident();
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

        public void ClearControls()
        {
            incidentTextBox.Text = "";
            customerTextBox.Text = "";
            productTextBox.Text = "";
            technicianComboBox.DataSource = null;
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
                incident = GetIncidentByID();

                if (String.IsNullOrEmpty(incident.DateOpened))
                {
                    ClearControls();
                    MessageBox.Show("There currently isn't an incident with that id.");
                }
                else
                {
                    SetControls();
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textToAddTextBox.Text) && (technicianComboBox.Text == incident.TechnicianName || technicianComboBox.Text.Equals("-- Unassigned --")))
            {
                MessageBox.Show("Please enter a valid update to the incident!");
            }
            else
            {
                string checkDescription = incident.Description + Environment.NewLine + "<" + DateTime.Today.ToString("MM/dd/yyyy") + ">" + textToAddTextBox.Text;
                    
                if ((incident.Description + "\n" + ) <= 200)
                {
                    this.incidentController.UpdateIncident(incident);
                    SetControls();
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }

        private void SetControls()
        {
            SetTechncicianList();
            customerTextBox.Text = incident.CustomerName;
            productTextBox.Text = incident.ProductCode;
            textToAddTextBox.Text = "";

            if(incident.Description.Length >= 200)
            {
                MessageBox.Show("Further description can't be added to this incident");
                textToAddTextBox.ReadOnly = true;
            }

            if (String.IsNullOrEmpty(incident.TechnicianName))
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

            if (String.IsNullOrEmpty(incident.DateClosed))
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
    }
}
