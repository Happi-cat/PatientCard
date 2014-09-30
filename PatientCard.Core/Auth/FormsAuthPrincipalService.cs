using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace PatientCard.Core.Auth
{
	public class FormsAuthPrincipalService : IPrincipalService
	{
		private readonly HttpContextBase _context;

		public FormsAuthPrincipalService(HttpContextBase context)
		{
			_context = context;
		}

		public IPrincipal GetCurrent()
		{
			IPrincipal user = _context.User;
			// if they are already signed in, and conversion has happened
			if (user != null && user is UserPrincipal)
				return user;

			// if they are signed in, but conversion has still not happened
			if (user != null && user.Identity.IsAuthenticated && user.Identity is FormsIdentity)
			{
				var id = (FormsIdentity)_context.User.Identity;

				var ticket = id.Ticket;
				if (FormsAuthentication.SlidingExpiration)
					ticket = FormsAuthentication.RenewTicketIfOld(ticket);

				var fid = new UserIdentity(ticket);
				return new UserPrincipal(fid);
			}

			// not sure what's happening, let's just default here to a Guest
			return new UserPrincipal(new UserIdentity((FormsAuthenticationTicket)null));
		}
	}
}