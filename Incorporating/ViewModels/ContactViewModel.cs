using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Incorporating.ViewModels
{
	public class ContactViewModel : HomeViewModel
	{
		[Required]
		public string Name { get; set; }
		
		[Required(AllowEmptyStrings = false)]
		[EmailAddress(ErrorMessage = "Please specify a valid e-mail address")]
		public string Email { get; set; }

		[Required(AllowEmptyStrings = false)]
		[EmailAddress(ErrorMessage ="Please specify a valid e-mail address")]
		[Compare("Email", ErrorMessage = "Both e-mail addresses should be the same")]
		public string EmailConfirm { get; set; }

		[Required]
		public string Question { get; set; }

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
		public string Suffix { get; set; }
		public string Prefix { get; set; }
	}
}