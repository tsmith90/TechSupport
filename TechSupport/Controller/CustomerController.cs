using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    class CustomerController
    {
        private static CustomerDBDAL customerDBDAL;

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
