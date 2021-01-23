using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Model for the Incident object
    /// </summary>
    public class Incident
    {
        public string Title { get; }

        public string Description { get; }

        public int CustomerID { get; }

        /// <summary>
        /// Method to handle the Add Incident button event  
        /// </summary>
        /// <param name = "title">The title of the incident</param>
        /// <param name = "description">The description of the incident</param> 
        /// <param name = "customerID">The customerID of the incident (int)</param> 
        public Incident(string title, string description, int customerID)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Incident title cannot be null or empty", "title");
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Incident description cannot be null or empty", "description");
            }

            if(customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "CustomerID must be a positive number");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerID;
        }
    }
}
