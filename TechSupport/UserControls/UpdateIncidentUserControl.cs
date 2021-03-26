using System;
using System.Collections.Generic;
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
        private readonly TechnicianController technicianController;
        private Incident incident;
        private Incident oldIncident;

        /// <summary>
        /// 0-parameter constructor for the SearchIncidentDialog class  
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            incident = new Incident();
            oldIncident = new Incident();
            incidentController = new IncidentController();
            technicianController = new TechnicianController();
        }

        private void SetTechncicianList()
        {
            try
            {
                List<string> technicianList = new List<string> { };
                technicianList.Add("-- Unassigned --");

                foreach (Technician t in technicianController.GetTechnicians())
                {
                    technicianList.Add(t.TechnicianName);
                }

                technicianComboBox.DataSource = technicianList;
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

        /// <summary>
        /// Method to reset all current fields of the user control
        /// </summary>
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
                oldIncident = incident;

                if (String.IsNullOrEmpty(incident.CustomerName))
                {
                    ClearControls();
                    MessageBox.Show("There currently isn't an incident with that id.");
                }
                else
                {
                    SetControls();
                    if (incident.Description.Length >= 200)
                    {
                        MessageBox.Show("Further description can't be added to this incident");
                    }
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
                throw new FormatException("Please enter a valid id number (int)");
            }

            return incidentController.GetIncidentByID(id);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textToAddTextBox.Text) && (technicianComboBox.Text == incident.TechnicianName || technicianComboBox.Text.Equals("-- Unassigned --")))
            {
                MessageBox.Show("Please enter a valid update to the incident!");
            } 
            else if (!descriptionTextBox.Text.Equals(incident.Description))
            {
                MessageBox.Show("The description has been changed incorrectly!");
            }
            else
            {
                string checkDescription = incident.Description + Environment.NewLine + "<" + DateTime.Today.ToString("MM/dd/yyyy") + ">" + textToAddTextBox.Text;
                    
                if (checkDescription.Length > 200)
                {
                    DialogResult dialogResult = MessageBox.Show("Sorry, only 200 letters allowed. Would you like to trim it down to 200?", "The description too big!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        incident.Description = checkDescription.Substring(0, 200);
                        
                        if(!technicianComboBox.Text.Equals("-- Unassigned --"))
                        {
                            incident.TechnicianName = technicianComboBox.Text;
                        }

                        UpdateIncident();
                        SetControls();
                        MessageBox.Show("incident updated");
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(textToAddTextBox.Text))
                    {
                        incident.Description = checkDescription;
                    }
                    incident.TechnicianName = technicianComboBox.Text;
                    UpdateIncident();
                    SetControls();
                    MessageBox.Show("incident updated");
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if(technicianComboBox.Text.Equals("-- Unassigned --"))
            {
                MessageBox.Show("Please assign a technician before closing the incident!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to close this incident?", "Confirm Incident Closure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    incident.DateClosed = DateTime.Now;
                    CloseIncident();
                }
            }
        }

        private void CloseIncident()
        {
            try
            {
                if (incidentController.CloseIncident(incident, oldIncident))
                {
                    MessageBox.Show("incident closed");
                    closeButton.Enabled = false;
                    updateButton.Enabled = false;
                    textToAddTextBox.ReadOnly = true;
                    technicianComboBox.Enabled = false;
                }
                else
                {
                    MessageBox.Show("incident could not be closed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void UpdateIncident()
        {
            try
            {
                incidentController.UpdateIncident(incident);
                oldIncident = incident;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SetControls()
        {
            SetTechncicianList();
            customerTextBox.Text = incident.CustomerName;
            productTextBox.Text = incident.ProductCode;
            textToAddTextBox.Text = "";

            if (String.IsNullOrEmpty(incident.TechnicianName))
            {
                technicianComboBox.Text = "-- Unassigned --";
            }
            else
            {
                technicianComboBox.Text = incident.TechnicianName;
            }

            titleTextBox.Text = incident.Title;
            dateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
            descriptionTextBox.Text = incident.Description;

            if (incident.DateClosed.ToString().Equals("1/1/0001 12:00:00 AM"))
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

            if (incident.Description.Length >= 200)
            {
                textToAddTextBox.ReadOnly = true;
            }
        }
    }
}
