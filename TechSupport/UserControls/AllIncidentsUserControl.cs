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

        /// <summary>
        /// Method to refresh the data grid
        /// </summary>
        public void RefreshDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = incidentController.GetIncidents();
        }
    }
}
