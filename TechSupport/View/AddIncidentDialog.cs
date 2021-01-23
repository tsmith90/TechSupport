using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Class to represent a Add Incident form   
    /// </summary>
    public partial class AddIncidentDialog : Form
    {
        #region Data members

        private readonly IncidentController incidentController;

        #endregion

        #region Constructors

        /// <summary>
        /// 0-parameter constructor for the AddIncidentDialog class    
        /// </summary>
        public AddIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Event handler for the add button   
        /// </summary>
        private void AddButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.incidentController.AddIncident(new Incident(title, description, customerID));
                this.DialogResult = DialogResult.OK;
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
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
