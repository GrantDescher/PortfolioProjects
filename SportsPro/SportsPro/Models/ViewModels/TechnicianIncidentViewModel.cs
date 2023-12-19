using System.Collections.Generic;

namespace SportsPro.Models.ViewModels
{
    public class TechnicianIncidentViewModel
    {
        public Technician Technician { get; set; } = new Technician();

        public Incident Incident { get; set; } = new Incident();

        public IEnumerable<Incident> Incidents { get; set; } = null!;
    }
}
