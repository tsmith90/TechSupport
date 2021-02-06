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

            string selectStatement = "SELECT * " +
                "FROM Incidents " +

                ";";

            using (SqlConnection connection = IncidentDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read()) {
                            Incident incident = new Incident();

                            incident.CustomerID = (int)reader["CustomerID"];
                            incident.Title = reader["Title"].ToString();
                            incident.Description = reader["Description"].ToString();
                            incident.TechnicianName = reader["TechID"].ToString();
                            incident.CustomerName = reader["CustomerID"].ToString();
                            incident.DateOpened = reader["DateOpened"].ToString();
                            incident.ProductCode = reader["ProductCode"].ToString();

                            incidentList.Add(incident);
                        }
                    }
                }
            }

            return incidentList; 
        }
    }
}
