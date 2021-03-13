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
            if (technicianNameComboBox.SelectedIndex < 0)
            {
                return;
            }

            Technician technician = technicianList[technicianNameComboBox.SelectedIndex];
            SetIncidentsView(technicianNameComboBox.SelectedIndex);
            
            technicianBindingSource.Clear();
            technicianBindingSource.Add(technician);
        }

        private void SetIncidentsView(int id)
        {
            incidentsList = incidentController.GetIncidentsByTechnician(id);
            incidentDataGridView.DataSource = incidentsList;
        }
    }
}