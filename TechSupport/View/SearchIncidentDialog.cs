using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Class used to search all Incidents according to the customerID  
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        /// <summary>
        /// 0-parameter constructor for the SearchIncidentDialog class  
        /// </summary>
        public SearchIncidentDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to handle the cancel search incident button event  
        /// </summary>
        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
