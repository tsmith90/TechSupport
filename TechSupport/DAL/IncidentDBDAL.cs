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
                connection.Close();
            }

            return incidentList; 
        }

        /// <summary>
        /// Method to read get the Customer names data from the TechSupport DB
        /// </summary>
        /// <returns>List of customers</returns>
        public List<string> GetCustomers()
        {
            List<string> customers = new List<string> {};

            string selectStatement = "SELECT Name FROM Customers;";

            using (SqlConnection connection = IncidentDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           string name = reader["Name"].ToString();
                           customers.Add(name);
                        }
                    }
                }
                connection.Close();
            }

            return customers;
        }

        /// <summary>
        /// Method to read get the Product names data from the TechSupport DB
        /// </summary>
        /// <returns>List of products</returns>
        public List<string> GetProducts()
        {
            List<string> products = new List<string> { "hello", "bye", "stuff" };
            return products;
        }
    }
}
