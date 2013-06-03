using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projektdatenbank.Models;

namespace Projektdatenbank.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Willkommen bei ASP.NET MVC";

			var model = new TKunde()
			{
				KuID = 12,
				KuName = "Fleischer",
				KuVorname = "Horst",
				KuEmail = "Horst@horst.de"
			};

			return View(model);
		}

		public ActionResult About()
		{
			return View();
		}
	}
}
