using System;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    public partial class ReportUserControl : UserControl
    {
        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            RefreshReport();
        }

        public void RefreshReport()
        {
            this.incidentsTableAdapter.Fill(this.techSupportDataSet.Incidents);

            this.reportViewer.RefreshReport();
        }
    }
}
