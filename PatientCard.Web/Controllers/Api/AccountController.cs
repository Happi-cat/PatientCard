using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using PatientCard.Core;
using PatientCard.Core.Auth;
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
		public HttpResponseMessage Login([FromBody]LoginModel login)
		{
			if (_authService.Login(login.Username, login.Password))
			{
				return new HttpResponseMessage(HttpStatusCode.OK);
			}
			return new HttpResponseMessage(HttpStatusCode.Unauthorized);
		}
    }
}
