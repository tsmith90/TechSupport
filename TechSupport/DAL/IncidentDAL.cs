using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        private static List<Incident> incidents = new List<Incident>
        {
            new Incident("Sample", "Incident", 123)
        };

        public List<Incident> GetIncidentCustomerID() 
        {
            return incidents;
        }

        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Movie cannot be null");
            }

            incidents.Add(incident);
        }

    }
}
