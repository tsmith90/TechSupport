using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class IncidentDBDAL
    {
        public List<Incident> GetOpenIncidents()
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement = "SELECT ProductCode,  DateOpened, c.Name as CustomerName, t.Name as TechName, Title " +
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
                            incident.DateOpened = reader["DateOpened"].ToString();
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
