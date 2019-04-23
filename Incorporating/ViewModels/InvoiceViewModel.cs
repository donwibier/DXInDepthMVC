using Incorporating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Incorporating.ViewModels
{
	public class InvoiceViewModel : BaseViewModel
	{
		public IEnumerable<Invoice> Invoices { get; set; }
	}
}