﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
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
                "LEFT JOIN Technicians t on i.TechID = t.TechID " +
                "LEFT JOIN Customers c on i.CustomerID = c.CustomerID " +
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
            List<string> products = new List<string> {};

            string selectStatement = "SELECT Name FROM Products;";

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
                            products.Add(name);
                        }
                    }
                }
                connection.Close();
            }

            return products;
        }

        /// <summary>
        /// Method to insert a new Incident into the TechSupport DB
        /// </summary>
        public void AddIncident(Incident incident)
        {
            if(CheckCustomerHistory(incident.CustomerName, incident.ProductName))
            {
                MessageBox.Show("Good");
            }
        }

        private bool CheckCustomerHistory(String name, String product)
        {
            String query =
                "SELECT count(r.CustomerID) " +
                "FROM Registrations r " +
                "LEFT JOIN Products p on r.ProductCode = p.ProductCode " +
                "LEFT JOIN Customers c on c.CustomerID = r.CustomerID " +
                "WHERE c.Name = @name and p.Name = @product;";

            using (SqlConnection connection = IncidentDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@name"].Value = name;

                    cmd.Parameters.Add("@product", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@product"].Value = product;

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if(count > 0)
                    {
                        return true;
                    }
                }

                connection.Close();
            }


            return false; ;
        }
    }
}
