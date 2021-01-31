using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
        /// <summary>
        /// 0-parameter constructor for the MainDashBoard class  
        /// </summary>
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
