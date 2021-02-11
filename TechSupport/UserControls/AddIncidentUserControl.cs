﻿using System;
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
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void ClearControl()
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }
    }
}
