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

            string selectStatement = "SELECT i.productCode, i.dateOpened, c.name as customerName, t.name as technicianName, i.title" +
                "FROM Incidents i" +
                "left join Customers c on i.CustomerID = c.CustomerID" +
                "left join Technicians t on i.TechID = t.TechID " +
                "WHERE i.dateclosed is null;";

            using (SqlConnection connection = IncidentDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        Incident incident = new Incident();

                        incident.ProductCode = reader["ProductCode"].ToString();

                        incidentList.Add(incident);
                    }
                }
            }

            return incidentList; 
        }
    }
}
