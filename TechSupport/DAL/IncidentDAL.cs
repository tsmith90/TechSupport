﻿using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// DAL class to store the data for Incident objects   
    /// </summary>
    public class IncidentDAL
    {
        /// <summary>
        /// The list of currently stored Incident objects   
        /// </summary>
        private List<Incident> incidents = new List<Incident>
        {
            new Incident("CS6232", "Incident Sample", 001)
        };

        /// <summary>
        /// Method return the list of stored Incident objects  
        /// </summary>
        /// <returns>The incident list</returns>
        public List<Incident> GetIncidents() 
        {
            return incidents;
        }

        /// <summary>
        /// Method to add an Incident object
        /// </summary>
        /// <param name = "title">the title string to be added to the incidents list.</param> 
        /// <param name = "description">the description string to be added to the incidents list.</param> 
        /// <param name = "incident">the customerID int to be added to the incidents list.</param> 
        public void AddIncident(string title, string description, int customerID)
        {
            if (title == null)
            {
                throw new ArgumentNullException("title cannot be null");
            }
            else if (description == null)
            {
                throw new ArgumentNullException("description cannot be null");
            }
            else if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID must be a positive number");
            }

            incidents.Add(new Incident(title, description, customerID));
        }
    }
}
