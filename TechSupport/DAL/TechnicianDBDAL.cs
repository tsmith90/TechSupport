using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Class to read and interact with the TechSupport DB for technicians
    /// </summary>
    class TechnicianDBDAL
    {
        /// <summary>
        /// Method to read Technicians from the DB and return ones with incidents
        /// </summary>
        /// <returns>List of technicians with open incidents</returns>
        public List<Technician> GetTechniciansWithOpenIncidents()
        {

            List<Technician> technicians = new List<Technician> { };


            string selectStatement = "SELECT distinct(t.Name) as name, t.Email as email, t.Phone as phone, t.TechID as id FROM Technicians t JOIN Incidents i on i.TechID = t.TechID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Technician technician = new Technician();

                            string name = reader["name"].ToString();
                            technician.TechnicianName = name;

                            string email = reader["email"].ToString();
                            technician.TechnicianEmail = email;

                            string phone = reader["phone"].ToString();
                            technician.TechnicianPhone = phone;

                            int id =(int)reader["id"];
                            technician.TechnicianID = id;

                            technicians.Add(technician);
                        }
                    }
                }
            }

            return technicians;
        }

        /// <summary>
        /// Method to read the Technician names data from the TechSupport DB
        /// </summary>
        /// <returns>List of technicians</returns>
        public List<Technician> GetTechnicians()
        {
            List<Technician> technicians = new List<Technician> { };


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
                            Technician technician = new Technician();

                            string name = reader["Name"].ToString();
                            technician.TechnicianName = name;

                            technicians.Add(technician);
                        }
                    }
                }
            }

            return technicians;
        }
    }
}
