using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Class to represent a Main form used to add or search incidents  
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IncidentController incidentController;
        public LoginForm newLoginForm; 

        /// <summary>
        /// 0-parameter constructor for the MainForm class   
        /// </summary>
        public MainForm()
        {   
            InitializeComponent();
            incidentController = new IncidentController();
        }

        /// <summary>
        /// Method to handle the Logout link event   
        /// </summary>
        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newLoginForm = new LoginForm();
            Hide();
            newLoginForm.ShowDialog();
            Close();
        }

        /// <summary>
        /// Method to exit the application when the form is closed   
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Method for MainForm load event  
        /// </summary>
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            RefreshDataGrid();
            nameLabel.Text = LoginForm.UserName;
        }

        /// <summary>
        /// Method to refresh the data grid in the MainForm
        /// </summary>
        private void RefreshDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = incidentController.GetIncidents();
        }

        /// <summary>
        /// Method to handle the Add Incident button event  
        /// </summary>
        private void AddIncidentButton_Click(object sender, System.EventArgs e)
        {
            Form addIncidentDialog = new AddIncidentDialog();
            DialogResult result = addIncidentDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                RefreshDataGrid();
            }
        }

        /// <summary>
        /// Method to handle the Search Incident button event   
        /// </summary>
        private void SearchIncidentButton_Click(object sender, System.EventArgs e)
        {
            Form searchIncidentDialog = new SearchIncidentDialog();
            _ = searchIncidentDialog.ShowDialog();
        }
    }
}
