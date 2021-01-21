﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class Incident
    {
        public string Title { get; }

        public string Description { get; }

        public int CustomerID { get; }

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
