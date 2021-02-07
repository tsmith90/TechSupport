using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{

    /// <summary>
    /// Class to read and interact with the TechSupport DB 
    /// </summary>
    class IncidentDBDAL
    {
        /// <summary>
        /// Method to read Incidents without a DateClosed from the TechSupport DB 
        /// </summary>
        /// <returns>List of open Incidents</returns>
        public List<Incident> GetOpenIncidents()
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement = 
                "SELECT ProductCode,  FORMAT (DateOpened, 'MM-dd-yyyy') as Date, c.Name as CustomerName, t.Name as TechName, Title " +
                "FROM Incidents i " +
                "JOIN Technicians t on i.TechID = t.TechID " +
                "JOIN Customers c on i.CustomerID = c.CustomerID " +
                "WHERE DateClosed is null;";

            using (SqlConnection connection = IncidentDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read()) {
                            Incident incident = new Incident();

                            incident.ProductCode = reader["ProductCode"].ToString();
                            incident.DateOpened = reader["Date"].ToString();
                            incident.CustomerName = reader["CustomerName"].ToString();
                            incident.TechnicianName = reader["TechName"].ToString();
                            incident.Title = reader["Title"].ToString();

                            incidentList.Add(incident);
                        }
                    }
                }
            }

            return incidentList; 
        }
    }
}
