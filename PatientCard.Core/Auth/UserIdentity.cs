using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Web.Security;
using Newtonsoft.Json;
using PatientCard.Core.Models;

namespace PatientCard.Core.Auth
{
	public class UserIdentity : IIdentity
	{
		public UserIdentity(FormsAuthenticationTicket ticket)
		{
			if (ticket == null)
			{
				AsGuest();
				return;
			}

			var data = JsonConvert.DeserializeObject<UserCookie>(ticket.UserData);

			if (data == null)
			{
				AsGuest();
				return;
			}

			Username = data.Username;
			FirstName = data.FirstName;
			LastName = data.LastName;
			MiddleName = data.MiddleName;
			Name = string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName)
				       ? data.Username
				       : string.Format("{0} {1} {2}", data.LastName, data.FirstName, data.MiddleName);
			Roles = data.Roles ?? new List<string> { "user" };
		}

		public UserIdentity(User user, List<string> roles = null)
		{
			if (user == null)
			{
				AsGuest();
				return;
			}

			Username = user.Username;
			FirstName = user.FirstName;
			LastName = user.LastName;
			MiddleName = user.MiddleName;
			Name = string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName)
				       ? user.Username
				       : string.Format("{0} {1} {2}", user.LastName, user.FirstName, user.MiddleName);
			Roles = roles ?? new List<string> { "user" };
		}

		private void AsGuest()
		{
			Name = "Guest";
			Roles = new List<string> { "guest" };
		}

		public string Username { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public List<string> Roles { get; set; }
		public bool RememberMe { get; set; }

		#region IIdentity Members

		public string AuthenticationType
		{
			get { return "PatientCardAuthForm"; }
		}

		public bool IsAuthenticated
		{
			get { return !(string.IsNullOrEmpty(Username) || string.IsNullOrWhiteSpace(Username)); }
		}

		public string Name { get; protected set; }

		#endregion
	}
}