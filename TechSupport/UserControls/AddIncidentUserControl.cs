﻿using System;
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

        /// <summary>
        /// 0-parameter constructor for the AddIncidentDialog class    
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
            SetNameList();
            SetProductList();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void ClearControl()
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
            customerComboBox.DataSource = incidentController.GetCustomers();
        }

        private void SetProductList()
        {
            productComboBox.DataSource = incidentController.GetProducts();
        }
    }
}
