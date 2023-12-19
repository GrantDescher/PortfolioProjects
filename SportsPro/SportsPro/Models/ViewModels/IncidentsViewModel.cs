using System.Collections.Generic;

namespace SportsPro.Models.ViewModels
{
    public class IncidentsViewModel
    {
        public List<Incident> Incidents { get; set; } = new List<Incident>();

        public string IncidentFilter { get; set; } = "all";
    }
}
