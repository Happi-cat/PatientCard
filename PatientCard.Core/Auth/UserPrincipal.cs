using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PatientCard.Core.Auth
{
	public class UserPrincipal : IPrincipal
	{
		private readonly UserIdentity _identity;

		public UserPrincipal(UserIdentity identity)
		{
			_identity = identity;
		}

		#region IPrincipal Members

		public bool IsInRole(string role)
		{
			return
				_identity.Roles.Any(
					current => string.Compare(current, role, StringComparison.InvariantCultureIgnoreCase) == 0);
		}

		public IIdentity Identity
		{
			get { return _identity; }
		}

		public UserIdentity Information
		{
			get { return _identity; }
		}

		public bool IsUser
		{
			get { return !IsGuest; }
		}

		public bool IsGuest
		{
			get { return IsInRole("guest"); }
		}

		#endregion
	}
}
