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
    class IncidentController
    {
        private IncidentDAL incidentSource;

        /// <summary>
        /// 0-parameter constructor for the IncidentController class  
        /// </summary>
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// Method to get the list of Incidents 
        /// </summary>
        public List<Incident> GetIncidents() 
        {
            return this.incidentSource.GetIncidents();
        }

        /// <summary>
        /// Method to add Incident objects to the application list
        /// </summary>
        /// <param name = "incident">A complete Incident object to be added to the list</param>
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

            this.incidentSource.AddIncident(title, description, customerID);
        }


        /// <summary>
        /// Method to search Incident objects
        /// </summary>
        /// <param name = "customerID">Searches the Incident list for certain objects with a given CustomerID</param>
        public List<Incident> SearchIncidentsByCustomerID(int customerID)
        {
            List<Incident> searchedIncident = new List<Incident>();
            IEnumerable<Incident> getIncidentsByCustomerID = this.incidentSource.GetIncidents().Where(incident => incident.CustomerID == customerID);

            foreach(Incident incident in getIncidentsByCustomerID)
            {
                searchedIncident.Add(incident);
            }

            return searchedIncident;
        }
    }
}
