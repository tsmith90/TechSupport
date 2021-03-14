using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class TechnicianIncidentsUserControl : UserControl
    {
        private TechnicianController technicianController;
        private IncidentController incidentController;
        private List<Technician> technicianList;
        private List<Incident> incidentsList;

        public TechnicianIncidentsUserControl()
        {
            InitializeComponent();
            technicianController = new TechnicianController();
            incidentController = new IncidentController();
            technicianList = new List<Technician>();
            incidentsList = new List<Incident>();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            technicianList = technicianController.GetTechniciansWithIncidents();

            technicianNameComboBox.DataSource = technicianList;
        }

        private void TechnicianNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                int techID = technicianList[technicianNameComboBox.SelectedIndex].TechnicianID;

                if (technicianNameComboBox.SelectedIndex < 0)
                {
                    return;
                }

                incidentBindingSource.DataSource = incidentController.GetIncidentsByTechnician(techID);

                Technician technician = technicianList[technicianNameComboBox.SelectedIndex];

                technicianBindingSource.Clear();
                technicianBindingSource.Add(technician);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}