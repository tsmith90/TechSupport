using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Class to interact for Customers in the TechSupport DB
    /// </summary
    class CustomerDBDAL
    {
        /// <summary>
        /// Method to read get the Customer names data from the TechSupport DB
        /// </summary>
        /// <returns>List of customers</returns>
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer> { };

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
                            Customer newCustomer = new Customer();

                            string name = reader["Name"].ToString();
                            newCustomer.CustomerName = name;
                            customers.Add(newCustomer);
                        }
                    }
                }
            }
            return customers;
        }
    }
}
