using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Incorporating.ViewModels
{
	public class ContactViewModel : HomeViewModel
	{

		private NameClass name = null;
		public NameClass Name
		{
			get
			{
				if (name == null)
					name = new NameClass();
				return name;
			}
			set { name = value; }
		}

		[Required(AllowEmptyStrings = false)]
		[EmailAddress(ErrorMessage = "Please specify a valid e-mail address")]
		[System.Web.Mvc.Remote("CheckIfExists", "Contact", ErrorMessage = "You're the creator of this app. You should answer questions instead of submitting them!")]
		public string Email { get; set; }

		[Required(AllowEmptyStrings = false)]		
		[Compare("Email", ErrorMessage = "Both e-mail addresses should be the same")]
		public string EmailConfirm { get; set; }

		[Required]
		public string Question { get; set; }
		public bool ValidationError { get; set; }
		public string ValidationErrorMessage { get; set; }
	}

	public class NameClass
	{
		
		public NameClass()
		{
			
		}

		[Required]
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		[Required]
		public string LastName { get; set; }
	}
}