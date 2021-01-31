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

namespace TechSupport.UserControls
{
    public partial class AddIncidentUserControl : UserControl
    {
        private IncidentController incidentController;

        /// <summary>
        /// 0-parameter constructor for the AddIncidentDialog class    
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        /// <summary>
        /// Event handler for the add button   
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var title = titleTextBox.Text;
                var description = descriptionTextBox.Text;
                int customerID = int.Parse(customerIDTextBox.Text);

                incidentController.AddIncident(title, description, customerID);
                ClearControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with your input!!! \n" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for the cancel button   
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void ClearControl() 
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            customerIDTextBox.Text = "";
        }
    }
}
