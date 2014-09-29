using System.Collections.Generic;

namespace PatientCard.Core.Auth
{
	public class UserCookie
	{
		public UserCookie()
		{
			Roles = new List<string>();
		}

		public string Username { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string TimeZone { get; set; }
		public List<string> Roles { get; set; }
		public bool RememberMe { get; set; }
	}
}