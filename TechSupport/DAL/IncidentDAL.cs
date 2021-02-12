using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// DAL class to store the data for Incident objects   
    /// </summary>
    public class IncidentDAL
    {
        private readonly List<Incident> incidents = new List<Incident>();

        /// <summary>
        /// 0-parameter constructor for the IncidentDAL class  
        /// </summary>
        public IncidentDAL()
        { 
        }

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
        /// <param name = "incident">the incident to be added to the incidents table.</param> 
        public void AddIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Please enter a valid incident.");
            }

            incidents.Add(incident);
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

            List<Incident> searchedIncident = new List<Incident>();
            searchedIncident = incidents.FindAll(incident => incident.CustomerID == customerID);

            return searchedIncident;
        }
    }
}
