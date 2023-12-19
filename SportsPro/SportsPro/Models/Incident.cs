using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Incident
    {
		public int IncidentID { get; set; }

		[Required]
		public int CustomerID { get; set; }     // foreign key property

		[ValidateNever]
		public Customer Customer { get; set; }  // navigation property

		[Required]
		public int ProductID { get; set; }     // foreign key property

		[ValidateNever]
		public Product Product { get; set; }   // navigation property

		public int? TechnicianID { get; set; }     // foreign key property - nullable

		[ValidateNever]
		public Technician Technician { get; set; }   // navigation property

		[Required(ErrorMessage = "Please enter a title.")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Please enter a description.")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Please enter a date opened.")]
		[DataType(DataType.Date)]
		public DateTime DateOpened { get; set; } = DateTime.Now;

		public DateTime? DateClosed { get; set; } = null;
	}
}