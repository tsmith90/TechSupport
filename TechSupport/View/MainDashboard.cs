using System.Windows.Forms;
using TechSupport.UserControls;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to exit the application when the form is closed   
        /// </summary>
        private void MainDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
