using DevExpress.Web.Mvc;
using Incorporating.Models;
using Incorporating.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Incorporating.Controllers
{
    public class InvoiceController : BaseController<InvoiceViewModel>
    {
		protected override InvoiceViewModel CreateViewModel()
		{
			var result = base.CreateViewModel();

			result.Invoices = SampleData.Invoices;

			return result;
		}
		// GET: Invoice
		public ActionResult Index()
        {
			var model = CreateViewModel();

            return View(model);
        }

		[ValidateInput(false)]
		public ActionResult GridViewPartial(DateTime? filterDate, string searchText, string TestValue)
		{
			var model = CreateViewModel();

			return PartialView("_GridViewPartial", model);
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult GridViewPartialAddNew(Incorporating.Models.Invoice item)
		{
			var model = new object[0];
			if (ModelState.IsValid)
			{
				try
				{
					// Insert here a code to insert the new item in your model
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";
			return PartialView("_GridViewPartial", model);
		}
		[HttpPost, ValidateInput(false)]
		public ActionResult GridViewPartialUpdate(Incorporating.Models.Invoice item)
		{
			var model = new object[0];
			if (ModelState.IsValid)
			{
				try
				{
					// Insert here a code to update the item in your model
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";
			return PartialView("_GridViewPartial", model);
		}
		[HttpPost, ValidateInput(false)]
		public ActionResult GridViewPartialDelete(System.Int32 InvoiceID)
		{
			var model = new object[0];
			if (InvoiceID >= 0)
			{
				try
				{
					// Insert here a code to delete the item from your model
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			return PartialView("_GridViewPartial", model);
		}
	}
}