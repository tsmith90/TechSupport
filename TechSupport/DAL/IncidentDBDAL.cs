using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class IncidentDBDAL
    {
        public List<Incident> GetOpenIncidents()
        {
            List<Incident> incidents = new List<Incident>();

            string selectStatement = "SELECT i.productCode, i.dateOpened, c.name, t.name, i.title" +
                "FROM Incidents i" +
                "left join Customers c on i.CustomerID = c.CustomerID" +
                "left join Technicians t on i.TechID = t.TechID " +
                "WHERE i.dateclosed is null;";

            using (SqlConnection connection = IncidentDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {

                    }
                }
            }
                return incidents; 
        }
    }
}
