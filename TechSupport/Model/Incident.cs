using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Model for the Incident object
    /// </summary>
    public class Incident
    {
        public int IncidentID { get; set; }

        public int CustomerID { get; set; }

        public string ProductCode { get; set; }

        public int TechID { get; set; }

        public string DateOpened { get; set; }

        public string DateClosed { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
