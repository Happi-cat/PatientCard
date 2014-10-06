using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using PatientCard.Core;
using PatientCard.Core.Auth;
using PatientCard.Core.Models;
using PatientCard.Core.Services.Interfaces;
using PatientCard.Web.Models;

namespace PatientCard.Web.Controllers.Api
{
    public class AccountController : ApiController
    {
	    private readonly IAccountService _accountService;
	    private readonly IAuthService _authService;

		public AccountController()
		{
			_accountService = Bootstrap.BuildFactory.GetInstance<IAccountService>();
			_authService = new FormsAuthService(HttpContext.Current, _accountService);
		}

		[HttpPost]
		[ActionName("Login")]
		public object Login([FromBody]LoginModel login)
		{
			if (_authService.Login(login.Username, login.Password))
			{
				return _accountService.Get(new User { Username = login.Username});
			}
			return new HttpResponseMessage(HttpStatusCode.Unauthorized);
		}

		[HttpPost]
		[ActionName("Login-By-Cookie")]
		public object Login()
		{
			if (HttpContext.Current.User.Identity.IsAuthenticated)
			{
				return _accountService.Get(new User { Username = HttpContext.Current.User.Identity.Name });
			}
			return new HttpResponseMessage(HttpStatusCode.Unauthorized);
		}



		[HttpPost]
		[ActionName("Logout")]
		public HttpResponseMessage Logout([FromBody]LoginModel login)
		{
			_authService.Logout(login.Username);
			return new HttpResponseMessage(HttpStatusCode.OK);
		}

    }
}
