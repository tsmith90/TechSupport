using System;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    public partial class technicianIncidentsUserControl : UserControl
    {
        public technicianIncidentsUserControl()
        {
            InitializeComponent();
        }

        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.techniciansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupportDataSet);

        }

        private void Form_Load(object sender, EventArgs e)
        {
            Fill_Form();
        }

        public void Fill_Form()
        {

            this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);
        }
    
    }
}
