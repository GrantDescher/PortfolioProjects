using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;
using SportsPro.Models.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace SportsPro.Controllers
{
	[Authorize(Roles = "Admin")]
	public class TechnicianController : Controller
	{
		private Repository<Technician> technicianData { get; set; }
		public TechnicianController(SportsProContext ctx)
		{
			technicianData = new Repository<Technician>(ctx);
		}

		[Route("technicians")]
		public IActionResult List()
		{
			List<Technician> technicians = technicianData.List(new QueryOptions<Technician>
			{
				OrderBy = t => t.Name,
				Where = t => t.TechnicianID > 0
			}).ToList();
			return View(technicians);
		}

		[HttpGet]
		public IActionResult Add()
		{
			ViewBag.Action = "Add";
			return View("Edit", new Technician());
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			ViewBag.Action = "Edit";
			Technician technician = technicianData.Get(id)!;
			return View(technician);
		}

		[HttpPost]
		public IActionResult Edit(Technician technician)
		{
			if(ModelState.IsValid)
			{
				if(technician.TechnicianID == 0)
				{
					technicianData.Insert(technician);
				}
				else
				{
					technicianData.Update(technician);
				}

				technicianData.Save();

				return RedirectToAction("List", "Technician");
			}
			else
			{
				ViewBag.Action = (technician.TechnicianID == 0) ? "Add" : "Edit";

				return View(technician);
			}
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			Technician technician = technicianData.Get(id)!;
			return View(technician);
		}

		[HttpPost]
		public IActionResult Delete(Technician technician)
		{
			technicianData.Delete(technician);
			technicianData.Save();
			return RedirectToAction("List", "Technician");
		}
	}
}
