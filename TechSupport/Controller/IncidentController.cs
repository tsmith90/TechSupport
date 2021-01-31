using System;
using System.Collections.Generic;
using System.Linq;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Controller class for the Incident object  
    /// </summary>
    public class IncidentController
    {
        private IncidentDAL incidentSource { get; set; }

        /// <summary>
        /// 0-parameter constructor for the IncidentController class  
        /// </summary>
        public IncidentController()
        {
            incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// Method to get the list of Incidents 
        /// </summary>
        /// <returns>The Incident list</returns>
        public List<Incident> GetIncidents() 
        {
            return incidentSource.GetIncidents();
        }

        /// <summary>
        /// Method to add Incident objects to the application list
        /// </summary>
        /// <param name = "title">the title string to be added to the incidents list.</param> 
        /// <param name = "description">the description string to be added to the incidents list.</param> 
        /// <param name = "customerID">the customerID int to be added to the incidents list.</param> 
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

            incidentSource.AddIncident(title, description, customerID);
        }

        /// <summary>
        /// Method to search Incident objects
        /// </summary>
        /// <param name = "customerID">Searches the Incident list for certain objects for a given CustomerID</param>
        /// <returns>A new Incident list of the only incidents of a given customerID</returns>
        public List<Incident> SearchIncidentsByCustomerID(int customerID)
        {
            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID must be a positive number");
            }

            return incidentSource.SearchIncidentsByCustomerID(customerID);
        }
    }
}
