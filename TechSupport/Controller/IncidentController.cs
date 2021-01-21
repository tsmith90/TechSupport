using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    class IncidentController
    {
        private IncidentDAL incidentSource;

        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        public List<Incident> getIncidentCustomerID() 
        {
            return this.incidentSource.GetIncidentCustomerID();
        }

        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            this.incidentSource.Add(incident);
        }
    }
}
