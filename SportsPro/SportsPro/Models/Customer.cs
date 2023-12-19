using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Models
{
    public class Customer
    {
		public int CustomerID { get; set; }

		[Required(ErrorMessage = "First Name is Required.")]
		[StringLength (50, ErrorMessage = "Field must be <= 50 characters.")]
		public string FirstName { get; set; } = string.Empty;

		[Required(ErrorMessage = "Last Name is Required.")]
		[StringLength(50, ErrorMessage = "Field must be <= 50 characters.")]
		public string LastName { get; set; } = string.Empty;

		[Required(ErrorMessage = "Address is Required.")]
		[StringLength(50, ErrorMessage = "Field must be <= 50 characters.")]
		public string Address { get; set; } = string.Empty;

		[Required(ErrorMessage = "City is Required.")]
		[StringLength(50, ErrorMessage = "Field must be <= 50 characters.")]
		public string City { get; set; } = string.Empty;

		[Required(ErrorMessage = "State is Required.")]
		[StringLength(50, ErrorMessage = "Field must be <= 50 characters.")]
		public string State { get; set; } = string.Empty;

		[Required(ErrorMessage = "Postal Code is Required.")]
		[StringLength(20, ErrorMessage = "Field must be <= 20 characters.")]
		public string PostalCode { get; set; } = string.Empty;

		[Required(ErrorMessage = "Country is Required.")]
		public string CountryID { get; set; }

		[ValidateNever]
		public Country Country { get; set; }

		[RegularExpression(@"^((\d{3}\) ?)\(\d{3}-)?\d{3}-\d{4}$", 
			ErrorMessage = "Phone number must be in (999) 999-9999 format.")]
		public string Phone { get; set; } = string.Empty;

		[Required(ErrorMessage = "Email is  Required.")]
		[StringLength(50, ErrorMessage = "Field must be <= 50 characters.")]
		[DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address.")]
		[Remote("CheckEmail", "Validation", AdditionalFields = "CustomerID")]
		public string Email { get; set; } = string.Empty;


		public string FullName => FirstName + " " + LastName;   // read-only property

		public string Slug => FirstName?.Replace(" ", "-").ToLower() + LastName?.Replace(" ", "-").ToLower();

		public ICollection<Product> Products { get; set; } // skip nav property
	}
}