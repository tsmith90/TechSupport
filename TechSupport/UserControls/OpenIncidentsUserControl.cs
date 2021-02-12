using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Class for the OpenIncidents tab 
    /// </summary>
    public partial class OpenIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0-parameter constructor for the OpenIncidentsUserControl class
        /// </summary>
        public OpenIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// Method to format and add open incidents to the ListView
        /// </summary>
        public void OpenIncidentsList()
        {
            openIncidentsListView.Items.Clear();
            List<Incident> incidentsList;

            try
            {
                incidentsList = this.incidentController.GetOpenIncidents();

                if (incidentsList.Count > 0)
                {
                    Incident incident;

                    for (int i = 0; i < incidentsList.Count; i++)
                    {
                        incident = incidentsList[i];

                        openIncidentsListView.Items.Add(incident.ProductCode);
                        openIncidentsListView.Items[i].SubItems.Add(incident.DateOpened);
                        openIncidentsListView.Items[i].SubItems.Add(incident.CustomerName);
                        openIncidentsListView.Items[i].SubItems.Add(incident.TechnicianName);
                        openIncidentsListView.Items[i].SubItems.Add(incident.Title);
                    }
                }
                else
                {
                    MessageBox.Show("There are no open incidents at this time.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
