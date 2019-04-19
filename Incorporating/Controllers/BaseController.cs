using Incorporating.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Incorporating.Controllers
{
	public abstract class BaseController<TViewModelClass> : Controller
		where TViewModelClass : BaseViewModel, new()
	{
		static readonly NavigationItem[] _main = new NavigationItem[]
		{
				new NavigationItem(){Title ="Home", ActionMethod="Index",Controller="Home" },
				new NavigationItem(){Title ="About", ActionMethod="About",Controller="Home" },
				new NavigationItem(){Title ="Contact", ActionMethod="Index",Controller="Contact" }
		};

		protected virtual TViewModelClass CreateViewModel()
		{
			var result = new TViewModelClass();
			result.AppTitle = "My DX App";
			result.MainNavigationItems = _main;
			return result;
		}

	}
}