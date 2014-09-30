using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace PatientCard.Core.Auth
{
	public class FormsAuthPrincipalService : IPrincipalService
	{
		private readonly HttpContext _context;

		public FormsAuthPrincipalService(HttpContext context)
		{
			_context = context;
		}

		public IPrincipal GetCurrent()
		{
			HttpCookie authCookie = _context.Request.Cookies[FormsAuthentication.FormsCookieName];
			if (authCookie != null)
			{

				FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
				return new UserPrincipal(new UserIdentity(authTicket) );
			}

			// not sure what's happening, let's just default here to a Guest
			return new UserPrincipal(new UserIdentity((FormsAuthenticationTicket)null));
		}
	}
}