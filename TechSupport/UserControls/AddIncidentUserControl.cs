using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Usercontrol class to add incidents to the Incident list    
    /// </summary>
    public partial class AddIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        private readonly CustomerController customerController;

        /// <summary>
        /// 0-parameter constructor for the AddIncidentDialog class    
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
            customerController = new CustomerController();
            SetNameList();
            SetProductList();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        /// <summary>
        /// Method to clear the user form     
        /// </summary>
        public void ClearControl()
        {
            if (customerComboBox.SelectedIndex != -1)
            {
                customerComboBox.SelectedIndex = 0;
            }

            if (productComboBox.SelectedIndex != -1)
            {
                productComboBox.SelectedIndex = 0;
            }

            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void SetNameList()
        {
            try
            {
                List<string> customerList = new List<string>();

                foreach(Customer c in customerController.GetCustomers())
                {
                    customerList.Add(c.CustomerName);
                }

                customerComboBox.DataSource = customerList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SetProductList()
        {
            try
            {
                productComboBox.DataSource = incidentController.GetProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(titleTextBox.Text))
                {
                    throw new Exception("Title cannot be empty");
                }
                else if (String.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    throw new Exception("Description cannot be empty");
                }

                if (incidentController.AddIncident(customerComboBox.SelectedValue.ToString(), productComboBox.SelectedValue.ToString(), titleTextBox.Text, descriptionTextBox.Text))
                {
                    MessageBox.Show("The incident has been added to the database.");
                }
                else
                {
                    MessageBox.Show("There is no registration associated with the product.");
                }
                ClearControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
