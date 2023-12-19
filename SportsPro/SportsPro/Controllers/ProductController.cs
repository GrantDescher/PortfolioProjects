using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;
using SportsPro.Models.DataAccess;

namespace SportsPro.Controllers
{
	[Authorize(Roles = "Admin")]
    public class ProductController : Controller
	{
		private Repository<Product> productData {  get; set; }
		 
		public ProductController(SportsProContext ctx) 
		{
			productData = new Repository<Product>(ctx);
		}

		[Route("products")]
		public ViewResult List()
		{
			var products = productData.List(new QueryOptions<Product>
			{
				OrderBy = p => p.ReleaseDate!
			});
			return View(products);
		}

		[HttpGet]
		public ViewResult Add()
		{
			ViewBag.Action = "Add";
			return View("Edit", new Product());
		}

		[HttpGet]
		public ViewResult Edit(int id)
		{
			ViewBag.Action = "Edit";
			var product = productData.Get(id);
			return View(product);
		}

		[HttpPost]
		public IActionResult Edit(Product product)
		{
			if(ModelState.IsValid)
			{
				if(product.ProductID == 0)
				{
					productData.Insert(product);
					TempData["message"] = $"{product.Name} was added.";
				}
				else
				{
					productData.Update(product);
                    TempData["message"] = $"{product.Name} was edited.";
                }

				productData.Save();
				return RedirectToAction("List", "Product");
			}
			else
			{
				ViewBag.Action = (product.ProductID == 0) ? "Add" : "Edit";
				return View(product);
			}
		}

		[HttpGet]
		public ViewResult Delete(int id)
		{
			var product = productData.Get(id);
			return View(product);
		}

		[HttpPost]
		public RedirectToActionResult Delete(Product product)
		{
			string Name = product.Name;
			TempData["message"] = $"{Name} was deleted.";
			productData.Delete(product);
			productData.Save();
			return RedirectToAction("List", "Product");
		}
	}
}
