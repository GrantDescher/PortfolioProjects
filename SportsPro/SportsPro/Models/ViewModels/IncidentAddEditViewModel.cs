using System.Collections.Generic;

namespace SportsPro.Models.ViewModels
{
    public class IncidentAddEditViewModel
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public List<Product> Products { get; set; } = new List<Product>();

        public List<Technician> Technicians { get; set; } = new List<Technician>();

        public Incident Incident { get; set; } = new Incident();

        public string Action { get; set; } = "Add";
    }
}
