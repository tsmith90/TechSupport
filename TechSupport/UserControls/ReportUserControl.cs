using System;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Class for the ReportsUserControl tab 
    /// </summary>
    public partial class ReportUserControl : UserControl
    {
        /// <summary>
        /// 0-parameter constructor for the ReportUserControl class
        /// </summary>
        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            RefreshReport();
        }

        /// <summary>
        /// Method to pull and update the report data
        /// </summary>
        public void RefreshReport()
        {
            this.incidentsTableAdapter.Fill(this.techSupportDataSet.Incidents);

            this.reportViewer.RefreshReport();
        }
    }
}
