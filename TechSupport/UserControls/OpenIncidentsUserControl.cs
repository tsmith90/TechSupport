using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class OpenIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        public OpenIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }


        public void openIncidentsList()
        {
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
