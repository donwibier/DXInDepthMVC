using Incorporating.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Incorporating.Controllers
{
	public class HomeController : BaseController<HomeViewModel>
	{
		public ActionResult Index()
		{
			var model = CreateViewModel();
			model.Title = "ASP.NET";
			model.Content = "ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.";

			return View(model);
		}

		public ActionResult About()
		{
			var model = CreateViewModel();
			model.Title = "About";
			model.Content = "Your application description page.";
			

			return View(model);
		}

		public ActionResult Contact()
		{
			var model = CreateViewModel();
			model.Title = "Contact";
			model.Content = "Your contact page";

			return View(model);
		}
	}
}