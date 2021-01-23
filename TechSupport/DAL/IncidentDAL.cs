using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private static List<Incident> incidents = new List<Incident>
        {
            new Incident("Sample", "Incident", 123)
        };

        /// <summary>
        /// Method return the list of stored Incident objects  
        /// </summary>
        public List<Incident> GetIncidents() 
        {
            return incidents;
        }

        /// <summary>
        /// Method to add an Incident object
        /// </summary>
        /// <param name = "incident">preformatted object to be added to the incidents list.</param> 
        public void AddIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            incidents.Add(incident);
        }

    }
}
