using Incorporating.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Incorporating.Controllers
{
	public class ContactController : BaseController<ContactViewModel>
	{
		// GET: Contact
		public ActionResult Index()
		{
			var model = CreateViewModel();

			return View(model);
		}

		[HttpPost]
		public ActionResult Post(ContactViewModel values)
		{
			var model = CreateViewModel();



			return View(model);
		}
	}
}