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
        private List<Technician> technicianList;

        public TechnicianIncidentsUserControl()
        {
            InitializeComponent();
            technicianList = new List<Technician>();
            technicianController = new TechnicianController();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            technicianList = technicianController.GetTechniciansWithIncidents();

            technicianNameComboBox.DataSource = technicianList;
        }

        private void technicianNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (technicianNameComboBox.SelectedIndex < 0)
            {
                return;
            }

            Technician technician = technicianList[technicianNameComboBox.SelectedIndex];

            technicianBindingSource.Clear();
            technicianBindingSource.Add(technician);
        }
    }
}