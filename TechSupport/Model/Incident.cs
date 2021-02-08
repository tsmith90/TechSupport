namespace TechSupport.Model
{
    /// <summary>
    /// Model for the Incident object
    /// </summary>
    public class Incident
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string ProductCode { get; set; }

        public string TechnicianName { get; set; }

        public string DateOpened { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
