using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Class to display all Incidents from the Incident list    
    /// </summary>
    public partial class AllIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// 0-parameter constructor for the MainForm class   
        /// </summary>
        public AllIncidentsUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
            RefreshDataGrid();
        }

        private void Incident_FormEntered(object sender, System.EventArgs e)
        {
            RefreshDataGrid();
        }

        /// <summary>
        /// Method to refresh the data grid in the MainForm
        /// </summary>
        public void RefreshDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = incidentController.GetIncidents();
        }
    }
}
