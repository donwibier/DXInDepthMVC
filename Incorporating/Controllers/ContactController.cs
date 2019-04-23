using DevExpress.Web;
using DevExpress.Web.Mvc;
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
			//bool isValid = true;

			//model.Name = EditorExtension.GetValue<string>("Name", 
			//	ContactValidationHelper.NameValidation,
			//	ContactValidationHelper.OnNameValidation, ref isValid);

			//if (!isValid)
			//{
			//	model.ValidationError = true;
			//	model.ValidationErrorMessage = "Something was not ok";
			//}

			if (ModelState.IsValid)
			{

			}
			else
			{

			}

			return View(model);
		}

		public JsonResult CheckIfExists(string email)
		{
			bool result = email == "donw@devexpress.com";

			return Json(!result, JsonRequestBehavior.AllowGet);
		}
	}


	public class ContactValidationHelper
	{
		static ValidationSettings nameValidation;

		public static ValidationSettings NameValidation
		{
			get
			{
				if (nameValidation == null)
				{
					nameValidation = ValidationSettings.CreateValidationSettings(null);
					nameValidation.Display = Display.Dynamic;
					nameValidation.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
					nameValidation.ErrorText = "Name is required";
				}
				return nameValidation;
			}
		}
		public static void OnNameValidation(object sender, ValidationEventArgs e)
		{
			if (e.Value == null)
			{
				e.IsValid = false;
				return;
			}
			var name = e.Value.ToString();
			if (name == string.Empty)
				e.IsValid = false;
			if (name.Length > 50)
			{
				e.IsValid = false;
				e.ErrorText = "Must be under 50 characters";
			}
		}


	}
}