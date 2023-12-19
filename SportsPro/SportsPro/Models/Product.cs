using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsPro.Models
{
    public class Product
    {
		public Product() => Customers = new HashSet<Customer>();

		public int ProductID { get; set; }

		[Required(ErrorMessage = "Please enter a product code.")]
		public string ProductCode { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter a product name.")]
		public string Name { get; set; } = string.Empty;

		[Range(0, 1000000)]
		[Column(TypeName = "decimal(8,2)")]
		public decimal YearlyPrice { get; set; } = 0.00M;

		[Required(ErrorMessage = "Please enter a release date.")]
		public DateTime ReleaseDate { get; set; } = DateTime.Now;

		public string Slug()
		{
			return Name.Replace(' ', '-').ToLower();
		}

		// Navigation property to linking entity
		public ICollection<Customer> Customers { get; set; }
	}
}
