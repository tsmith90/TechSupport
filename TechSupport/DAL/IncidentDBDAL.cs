using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{

    /// <summary>
    /// Class to read and interact with the TechSupport DB for incidents
    /// </summary>
    public class IncidentDBDAL
    {
        /// <summary>
        /// Method to read Incidents without a DateClosed from the TechSupport DB 
        /// </summary>
        /// <returns>List of open Incidents</returns>
        public List<Incident> GetOpenIncidents()
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement =
                "SELECT ProductCode,  DateOpened, c.Name as CustomerName, t.Name as TechName, Title " +
                "FROM Incidents i " +
                "LEFT JOIN Technicians t on i.TechID = t.TechID " +
                "LEFT JOIN Customers c on i.CustomerID = c.CustomerID " +
                "WHERE DateClosed is null;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Incident incident = new Incident();

                            incident.ProductCode = reader["ProductCode"].ToString();
                            incident.DateOpened = (DateTime)reader["DateOpened"];
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

        /// <summary>
        /// Method to read get the Customer names data from the TechSupport DB
        /// </summary>
        /// <returns>List of customers</returns>
        public List<string> GetCustomers()
        {
            List<string> customers = new List<string> { };

            string selectStatement = "SELECT Name FROM Customers;";

            using (SqlConnection connection = DBConnection.GetConnection())
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
            }
            return customers;
        }

        /// <summary>
        /// Method to read get the Technician names data from the TechSupport DB
        /// </summary>
        /// <returns>List of technicians</returns>
        public List<string> GetTechnicians()
        {
            List<string> technicians = new List<string> { };
            technicians.Add("-- Unassigned --");

            string selectStatement = "SELECT Name FROM Technicians;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            technicians.Add(name);
                        }
                    }
                }
            }
            return technicians;
        }

        /// <summary>
        /// Method to read get the Product names data from the TechSupport DB
        /// </summary>
        /// <returns>List of products</returns>
        public List<string> GetProducts()
        {
            List<string> products = new List<string> { };

            string selectStatement = "SELECT Name FROM Products;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            products.Add(name);
                        }
                    }
                }
            }

            return products;
        }

        /// <summary>
        /// Method to insert a new Incident into the TechSupport DB
        /// </summary>
        public void AddIncident(Incident incident)
        {
            String insert =
                "INSERT INTO Incidents (CustomerID, ProductCode, DateOpened, Title, Description) " +
                "SELECT r.CustomerID, r.ProductCode, @date, @title, @description " +
                "FROM Products p " +
                "JOIN Registrations r on p.ProductCode = r.ProductCode " +
                "JOIN Customers c on r.CustomerID = c.CustomerID " +
                "WHERE c.Name = @name and p.Name = @product;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insert, connection))
                {
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@name"].Value = incident.CustomerName;

                    cmd.Parameters.Add("@product", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@product"].Value = incident.ProductName;

                    cmd.Parameters.Add("@date", System.Data.SqlDbType.DateTime);
                    cmd.Parameters["@date"].Value = DateTime.Now;

                    cmd.Parameters.Add("@title", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@title"].Value = incident.Title;

                    cmd.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@description"].Value = incident.Description;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method to retrieve an incident based on the ID from the TechSupport DB
        /// </summary>
        /// <param name = "id">the incident id number in the DB</param>  
        /// <returns>The IncidentDBDal Incident list by id</returns>
        public Incident GetIncidentByID(int id)
        {
            Incident incident = new Incident();

            string selectStatement = "SELECT c.Name as name, i.ProductCode as product,  t.Name as techName, " +
                "i.Title as title, FORMAT (i.DateOpened, 'MM-dd-yyyy') as opened, DateClosed as closed, i.Description as description, i.IncidentID as incident " +
                "FROM Incidents i " +
                "LEFT JOIN Customers c on c.CustomerID = i.CustomerID " +
                "LEFT JOIN Technicians t on t.TechID = i.TechID " +
                "WHERE i.IncidentID = @id ;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@id"].Value = id;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            incident.CustomerName = name;

                            string product = reader["product"].ToString();
                            incident.ProductCode = product;

                            string techName = reader["techName"].ToString();
                            incident.TechnicianName = techName;

                            string title = reader["title"].ToString();
                            incident.Title = title;

                            string opened = reader["opened"].ToString();
                            incident.DateOpened = DateTime.Parse(opened);

                            if(reader["closed"] != DBNull.Value)
                            {
                                incident.DateClosed = (DateTime)reader["closed"];
                            }

                            string description = reader["description"].ToString();
                            incident.Description = description;

                            int incidentId = (int)reader["incident"];
                            incident.IncidentID = incidentId;
                        }
                    }
                }
            }
            return incident;
        }

        /// <summary>
        /// Method to retrieve whether a product had been bought by a customer
        /// </summary>
        /// <param name = "name">the name of the customer in the DB</param>  
        /// <param name = "product">the product supposedly bought by the customer</param>  
        /// <returns>True if there is a customer with a given product</returns>
        public bool CheckCustomerHistory(String name, String product)
        {
            String query =
                "SELECT count(r.CustomerID) " +
                "FROM Registrations r " +
                "LEFT JOIN Products p on r.ProductCode = p.ProductCode " +
                "LEFT JOIN Customers c on c.CustomerID = r.CustomerID " +
                "WHERE c.Name = @name and p.Name = @product;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@name"].Value = name;

                    cmd.Parameters.Add("@product", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@product"].Value = product;

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            return false; ;
        }

        /// <summary>
        /// Method to update an incident in the DB
        /// </summary>
        /// <param name="incident">The incident to be updated in the DB</param>
        public void UpdateIncident(Incident incident)
        {
            string updateIncident = "UPDATE Incidents " +
                "SET Description = @description,  " +
                "TechID = (SELECT distinct(TechID) FROM Technicians WHERE TechID = @tech) " +
                "WHERE IncidentID = @id ;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateIncident, connection))
                {
                    cmd.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@description"].Value = incident.Description;

                    cmd.Parameters.Add("@tech", System.Data.SqlDbType.Int);
                    cmd.Parameters["@tech"].Value = incident.TechnicianID;

                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    cmd.Parameters["@id"].Value = incident.IncidentID;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method to close an incident in the DB
        /// </summary>
        /// <param name="incident">The incident to be closed in the DB</param>
        public void CloseIncident(Incident incident)
        {
            string closeIncident = "UPDATE Incidents SET DateClosed = @date WHERE IncidentID = @id;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(closeIncident, connection))
                {
                    cmd.Parameters.Add("@date", System.Data.SqlDbType.DateTime);
                    cmd.Parameters["@date"].Value = incident.DateClosed;

                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    cmd.Parameters["@id"].Value = incident.IncidentID;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method to get incidents by technician
        /// </summary>
        /// <param name="id">The ID of the technician</param>
        public List<Incident> GetIncidentsByTechnician(int id)
        {
            List<Incident> incidentList = new List<Incident> { };

            string selectStatement = 
                "SELECT p.Name as product, i.DateOpened as date,  c.Name as customer, i.Title as title " +
                "FROM Incidents i JOIN Products p ON i.ProductCode = p.ProductCode " +
                "JOIN Customers c ON  i.CustomerID = c.CustomerID " +
                "WHERE  i.TechID = @id and i.DateClosed is NULL;";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@id"].Value = id;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Incident incident = new Incident();

                            incident.ProductName = reader["product"].ToString();
                            incident.DateOpened = (DateTime)reader["date"];
                            incident.CustomerName = reader["customer"].ToString();
                            incident.Title = reader["title"].ToString();

                            incidentList.Add(incident);
                        }
                    }
                }
            }

            return incidentList;
        }
    }
}

