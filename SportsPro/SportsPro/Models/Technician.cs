using System;
using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Technician
    {
		public int TechnicianID { get; set; }

		[Required(ErrorMessage = "Please enter a name.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter a email address.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please enter a phone number.")]
		public string Phone { get; set; }

		public string Slug => Name.Replace(' ', '-').ToLower();
	}
}
