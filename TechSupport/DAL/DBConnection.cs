﻿using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// Class to establish a connection to the TechSupport DB
    /// </summary>
    public class DBConnection
    {
        /// <summary>
        /// Method to establish a connection to the TechSupport DB
        /// </summary>
        /// <returns>The connection to the database</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
