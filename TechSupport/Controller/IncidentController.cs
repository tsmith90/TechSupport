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
        public List<string> GetCustomers()
        {  
            return incidentDBDAL.GetCustomers();
        }

        /// <summary>
        /// Method to retrieve the product name list from the DB
        /// </summary
        /// <returns>The IncidentDBDal products list</returns>
        public List<string> GetProducts()
        {
            return incidentDBDAL.GetProducts();
        }

        /// <summary>
        /// Method to add Incidents to the DB
        /// </summary>
        /// <param name = "name">the customer's name</param> 
        /// <param name = "product">the product name</param> 
        /// <param name = "title">the title of the incident</param> 
        /// <param name = "description">the description of the incident</param> 
        public void AddIncident(string name, string product, string title, string description)
        {
            Incident incident = new Incident();

            if (name == null || product == null || title == null || description == null)
            {
                throw new ArgumentNullException("Field are not allowed to be empty or null.");
            }

            incident.CustomerName = name;
            incident.ProductName = product;
            incident.Title = title;
            incident.Description = description;

            incidentDBDAL.AddIncident(incident);
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
