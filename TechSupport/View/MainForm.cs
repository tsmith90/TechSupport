using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        private readonly IncidentController incidentController;
        public LoginForm newLoginForm;

        public MainForm()
        {   
            this.InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newLoginForm = new LoginForm();
            newLoginForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            this.RefreshDataGrid();
            nameLabel.Text = LoginForm.UserName;
        }

        private void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetIncidentCustomerID();
        }

        private void addIncidentButton_Click(object sender, System.EventArgs e)
        {
            Form addIncidentDialog = new AddIncidentDialog();
            DialogResult result = addIncidentDialog.ShowDialog();
        }
    }
}
