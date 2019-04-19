using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Incorporating.ViewModels
{
	public class NavigationItem
	{
		
		public NavigationItem()
		{
			
		}

		public string Title { get; set; }
		public string ActionMethod { get; set; }
		public string Controller { get; set; }

		IEnumerable<NavigationItem> items;
		public IEnumerable<NavigationItem> Items
		{
			get
			{
				if (items == null)
					items = new List<NavigationItem>();
				return items;
			}
			set { items = value; }
		}
	}
	public class BaseViewModel
	{
		public string AppTitle { get; set; } = "MyDX Sample App";		
		public IEnumerable<NavigationItem> MainNavigationItems { get; set; }
	}
}