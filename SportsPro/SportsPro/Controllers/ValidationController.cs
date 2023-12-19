using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;
using SportsPro.Models.DataAccess;
using SportsPro.Models.Validation;

namespace SportsPro.Controllers
{
    public class ValidationController : Controller
	{
		private Repository<Customer> customerData {  get; set; }

		public ValidationController(SportsProContext ctx)
		{
			customerData = new Repository<Customer>(ctx);
		}

		public JsonResult CheckEmail(string email, int customerID)
		{
			Customer customer = new Customer { Email = email, CustomerID = customerID };

			string msg = Validate.CheckEmail(customerData, customer);

			if (string.IsNullOrEmpty(msg))
			{
				return Json(true);
            }
			else
			{
				return Json(msg);
			}
		}
	}
}
