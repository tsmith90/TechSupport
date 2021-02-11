using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Controller class for the Incident object  
    /// </summary>
    public class IncidentController
    {
        private static IncidentDAL incidentSource;
        private static IncidentDBDAL incidentDBDAL;

        /// <summary>
        /// 0-parameter constructor for the IncidentController class  
        /// </summary>
        public IncidentController()
        {
            incidentSource = new IncidentDAL();
            incidentDBDAL = new IncidentDBDAL();
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
        /// Method to interact with IncidentDBDal and get the open incidents  
        /// </summary
        /// <returns>The IncidentDBDal open incident list</returns>
        public List<Incident> GetOpenIncidents()
        {
            return incidentDBDAL.GetOpenIncidents();
        }

        /// <summary>
        /// Method to retrieve the customer name list from the DB
        /// </summary
        /// <returns>The IncidentDBDal customers list</returns>
        public List<String> GetCustomers()
        {
            List<String> customers = new List<string> { "hello", "bye", "stuff" };
            return customers;
        }

        /// <summary>
        /// Method to retrieve the product name list from the DB
        /// </summary
        /// <returns>The IncidentDBDal products list</returns>
        public List<String> GetProducts()
        {
            List<String> products = new List<string> { "hello", "bye", "stuff" };
            return products;
        }

        /// <summary>
        /// Method to add Incident objects to the application list
        /// </summary>
        /// <param name = "title">the title string to be added to the incidents list.</param> 
        /// <param name = "description">the description string to be added to the incidents list.</param> 
        /// <param name = "customerID">the customerID int to be added to the incidents list.</param> 
        public void AddIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("incident cannot be null");
            }
            incidentSource.AddIncident(incident);
        }

        /// <summary>
        /// Method to search Incident objects
        /// </summary>
        /// <param name = "customerID">Searches the Incident list for certain objects for a given CustomerID</param>
        /// <returns>A new Incident list of only incidents of a given customerID</returns>
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
