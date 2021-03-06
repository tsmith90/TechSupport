﻿using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Controller class for the Technician object  
    /// </summary>
    class TechnicianController
    {
        private static TechnicianDBDAL technicianDBDAL;

        /// <summary>
        /// Constructor for the TechnicianController class
        /// </summary>
        public TechnicianController()
        {
            technicianDBDAL = new TechnicianDBDAL();
        }

        /// <summary>
        /// Method to get the Technician list with incidents populated in the DBDAL
        /// </summary>
        /// <returns>List of technicians with incidents</returns>
        public List<Technician> GetTechniciansWithOpenIncidents()
        {
            return technicianDBDAL.GetTechniciansWithOpenIncidents();
        }

        /// <summary>
        /// Method to get the full Technician list populated in the DBDAL
        /// </summary>
        /// <returns>List of all technicians</returns>
        public List<Technician> GetTechnicians()
        {
            return technicianDBDAL.GetTechnicians();
        }
    }
}
