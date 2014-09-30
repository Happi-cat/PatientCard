using System;
using System.Web;
using System.Web.Security;
using Newtonsoft.Json;
using PatientCard.Core.Models;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Auth
{
	public class FormsAuthService : IAuthService
	{
		private readonly HttpContextBase _httpContext;
		private readonly IAccountService _accountService;

		public FormsAuthService(HttpContextBase httpContext, IAccountService accountService)
		{
			_httpContext = httpContext;
			_accountService = accountService;
		}


		public bool Login(string username, string password)
		{
			if (_accountService.Login(username, password))
			{
				var user = _accountService.Get(new User {Username = username});
				if (user == null)
					throw new ArgumentNullException("user");

				var cookie = new UserCookie
				{
					Username = user.Username,
					FirstName = user.FirstName,
					LastName = user.LastName,
					MiddleName = user.MiddleName,
					RememberMe = true
				};

				string userData = JsonConvert.SerializeObject(cookie);
				var ticket = new FormsAuthenticationTicket(1, cookie.Username, DateTime.Now,
														   DateTime.Now.Add(FormsAuthentication.Timeout),
														   true, userData);
				string encTicket = FormsAuthentication.Encrypt(ticket);
				var httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket) { Expires = DateTime.Now.Add(FormsAuthentication.Timeout) };

				_httpContext.Response.Cookies.Add(httpCookie);
				return true;
			}
			return false;
		}

		public bool SignUp(string username, string password)
		{
			return _accountService.SignUp(username, password);
		}

		public bool Logout(string username)
		{
			_accountService.Logout(username);
			FormsAuthentication.SignOut();
			return true;
		}
	}
}