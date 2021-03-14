using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Class to controller interaction with Customers in the DB
    /// </summary
    class CustomerController
    {
        private static CustomerDBDAL customerDBDAL;

        /// <summary>
        /// Constructor for the CustomerController class
        /// </summary
        public CustomerController()
        {
            customerDBDAL = new CustomerDBDAL();
        }

        /// <summary>
        /// Method to retrieve the customer name list from the DB
        /// </summary
        /// <returns>The IncidentDBDal customers list</returns>
        public List<Customer> GetCustomers()
        {
            return customerDBDAL.GetCustomers();
        }
    }
}
