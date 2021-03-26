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
        private static IncidentDBDAL incidentDBDAL;

        /// <summary>
        /// 0-parameter constructor for the IncidentController class  
        /// </summary>
        public IncidentController()
        {
            incidentDBDAL = new IncidentDBDAL();
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
        /// Method to retrieve the product name list from the DB
        /// </summary
        /// <returns>The IncidentDBDal products list</returns>
        public List<string> GetProducts()
        {
            return incidentDBDAL.GetProducts();
        }

        /// <summary>
        /// Method to retrieve an incident based on the ID from the TechSupport DB
        /// </summary
        /// <param name = "id">the incident id number in the DB</param>  
        /// <returns>The IncidentDBDal Incident list by id</returns>
        public Incident GetIncidentByID(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Please enter a valid Incident ID.");
            }

            return incidentDBDAL.GetIncidentByID(id);
        }

        /// <summary>
        /// Method to add Incidents to the DB
        /// </summary>
        /// <param name = "name">the customer's name</param> 
        /// <param name = "product">the product name</param> 
        /// <param name = "title">the title of the incident</param> 
        /// <param name = "description">the description of the incident</param> 
        /// <returns>True if and incident is successfully added</returns>
        public bool AddIncident(string name, string product, string title, string description)
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

            if(incidentDBDAL.CheckCustomerHistory(name, product))
            {
                incidentDBDAL.AddIncident(incident);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method to update a given Incident object
        /// </summary>
        /// <param name = "incident">The incident to be updated in the DB</param> 
        /// <param name = "oldIncident">The incident to be checked in the DB for continuity</param>
        /// <returns>True if and incident is successfully updated</returns>
        public bool UpdateIncident(Incident incident, Incident oldIncident)
        {
            if (incident == null || oldIncident == null)
            {
                throw new ArgumentNullException("Please enter a valid incident.");
            }

            return incidentDBDAL.UpdateIncident(incident, oldIncident);
        }

        /// <summary>
        /// Method to close a given Incident object
        /// </summary>
        /// <param name = "incident">The incident to be closed in the DB</param> 
        /// <param name = "oldIncident">The incident to be checked in the DB for continuity</param> 
        /// <returns>True if and incident is successfully closed</returns>
        public bool CloseIncident(Incident incident, Incident oldIncident)
        {
            if (incident == null || oldIncident == null)
            {
                throw new ArgumentNullException("Please enter a valid incident.");
            }

            return incidentDBDAL.CloseIncident(incident, oldIncident);
        }

        /// <summary>
        /// Method to get open incidents assigned to each technician
        /// </summary>
        /// <param name = "id">The ID of the technician</param> 
        /// <returns>a list of open incidents by a techID</returns>
        public List<Incident> GetOpenIncidentsByTechnician(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Please enter a valid Incident ID.");
            }

            return incidentDBDAL.GetIncidentsByTechnician(id);
        }
    }
}
